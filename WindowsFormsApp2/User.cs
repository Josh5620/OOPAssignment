using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class User
    {

        protected string connectionString
        {
            get
            {
                string dbpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserDatabase.db");
                if (!File.Exists(dbpath))
                {
                    throw new FileNotFoundException($"Database file not found at {dbpath}");
                }
                return $"Data Source={dbpath};Version=3;";
            }
        }

        private SQLiteDataAdapter dataAdapter;
        private SQLiteConnection connection;

        //Optional use for class connection to database.
        protected SQLiteConnection GetDatabaseConnection()
        {
            try
            {
                var connection = new SQLiteConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception($"Database connection failed: {ex.Message}");
            }
        }

        public string Username;
        public string Password;
        public string JobType;

        public void RefreshDatabase(DataTable dt)
        {
            if (dataAdapter == null)
            {
                MessageBox.Show("DataAdapter is not initialized. Please load data first.");
                return;
            }

            try
            {
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
                dataAdapter.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh the database: {ex.Message}");
            }
        }


        public User(string username, string password, string jobType)
        {
            Username = username;
            Password = password;
            JobType = jobType;
        }
        public User() 
        { }

        public static User Authenticate(string username, string password, string JobType)
        {
            User authenticatedUser = null;

            User tempUser = new User();
            using (SQLiteConnection connection = new SQLiteConnection(tempUser.connectionString))
            {
                // The query searches in both tables, with JobType used to differentiate between roles
                string query = @"
                SELECT StaffID AS UserID, Username, Password, JobType
                FROM Staff_Table 
                WHERE Username = @Username AND Password = @Password
                UNION
                SELECT CustomerId AS UserID, Username, Password, 'Customer' AS JobType
                FROM Customer_Table 
                WHERE Username = @Username AND Password = @Password";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Create the authenticated user based on the data from the database
                    authenticatedUser = new User(
                        reader["Username"].ToString(),
                        reader["Password"].ToString(),
                        reader["JobType"].ToString()
                    );
                    var userId = reader["UserID"].ToString();
                }
            }

            return authenticatedUser;
        }

        public DataTable LoadDataGrid(string tableName)  // General Function to load tables for data grid view
        {
            // Keys used to load specific tables from the database
            var validTables = new Dictionary<string, string>()
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

            // Ensure the connection is open and properly managed
            using (SQLiteConnection connection = GetDatabaseConnection())
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                dataAdapter = new SQLiteDataAdapter(command);

                DataTable dataTable = new DataTable();
                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Handle exceptions and provide feedback
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }

                return dataTable;
            }
        }

        // Method to fetch user profile details
        public Dictionary<string, string> GetProfileInfo()
        {
            Dictionary<string, string> profileInfo = new Dictionary<string, string>();

            using (SQLiteConnection connection = GetDatabaseConnection())
            {
                string query = @"SELECT FullName, Username, Email, JobType 
                         FROM Profile_Table 
                         WHERE Username = @Username";

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
                            profileInfo["JobType"] = reader["JobType"].ToString();
                        }
                    }
                }
            }

            return profileInfo;
        }

    }

}
