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
        // Private backing fields for properties
        private string _username;
        private string _password;
        private string _jobType;

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

        protected SQLiteDataAdapter dataAdapter;
        protected SQLiteDataAdapter dataAdapterRecep;
        private SQLiteConnection connection;

        // Public properties with encapsulation
        public string Username
        {
            get => _username;
            set => _username = value ?? throw new ArgumentNullException(nameof(value), "Username cannot be null");
        }

        public string Password
        {
            get => _password;
            set => _password = value ?? throw new ArgumentNullException(nameof(value), "Password cannot be null");
        }

        public string JobType
        {
            get => _jobType;
            set => _jobType = value ?? throw new ArgumentNullException(nameof(value), "JobType cannot be null");
        }

        public User(string username, string password, string jobType)
        {
            Username = username;
            Password = password;
            JobType = jobType;
        }

        public User() { }

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
        public static User Authenticate(string username, string password, string jobType)
        {
            User authenticatedUser = null;

            User tempUser = new User();
            using (SQLiteConnection connection = new SQLiteConnection(tempUser.connectionString))
            {
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
                    authenticatedUser = new User(
                        reader["Username"].ToString(),
                        reader["Password"].ToString(),
                        reader["JobType"].ToString()
                    );
                }
            }

            return authenticatedUser;
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

            using (SQLiteConnection connection = GetDatabaseConnection())
            {
                // Always create a new SQLiteDataAdapter to ensure fresh data
                SQLiteCommand command = new SQLiteCommand(query, connection);
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
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
                    dataAdapterRecep = adapter;
                    return dataTable;
                }
            }
        }

        public Dictionary<string, string> GetProfileInfo(string Username1)
        {
            Dictionary<string, string> profileInfo = new Dictionary<string, string>();

            using (SQLiteConnection connection = GetDatabaseConnection())
            {
                string query = @"SELECT FullName, Username, Email, JobType 
                         FROM Profile_Table 
                         WHERE Username = @Username";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username1);

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
