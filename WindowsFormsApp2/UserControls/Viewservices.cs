using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Viewservices : UserControl
    {
        private List<Customer.Service> services;
        private Customer customer;

        public Viewservices()
        {
            InitializeComponent();
            services = new List<Customer.Service>(); // Initialize the list
            customer = new Customer(); // Instantiate the Customer object
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            // Register event handlers
            dataGridViewServices.CellClick += DataGridViewServices_CellClick;
        }

        // Load data into the DataGridView on form load
        private void Viewservices_Load(object sender, EventArgs e)
        {
            // Load and bind data to DataGridView
            List<string> fieldsToDisplay = new List<string> { "ServiceId", "ServiceName", "Description", "Price", "EstimatedTime" };
            var serviceData = customer.LoadAndFilterData("Service_Table", fieldsToDisplay, null);

            if (serviceData != null)
            {
                dataGridViewServices.DataSource = serviceData;

                // Optional: Customize column headers
                dataGridViewServices.Columns["ServiceId"].HeaderText = "Service ID";
                dataGridViewServices.Columns["ServiceName"].HeaderText = "Service Name";
                dataGridViewServices.Columns["Description"].HeaderText = "Description";
                dataGridViewServices.Columns["Price"].HeaderText = "Price";
                dataGridViewServices.Columns["EstimatedTime"].HeaderText = "Estimated Time";
            }
            else
            {
                MessageBox.Show("Failed to load service data.");
            }
        }

        // Handle cell click in the DataGridView
        private void DataGridViewServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                DataGridViewRow row = dataGridViewServices.Rows[e.RowIndex];

                // Populate TextBox controls with corresponding cell values
              
                textBoxService.Text = row.Cells["ServiceId"].Value?.ToString();
            }
        }

        // Handle scheduling an appointment
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            string customerName = textBoxName.Text; // Assuming a TextBox for customer name
            if (!string.IsNullOrWhiteSpace(customerName))
            {
                if (dataGridViewServices.SelectedRows.Count > 0)
                {
                    int selectedServiceId = Convert.ToInt32(dataGridViewServices.SelectedRows[0].Cells["ServiceId"].Value);
                    DateTime preferredDate = dateTimePickerAppointment.Value; // Assuming a DateTimePicker for selecting date

                    customer.ScheduleAppointment(selectedServiceId, preferredDate);
                    MessageBox.Show("Appointment scheduled successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a service from the table.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid name.");
            }
        }
    }
}
