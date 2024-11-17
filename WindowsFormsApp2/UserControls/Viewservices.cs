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
            customer = new Customer(); // Instantiate the Customer object
            LoadServicesIntoComboBox();
        }

        // Load available services into the ComboBox
        private void LoadServicesIntoComboBox()
        {
            try
            {
                services = customer.ViewAvailableServices(); // Retrieve services from the database

                if (services != null && services.Any())
                {
                    comboBoxServices.DataSource = services;
                    comboBoxServices.DisplayMember = "ServiceName";  // Display ServiceName
                    comboBoxServices.ValueMember = "ServiceId";      // Use ServiceId as the value
                }
                else
                {
                    MessageBox.Show("No services available to display.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading services: {ex.Message}");
            }
        }

        // Event handler for the "View" button click
        private void btnViewServices_Click(object sender, EventArgs e)
        {
            if (comboBoxServices.SelectedValue is int selectedServiceId)
            {
                // Debugging message
                MessageBox.Show($"Selected Service ID: {selectedServiceId}");
                DisplayServiceDetails(selectedServiceId);
            }
            else
            {
                MessageBox.Show("Please select a valid service.");
            }
        }

        // Display selected service details in the DataGridView
        private void DisplayServiceDetails(int serviceId)
        {
            try
            {
                // Find the selected service
                var selectedService = services.FirstOrDefault(s => s.ServiceId == serviceId);

                if (selectedService == null)
                {
                    MessageBox.Show("Selected service could not be found.");
                    return;
                }

                // Create DataTable
                DataTable serviceTable = new DataTable();
                serviceTable.Columns.Add("Service ID");
                serviceTable.Columns.Add("Service Name");
                serviceTable.Columns.Add("Description");
                serviceTable.Columns.Add("Price");
                serviceTable.Columns.Add("Estimated Time");

                // Add service details to DataTable
                serviceTable.Rows.Add(
                    selectedService.ServiceId,
                    selectedService.ServiceName,
                    selectedService.Description,
                    selectedService.Price,
                    selectedService.EstimatedTime
                );

                // Bind DataTable to DataGridView
                dataGridViewServices.DataSource = serviceTable;

                // Debugging message
                MessageBox.Show($"DataGridView now displays {serviceTable.Rows.Count} rows.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying service details: {ex.Message}");
            }
        }


        // Remove unused event handlers for cleaner code
        private void comboBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Add logic to handle ComboBox selection changes, if needed
        }

        private void btnViewServices_Click_1(object sender, EventArgs e)
        {
            // Redundant handler; can be removed if not used
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            // Handle the cell click event here, if needed
            MessageBox.Show($"Cell clicked at Row {e.RowIndex}, Column {e.ColumnIndex}");
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            string customerName = textBoxName.Text; // Assuming a TextBox for customer name
            if (comboBoxServices.SelectedValue is int selectedServiceId && !string.IsNullOrWhiteSpace(customerName))
            {
                DateTime preferredDate = dateTimePickerAppointment.Value; // Assuming DateTimePicker for selecting date
                customer.ScheduleAppointment(selectedServiceId, preferredDate);
            }
            else
            {
                MessageBox.Show("Please enter a valid name and select a service.");
            }

        }
    }
}
