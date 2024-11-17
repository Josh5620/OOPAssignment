using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.UserControls
{
    public partial class CMADD_Control : UserControl
    {
        public CMADD_Control()
        {
            InitializeComponent();
            dataGridView1.DataSource = Recep.LoadDataGrid("customer");
            reader = Recep.LoadServiceChoice();
            while (reader.Read())
            {
                string serviceID = reader["ServiceID"].ToString();
                string serviceName = reader["ServiceName"].ToString();

                ServiceComboBox.Items.Add($"ServiceID: {serviceID} , ServiceName: {serviceName}");
            }

        }

        Receptionist Recep = new Receptionist();
        SQLiteDataReader reader;

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Reset the data source
            dataGridView1.DataSource = Recep.LoadDataGrid("customer"); // Rebind new data
            dataGridView1.Refresh(); // Force refresh


        }

        private void AddBtn_Click(object sender, EventArgs e)       // Add error handling if stuff is blank or types dont matchup
        {                   
            string fullName = FullNameTextBox.Text;
            string password = PasswordTextbox.Text;
            string username = UsernameTextBox.Text;
            string vehicleNumber = VehicleNumberTextBox.Text;

            string[] selectedService = ServiceComboBox.SelectedItem.ToString().Split(' ');



                Recep.AddCustomerRecord(fullName, password, username, vehicleNumber, selectedService[1]);

        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = "";
            PasswordTextbox.Text = "";
            UsernameTextBox.Text = "";
            VehicleNumberTextBox.Text = "";
            ServiceComboBox.Text = "";
        }




    }
}
