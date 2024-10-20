using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dataGridView1.DataSource = Recep.LoadCustDataGrid();
        }
        Receptionist Recep = new Receptionist();

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Receptionist Recep = new Receptionist();
            dataGridView1.DataSource = Recep.LoadCustDataGrid();
        }

        private void AddBtn_Click(object sender, EventArgs e)       // Add error handling if stuff is blank or types dont matchup
        {                   
            string fullName = FullNameTextBox.Text;
            string contactInfo = ContactInfoTextBox.Text;
            string username = UsernameTextBox.Text;
            string vehicleNumber = VehicleNumberTextBox.Text;
            string address = AddressTextBox.Text;
            string selectedService = ServiceComboBox.SelectedItem?.ToString();
            try
            {
                Recep.AddCustomerRecord(fullName, contactInfo, username, vehicleNumber, address, selectedService);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = "";
            ContactInfoTextBox.Text = "";
            UsernameTextBox.Text = "";
            VehicleNumberTextBox.Text = "";
            AddressTextBox.Text = "";
            ServiceComboBox.Text = "";
        }
    }
}
