using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.UserControls
{
    public partial class CMADD_Control : UserControl
    {
        public CMADD_Control()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            // Define the connection string for your SQLite database
            string connectionString = @"Data Source=your_database.db;Version=3;";

            // Create the SQLite connection
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Define the query to fetch data (e.g., from the "Customers" table)
                string query = "SELECT * FROM Customers";

                // Create the command and data adapter
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);

                // Create a DataTable to hold the query results
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the results of the query
                dataAdapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                // Close the connection
                connection.Close();
            }
        }



    }
}
