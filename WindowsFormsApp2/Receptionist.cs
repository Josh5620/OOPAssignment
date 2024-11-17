using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Receptionist : User
    {

        private string dbPath;
        public SQLiteConnection connection;
        public SQLiteDataAdapter dataAdapter;

        public Receptionist()
        {
            string solutionDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\");
            dbPath = Path.Combine(solutionDir, "UserDatabase.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            connection = new SQLiteConnection(connectionString);
            connection.Open();

        }

        public void DeleteCustomerRecord(int userID)
        {
            MessageBox.Show($"{userID}");

            string deleteQuery = $"DELETE FROM Customer_Table WHERE CustomerId = {userID}";
            using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
            {

                // Execute the DELETE command
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record Successfully deleted!");
                }
                else
                {
                    MessageBox.Show("An Error has occured!");
                }
            }
        }

        public void AddCustomerRecord(string fullName, 
                                      string username, string vehicleNumber,
                                      string password, string ServiceChoice)
        {

                string query = $"INSERT INTO Customer_Table (FullName, Password, Username, VehicleNumber, ServiceID ) " +
                               $"VALUES (@FullName, @Password, @Username, @VehicleNumber, @ServiceID)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@VehicleNumber", vehicleNumber);
                    cmd.Parameters.AddWithValue("@ServiceID", ServiceChoice);



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record added successfully.");

                }

        }

        public SQLiteDataReader LoadOrderTable()
        {
            string query = @"SELECT o.OrderID, s.FullName AS StaffName, o.StaffID, o.EngineParts, 
                     o.SpareWheels, o.Oil, o.Headlights, o.ExhaustPipe 
                     FROM Order_Table o JOIN Staff_Table s ON o.StaffID = s.StaffID";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            return reader; // Return the reader (keep the connection open)

            // just match the order id with the staff id as only the mechanics should be able to make orders 
        }

        public DataTable LoadAppTable()
        {
            string query = "SELECT AppointmentId, FullName, CustomerId, ServiceId, MechanicId, VehicleNumber, AppointmentDate, Status FROM Appointments WHERE Status IS NOT 'Completed' OR Status IS NULL";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);


            dataAdapter = new SQLiteDataAdapter(cmd); 
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            return dataTable;
            // make the query and make 1 to track the mechanic IDs and assisnge to those witheout the status done.
        }

        public SQLiteDataReader LoadStaffIds()
        {
            string query = @"SELECT s.StaffId, s.FullName AS StaffName 
                 FROM Staff_Table s
                 WHERE s.JobType = 'Mechanic'";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            return reader; 
        }

        public SQLiteDataReader LoadAppLists()
        {
            string query = @"SELECT a.AppointmentId, a.FullName, a.MechanicId, a.Status, a.BillAmount 
                 FROM Appointments a
                 WHERE a.MechanicId IS NOT NULL;";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public DataTable LoadDataGrid(string tableName)
        {
            var validTables = new Dictionary<string, string>
    {
        { "staff", "Staff_Table" },
        { "customer", "Customer_Table" },
        { "service", "Service_Table" },
        { "feedback", "Feedback" },
        { "appointment", "Appointments" },
        { "profile", "Profile_Table" },
        { "order", "Order_Table" }
    };

            if (!validTables.ContainsKey(tableName.ToLower()))
            {
                throw new ArgumentException("Invalid table name.");
            }

            string query = $"SELECT * FROM {validTables[tableName.ToLower()]}";

   
                // Always create a new SQLiteDataAdapter to ensure fresh data
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    try
                    {
                        adapter.Fill(dataTable); // Always fill a new DataTable
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading data: {ex.Message}");
                    }
                    return dataTable;
                }
            
        }

        public void UpdateStatus(int appointmentId)
        {
            string updateQuery = @"UPDATE Appointments 
                           SET Status = 
                               CASE 
                                   WHEN Status = 'Arriving' THEN 'Servicing' 
                                   WHEN Status = 'Servicing' THEN 'Completed' 
                                   ELSE Status 
                               END
                           WHERE AppointmentId = @AppointmentId";


            SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection);

            cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
            cmd.ExecuteNonQuery();
            MessageBox.Show($"ID:{appointmentId} has been updated!");
        }

        public void UpdateProfile(
    string username,
    string fullName,
    string password,
    string email,
    string phoneNumber,
    string address)
        {
            var updates = new Dictionary<string, Dictionary<string, string>>
    {
        { "Profile_Table", new Dictionary<string, string>
            {
                { "Email", email?.Trim() },
                { "PhoneNumber", phoneNumber?.Trim() },
                { "Address", address?.Trim() }
            }
        },
        { "Staff_Table", new Dictionary<string, string>
            {
                { "FullName", fullName?.Trim() },
                { "Password", password?.Trim() }
            }
        }
    };

                foreach (var table in updates)
                {
                    var fieldsToUpdate = table.Value
                        .Where(field => !string.IsNullOrEmpty(field.Value))
                        .Select(field => $"{field.Key} = @{field.Key}");

                    if (fieldsToUpdate.Any())
                    {
                        string query = table.Key == "Profile_Table"
                            ? $"UPDATE {table.Key} SET {string.Join(", ", fieldsToUpdate)} WHERE ProfileID = (SELECT ProfileID FROM Staff_Table WHERE Username = @Username)"
                            : $"UPDATE {table.Key} SET {string.Join(", ", fieldsToUpdate)} WHERE Username = @Username";

                        using (var command = new SQLiteCommand(query, connection))
                        {
                            foreach (var field in table.Value.Where(field => !string.IsNullOrEmpty(field.Value)))
                            {
                                command.Parameters.AddWithValue($"@{field.Key}", field.Value);
                            }
                            command.Parameters.AddWithValue("@Username", username);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Profile updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        public Dictionary<string, string> GetProfileInfo(string Username)
        {
            Dictionary<string, string> profileInfo = new Dictionary<string, string>();


                string query = @"
                        SELECT 
                            p.ProfileID, 
                            p.Email, 
                            p.PhoneNumber, 
                            p.Address, 
                            s.FullName, 
                            s.Password,
                            s.Username
                        FROM 
                            Profile_Table p, 
                            Staff_Table s
                         WHERE s.Username = @Username";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            profileInfo["FullName"] = reader["FullName"].ToString();
                            profileInfo["Username"] = reader["Username"].ToString();
                            profileInfo["Email"] = reader["Email"].ToString();
                            profileInfo["PhoneNumber"] = reader["PhoneNumber"].ToString();
                            profileInfo["Address"] = reader["Address"].ToString();
                            profileInfo["Password"] = reader["Password"].ToString();


                        }
                    }
                }
            

            return profileInfo;
        }

        public SQLiteDataReader LoadServiceChoice()
        {
            string query = @"SELECT ServiceID, ServiceName
                            FROM Service_Table;";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            return reader;

        }

    }

}
