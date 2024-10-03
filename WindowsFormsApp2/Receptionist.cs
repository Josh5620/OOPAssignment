using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Receptionist : User
    {
        public void GetUserID(string userID) // also let accept another argument to know to cehck which database
        {
            if (userID == null || userID == "")
            {
                MessageBox.Show("ID not found");
                return;
            }
            FocusID = userID;
            
        }

        private string focusID;
        public string FocusID
        {
            get { return focusID; }
            private set { focusID = value; }
        }

        private SQLiteDataAdapter dataAdapter;      // Sets both connection and dataAdapter to class lvl variables
        private SQLiteConnection connection;

        public DataTable LoadDatagrid()     // Will both connect and set  the dataAdapter both has not close connection##
        {
            string connectionString = @"Data Source=|DataDirectory|\UserDatabase.db;Version=3;";

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
    }
}
