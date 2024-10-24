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
    public class Admin : User
    {
        private SQLiteConnection connection;  // Initializes the connection and the datatables. 
        private DataTable staffData;
        private DataTable customerData;

        public Admin()
        {
            // Get the database connection from the User class
            connection = GetDatabaseConnection();

            // Initialize the DataTables by loading the respective tables
            staffData = LoadDataGrid("staff");
            customerData = LoadDataGrid("customer");
        }

        public DataTable StaffData
        {
            get => staffData;
            set => staffData = value;
        }

        public DataTable CustomerData
        {
            get => customerData;
            set => customerData = value;
        }

        public void InsertRecord(string tableName, Dictionary<string, object> columns)
        {
            // Constructs the column names and parameters for the SQL query
            string columnNames = string.Join(",", columns.Keys);
            string parameters = string.Join(", ", columns.Keys.Select(k => $"@{k}"));

            // Form the SQL query
            string insertQuery = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameters})";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    foreach (var column in columns)
                    {
                        cmd.Parameters.AddWithValue($"@{column.Key}", column.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record to {tableName}: {ex.Message}");
            }
        }

        public void DeleteRecord(string tableName, string columnName, object value)
        {
            // Form the SQL query
            string deleteQuery = $"DELETE FROM {tableName} WHERE {columnName} = @{columnName}";

            try 
            {
                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    // Add the parameters for the condition
                }
            }
        }

        public void AddStaff(int StaffId, string fullName, string username, string password, string jobType)
        {
            var staffData = new Dictionary<string, object>
            {
                { "FN", fullName },
                { "username", username },
                { "password", password },
                { JobType, jobType }
            };
            InsertRecord("Staff_Table", staffData);
        }

        public void DeleteStaff(int StaffId)
        {
            // StaffId shown for debugging services
            MessageBox.Show($"{StaffId}");

            string deletestaffquery = $"DELETE FROM Staff_Table WHERE StaffId = {StaffId}";
            using (SQLiteCommand cmd = new SQLiteCommand(deletestaffquery, connection))
            {

                // Run the delete command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Provide feedback on the number of rows affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Successfully deleted {rowsAffected} staff member(s).");
                }
                else
                {
                    MessageBox.Show("No staff member found with the provided Staff ID.");
                }
            }
        }

        public void AddService(int ServiceId, string ServiceName, string Description, int price, string EstimatedTime)
        {
            var serviceData = new Dictionary<string, object>
            {
                { "Sn", ServiceName },
                { "description", Description },
                { "Price", price },
                { "ET", EstimatedTime }
            };
            InsertRecord("Service_Table", serviceData);
        }
    }
}



