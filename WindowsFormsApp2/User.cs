using System;
using System.Collections.Generic;
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
        public string connectionString;
        public string Username { get; set; }
        public string Password { get; set; }
        public string JobType { get; set; }

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
            // Constructs the path to the database
            string solutionDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\");


            string dbpath = Path.Combine(solutionDir, "UserDatabase.db");
            string connectionString = $"Data Source={dbpath};Version=3;";
            User authenticatedUser = null;



            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Uses a UNION query to look for the data as a simultaneous search.
                string query = @"
                SELECT Username, Password, JobType, ContactInfo 
                FROM Staff_Table 
                WHERE Username = @Username AND Password = @Password
                UNION
                SELECT Username, Password, 'Customer' AS JobType, ContactInfo 
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
                        reader["JobType"].ToString());
                }
            }

            return authenticatedUser;
        }

            
    }

}
