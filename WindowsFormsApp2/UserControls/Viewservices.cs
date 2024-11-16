﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2;

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
            if (comboBoxServices.SelectedItem != null)
            {
                int selectedServiceId = (int)comboBoxServices.SelectedValue;
                DisplayServiceDetails(selectedServiceId);
            }
            else
            {
                MessageBox.Show("Please select a service to view.");
            }
        }

        // Display selected service details in the DataGridView
        private void DisplayServiceDetails(int serviceId)
        {
            // Clear the DataGridView before adding new details
            dataGridViewServices.DataSource = null;

            // Retrieve the selected service from the list
            var selectedService = services.FirstOrDefault(s => s.ServiceId == serviceId);

            if (selectedService != null)
            {
                DataTable serviceTable = new DataTable();
                serviceTable.Columns.Add("Service ID");
                serviceTable.Columns.Add("Service Name");
                serviceTable.Columns.Add("Description");
                serviceTable.Columns.Add("Price");
                serviceTable.Columns.Add("Estimated Time");

                // Add the selected service’s details to the DataTable
                serviceTable.Rows.Add(
                    selectedService.ServiceId,
                    selectedService.ServiceName,
                    selectedService.Description,
                    selectedService.Price,
                    selectedService.EstimatedTime
                );

                // Bind the DataTable to the DataGridView
                dataGridViewServices.DataSource = serviceTable;
            }
            else
            {
                MessageBox.Show("Error: Selected service not found.");
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

    }
}