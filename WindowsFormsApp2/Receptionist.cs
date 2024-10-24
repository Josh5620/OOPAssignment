using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Receptionist : User
    {

        private string dbPath;
        private SQLiteDataAdapter dataAdapter;      // Sets both connection and dataAdapter to class lvl variables and determines the main database file path
        private SQLiteConnection connection;


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
            string query = "SELECT AppointmentID, FullName, CustomerId, ServiceId, MechanicId, VehicleNumber, AppointmentDate " +
               "FROM Appointments " +
               "WHERE Status != 'Completed';";

            // make the query and make 1 to track the mechanic IDs and assisnge to those witheout the status done.
        }


    }
}
