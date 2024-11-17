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
       
        private List<Customer.Service> services; // List of services
        private Customer customer;
        public Feedback()
        {
            InitializeComponent();
            customer = new Customer(); ;

            // Initialize comboBoxRating with values 1 to 5
            comboBoxRating.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });

            // Load available services into comboBoxServices
            LoadServices();
        }


        private void LoadServices()
        {
            try
            {
                services = customer.ViewAvailableServices(); // Fetch services
                if (services != null && services.Count > 0)
                {
                    comboBoxSerFeedback.DataSource = services;
                    comboBoxSerFeedback.DisplayMember = "ServiceName"; // Display the service name
                    comboBoxSerFeedback.ValueMember = "ServiceId"; // Use ServiceId as the value
                }
                else
                {
                    MessageBox.Show("No services available for feedback.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading services: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }

}
 
