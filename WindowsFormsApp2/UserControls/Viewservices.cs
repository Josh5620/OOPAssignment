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
    
        public partial class Viewservices : UserControl
        {
            private Customer customer;
            private List<Customer.Service> services;

            public Viewservices()
            {
                InitializeComponent();
                customer = new Customer();
                LoadServicesIntoComboBox();
            }

            // Load available services into the ComboBox
            private void LoadServicesIntoComboBox()
            {
                services = customer.ViewAvailableServices();  // Get list of services
                comboBoxServices.DataSource = services;              // Bind to ComboBox
                comboBoxServices.DisplayMember = "ServiceName";      // Display service name
                comboBoxServices.ValueMember = "ServiceId";          // Use service ID as value
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
                // Filter the selected service
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

            // Optional: Handle DataGridView cell click if needed
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                // Code for handling DataGridView cell click, if needed
            }
        }
    }

}
