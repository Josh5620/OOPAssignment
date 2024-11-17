using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;


namespace Assignment
{
    public partial class ManageAppointments : UserControl
    {
        private Customer _customer; // Declare Customer instance

        public ManageAppointments()
        {
            InitializeComponent();
            _customer = new Customer(); // Initialize the Customer instance
        }

        private void ManageAppointments_Load(object sender, EventArgs e)
        {
            LoadAllAppointments(); // Load appointments into DataGridView
            LoadServices();     // Load services into ComboBox
        }

     
        private void LoadAllAppointments()
        {
            try
            {
                _customer.appointmentsData = new DataTable();
                string query = "SELECT * FROM Appointments_Table";

                using (var connection = _customer.GetDatabaseConnection())
                using (var adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.Fill(_customer.appointmentsData);
                }

                // Bind data to DataGridView
                dataGridViewAppointments.DataSource = _customer.appointmentsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}");
            }
        }

        private void LoadAppointmentsFromDatabase()
        {
            try
            {
                _customer.appointmentsData = _customer.LoadDataGrid("appointment");
                if (_customer.appointmentsData != null)
                {
                    dataGridViewAppointments.DataSource = _customer.appointmentsData;
                }
                else
                {
                    MessageBox.Show("No data found in Appointments_Table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}");
            }
        }


        private void LoadServices()
        {
            try
            {
                var services = _customer.ViewAvailableServices();
                if (services != null && services.Any())
                {
                    comboBoxAppointments.DataSource = services;
                    comboBoxAppointments.DisplayMember = "ServiceName";
                    comboBoxAppointments.ValueMember = "ServiceId";
                }
                else
                {
                    MessageBox.Show("No services found in Service_Table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading services: {ex.Message}");
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
                    DataRow[] rows = _customer.appointmentsData.Select($"AppointmentId = {appointmentId}");
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
                    string updateQuery = "UPDATE Appointments_Table SET CustomerName = @CustomerName WHERE AppointmentId = @AppointmentId";

                    using (var connection = _customer.GetDatabaseConnection())
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
            try
            {
                if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId) &&
                    comboBoxAppointments.SelectedValue is int serviceId)
                {
                    string updateQuery = "UPDATE Appointments_Table SET ServiceId = @ServiceId WHERE AppointmentId = @AppointmentId";

                    using (var connection = _customer.GetDatabaseConnection())
                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ServiceId", serviceId);
                        cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Service updated successfully.");
                    LoadAllAppointments(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating service: {ex.Message}");
            }
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
                    string updateQuery = "UPDATE Appointments_Table SET PreferredDate = @PreferredDate WHERE AppointmentId = @AppointmentId";

                    using (var connection = _customer.GetDatabaseConnection())
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
    }
}
