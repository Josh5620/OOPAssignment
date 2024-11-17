using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using static Assignment.Customer;


namespace Assignment
{
    public partial class ManageAppointments : UserControl
    {
        private List<Customer.Service> services;
        private Customer customer; // Declare Customer instance
       
        public ManageAppointments()
        {
            InitializeComponent();
            customer = new Customer(); // Initialize the Customer instance
        }

        private void ManageAppointments_Load(object sender, EventArgs e)
        {
            LoadAllAppointments(); // Load appointments into DataGridView
            LoadServicesIntoComboBox();     // Load services into ComboBox
        }

     
        private void LoadAllAppointments()
        {
            string customerName = textBoxName.Text;  // Assuming TextBox for customer name
            string selectedService = comboBoxAppointments.SelectedValue?.ToString(); // Assuming ComboBox for services

            customer.appointmentsData = new DataTable();

            try
            {
                string query = $"SELECT * FROM Appointments WHERE CustomerName = @CustomerName";

                if (!string.IsNullOrEmpty(selectedService))
                {
                    query += " AND ServiceName = @ServiceName";
                }

                using (var connection = customer.GetDatabaseConnection())
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", customerName);
                    if (!string.IsNullOrEmpty(selectedService))
                    {
                        cmd.Parameters.AddWithValue("@ServiceName", selectedService);
                    }

                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(customer.appointmentsData);
                    }
                }

                dataGridViewAppointments.DataSource = customer.appointmentsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}");
            }
        }

        private void LoadServicesIntoComboBox()
        {
            try
            {
                services = customer.ViewAvailableServices(); // Fetch services
                if (services != null && services.Count > 0)
                {
                    comboBoxAppointments.DataSource = services;
                    comboBoxAppointments.DisplayMember = "ServiceName"; // Display the service name
                    comboBoxAppointments.ValueMember = "ServiceId"; // Use ServiceId as the value
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



        /// <summary>
        /// Handle when the Appointment ID is entered or changed.
        /// Updates the corresponding fields in the form.
        /// </summary>
        private void textBoxAppointmentId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId))
                {
                    // Find the specific appointment row
                    DataRow[] rows = customer.appointmentsData.Select($"AppointmentId = {appointmentId}");
                    if (rows.Length > 0)
                    {
                        DataRow row = rows[0];
                        textBoxName.Text = row["CustomerName"].ToString();
                        comboBoxAppointments.SelectedValue = row["ServiceId"]; // Match ServiceId in ComboBox
                        dateTimePicker1.Value = Convert.ToDateTime(row["PreferredDate"]);
                    }
                    else
                    {
                        ClearFields();
                        MessageBox.Show("No appointment found with that ID.");
                    }
                }
                else
                {
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving appointment: {ex.Message}");
            }
        }

        /// <summary>
        /// Handle changes to the customer name.
        /// Updates the database when the name is changed.
        /// </summary>
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId))
                {
                    string newName = textBoxName.Text;
                    string updateQuery = "UPDATE Appointments SET CustomerName = @CustomerName WHERE AppointmentId = @AppointmentId";

                    using (var connection = customer.GetDatabaseConnection())
                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", newName);
                        cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Customer name updated successfully.");
                    LoadAllAppointments(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer name: {ex.Message}");
            }
        }

        /// <summary>
        /// Handle changes to the selected service.
        /// Updates the database when the service is changed.
        /// </summary>
        private void comboBoxAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        /// <summary>
        /// Handle changes to the preferred date.
        /// Updates the database when the date is changed.
        /// </summary>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId))
                {
                    DateTime newDate = dateTimePicker1.Value;
                    string updateQuery = "UPDATE Appointments SET PreferredDate = @PreferredDate WHERE AppointmentId = @AppointmentId";

                    using (var connection = customer.GetDatabaseConnection())
                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@PreferredDate", newDate);
                        cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Appointment date updated successfully.");
                    LoadAllAppointments(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating appointment date: {ex.Message}");
            }
        }

        /// <summary>
        /// Clear all input fields on the form.
        /// </summary>
        private void ClearFields()
        {
            textBoxName.Clear();
            comboBoxAppointments.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to cancel.");
                return;
            }

            var selectedAppointment = dataGridViewAppointments.SelectedRows[0];
            int appointmentId = Convert.ToInt32(selectedAppointment.Cells["AppointmentId"].Value); // Assuming column name is AppointmentId

            // Confirm cancellation
            var confirmResult = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancel", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                customer.CancelAppointment(appointmentId);
                LoadAllAppointments(); // Refresh DataGridView
            }
        }

        private void ManageAppointments_Load_1(object sender, EventArgs e)
        {
            List<string> fieldsToDisplay2 = new List<string> { "AppointmentId", "FullName", "CustomerId", "AppointmentDate", "ServiceId", "VehichleNumber", "AdditionalNotes", "Status" };
            dataGridViewAppointments.DataSource = customer.LoadAndFilterData("appointment", fieldsToDisplay2, "Status <> 'Completed'");
        }
    }
}
