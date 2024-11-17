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
        private SQLiteDataAdapter dataAdapter;      // Sets both connection and dataAdapter to class lvl variables and determines the main database file path
        public SQLiteConnection connection;


        public Receptionist()
        {
            string solutionDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\");
            dbPath = Path.Combine(solutionDir, "UserDatabase.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        public void RefreshDatabase(DataTable dt)
        {
            if (dataAdapter == null)
            {
                // Handle the case where dataAdapter is still null
                MessageBox.Show("DataAdapter is not initialized. Please load data first.");
                return;
            }

            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            dataAdapter.Update(dt);
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

        public void AddCustomerRecord(string fullName, string contactInfo,
                                      string username, string vehicleNumber,
                                      string address, string ServiceChoice)
        {
            Dictionary<string, string> serviceOptions = new Dictionary<string, string>
             {
                { "1", "Placeholder1" },
                { "2", "Placeholder2" },
                { "3", "Placeholder3" }         // Change the placeholders and the ones below when we decided what servicesto add 
             };

            try
            {
                string query = $"INSERT INTO Customer_Table (FullName, Password, ContactInfo, Username, VehicleNumber, Address, {serviceOptions[ServiceChoice]}) " +
                               $"VALUES (@FullName, @Password, @ContactInfo, @Username, @VehicleNumber, @Address, @{serviceOptions[ServiceChoice]})";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Password", "N/A");
                    cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@VehicleNumber", vehicleNumber);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue($"@{serviceOptions[ServiceChoice]}", true);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding the record: {ex.Message}");
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
            MessageBox.Show("Number of rows returned: " + dataTable.Rows.Count);


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

    }

}
