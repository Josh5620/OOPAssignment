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
        { get 
            { 
                // Constructs the path to the database
                string solutionDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\");

                // Database path
                string dbpath = Path.Combine(solutionDir, "UserDatabase.db");
                return $"Data Source={dbpath};Version=3;";
            }
        }

        private SQLiteDataAdapter dataAdapter;
        private SQLiteConnection connection;
        
        //Optional use for class connection to database.
        protected SQLiteConnection GetDatabaseConnection()
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
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

        public static User Authenticate(string username, string password)
        {
            User authenticatedUser = null;

            User tempUser = new User();
            using (SQLiteConnection connection = new SQLiteConnection(tempUser.connectionString))
            {
                // The query searches in both tables, with JobType used to differentiate between roles
                string query = @"
                SELECT staff_id AS UserID, Username, Password, JobType
                FROM Staff_Table 
                WHERE Username = @Username AND Password = @Password
                UNION
                SELECT customer_id AS UserID, Username, Password, 'Customer' AS JobType
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
    }

}
