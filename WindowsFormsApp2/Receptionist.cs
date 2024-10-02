using System;
using System.Collections.Generic;
using System.Data;
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
    
        public DataTable LoadDatagrid()
        {
            string connectionString = @"Data Source=|DataDirectory|\UserDatabase.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Customer_Table";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                connection.Close();

                return dataTable;   


            }
        }





    }
}
