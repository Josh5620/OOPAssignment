using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Assignment
{
    public partial class ManageAppointments : Form
    {
        private Customer _customer;

        public ManageAppointments(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void textBoxAppointmentId_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId))
            {
                // Find the appointment in the customer's appointmentsData
                DataRow[] rows = _customer.appointmentsData.Select($"AppointmentId = {appointmentId}");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    textBoxName.Text = row["CustomerName"].ToString();
                    textBoxService.Text = row["ServiceId"].ToString();
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

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId))
            {
                string newName = textBoxName.Text;
                string updateQuery = "UPDATE Appointments_Table SET CustomerName = @CustomerName WHERE AppointmentId = @AppointmentId";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, _customer.connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", newName);
                    cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating customer name: {ex.Message}");
                    }
                }
            }
        }

        private void textBoxService_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId) &&
                int.TryParse(textBoxService.Text, out int serviceId))
            {
                string updateQuery = "UPDATE Appointments_Table SET ServiceId = @ServiceId WHERE AppointmentId = @AppointmentId";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, _customer.connection))
                {
                    cmd.Parameters.AddWithValue("@ServiceId", serviceId);
                    cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating service ID: {ex.Message}");
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAppointmentId.Text, out int appointmentId))
            {
                DateTime newDate = dateTimePicker1.Value;
                string updateQuery = "UPDATE Appointments_Table SET PreferredDate = @PreferredDate WHERE AppointmentId = @AppointmentId";

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, _customer.connection))
                {
                    cmd.Parameters.AddWithValue("@PreferredDate", newDate);
                    cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating appointment date: {ex.Message}");
                    }
                }
            }
        }
    }
}
