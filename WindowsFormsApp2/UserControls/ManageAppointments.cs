using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Assignment
{
    public partial class ManageAppointments : UserControl
    {
        private Customer _customer; // Declare but don’t initialize here

        public ManageAppointments()
        {
            InitializeComponent();
            _customer = new Customer(); // Initialize the Customer instance
        }

        private void ManageAppointments_Load(object sender, EventArgs e)
        {
            // Load the appointments data when the form loads
            LoadAppointments();
        }

        private void LoadAppointments()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}");
            }
        }

        private void textBoxAppointmentId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId))
                {
                    DataRow[] rows = _customer.appointmentsData.Select($"AppointmentId = {appointmentId}");
                    if (rows.Length > 0)
                    {
                        DataRow row = rows[0];
                        textBoxName.Text = row["CustomerName"].ToString();
                        comboBoxAppointments.Text = row["ServiceId"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(row["PreferredDate"]);
                    }
                    else
                    {
                        MessageBox.Show("No appointment found with that ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid appointment ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving appointment: {ex.Message}");
            }
        }

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer name: {ex.Message}");
            }
        }

        private void textBoxService_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId) &&
                    int.TryParse(comboBoxAppointments.Text, out int serviceId))
                {
                    string updateQuery = "UPDATE Appointments_Table SET ServiceId = @ServiceId WHERE AppointmentId = @AppointmentId";

                    using (var connection = _customer.GetDatabaseConnection())
                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ServiceId", serviceId);
                        cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating service ID: {ex.Message}");
            }
        }

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating appointment date: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Currently not used, but you can implement functionality here
        }
    }
}
