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
    public partial class Feedback : UserControl
    {
        private Customer customer; // Reference to the Customer object
        private List<Customer.Service> services; // List of services
        public Feedback()
        {
            InitializeComponent();
            // Initialize comboBoxRating with values 1 to 5
            comboBoxRating.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            customer = new Customer(); // Instantiate the Customer object
            // Load available services into comboBoxServices
            LoadServicesIntoComboBox();
        }

        private void LoadServicesIntoComboBox()
        {
            try
            {
                services = customer.ViewAvailableServices(); // Retrieve services from the database

                if (services != null && services.Any())
                {
                    comboBoxSerFeedback.DataSource = services;
                    comboBoxSerFeedback.DisplayMember = "ServiceName";  // Display ServiceName
                    comboBoxSerFeedback.ValueMember = "ServiceId";      // Use ServiceId as the value
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (comboBoxSerFeedback.SelectedItem == null)
                {
                    MessageBox.Show("Please select a service to review.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBoxRating.SelectedItem == null)
                {
                    MessageBox.Show("Please select a rating from 1 to 5.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxReview.Text))
                {
                    MessageBox.Show("Please enter your feedback.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Extract inputs
                int serviceId = Convert.ToInt32(comboBoxSerFeedback.SelectedValue); // Get ServiceId
                int rating = Convert.ToInt32(comboBoxRating.SelectedItem);
                string feedbackText = textBoxReview.Text;

                // Submit feedback using the Customer class
                customer.ProvideFeedback(serviceId, feedbackText, rating);

                // Clear inputs
                comboBoxSerFeedback.SelectedItem = null;
                comboBoxRating.SelectedItem = null;
                textBoxReview.Clear();

                MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while submitting feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }
    }
    
}
