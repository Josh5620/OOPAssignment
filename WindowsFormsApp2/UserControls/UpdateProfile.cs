using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class UpdateProfile : UserControl
    {
        private Customer customer; // Customer object to handle database operations

        public UpdateProfile()
        {
            InitializeComponent();
            customer = new Customer(); // Initialize the Customer instance
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            dataGridView1.CellClick += DataGridViewProfile_CellClick; // Handle DataGridView cell clicks
            btnUpdateProfile.Click += BtnUpdate_Click; // Handle update button clicks
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            // Load profile data into the DataGridView on load
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            // Define the fields to display
            List<string> fieldsToDisplay = new List<string> { "FullName", "Email", "PhoneNumber", "Address", "Username" };

            // Fetch profile data using the Customer object
            var profileData = customer.LoadAndFilterData("Profile_Table", fieldsToDisplay, null);

            if (profileData != null)
            {
                dataGridView1.DataSource = profileData;

                // Customize column headers
                dataGridView1.Columns["FullName"].HeaderText = "Full Name";
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["PhoneNumber"].HeaderText = "Phone Number";
                dataGridView1.Columns["Address"].HeaderText = "Address";
                dataGridView1.Columns["Username"].HeaderText = "Username"; // Display Username for reference
                dataGridView1.Columns["Username"].Visible = false; // Hide the Username column (optional)
            }
            else
            {
                MessageBox.Show("Failed to load profile data.");
            }
        }

        private void DataGridViewProfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate TextBox controls with selected row data
                textBoxFullName.Text = row.Cells["FullName"].Value?.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value?.ToString();
                textBoxPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
                textBoxAddress.Text = row.Cells["Address"].Value?.ToString();
                textBoxUserName.Text = row.Cells["Username"].Value?.ToString(); // Display username (read-only label)
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Please fill in all fields before updating.");
                return;
            }

            // Gather the updated profile data
            string newName = textBoxFullName.Text;
            string newEmail = textBoxEmail.Text;
            string newPhoneNumber = textBoxPhoneNumber.Text;
            string newAddress = textBoxAddress.Text;

            try
            {
                // Call the UpdateProfile method with the new data
                customer.UpdateProfile(newName, newEmail, newPhoneNumber, newAddress);

                // Reload the profile data to reflect changes
                LoadProfileData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}");
            }
        }
    }
}
