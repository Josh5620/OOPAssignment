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

namespace WindowsFormsApp2
{
    public class Receptionist : User
    {

        private string dbPath;
        private SQLiteDataAdapter dataAdapter;      // Sets both connection and dataAdapter to class lvl variables and determines the main database file path
        private SQLiteConnection connection;
        private string focusID;

        public Receptionist()
        {
            string solutionDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\");
            dbPath = Path.Combine(solutionDir, "UserDatabase.db");
        }


        public void GetUserID(string userID) // also let accept another argument to know to cehck which database
        {
            if (userID == null || userID == "")
            {
                MessageBox.Show("ID not found");
                return;
            }
            FocusID = userID;
            
        }

        public string FocusID
        {
            get { return focusID; }
            private set { focusID = value; }
        }


        public DataTable LoadDatagrid()     // Will both connect and set  the dataAdapter both has not close connection##
        {
            string connectionString = $"Data Source={dbPath};Version=3;";

            connection = new SQLiteConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Customer_Table";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            dataAdapter = new SQLiteDataAdapter(command);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;   

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

    }
}
