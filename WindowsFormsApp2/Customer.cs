
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Customer : User
    {
        public SQLiteConnection connection;
        public DataTable servicesData;
        public DataTable appointmentsData;
        public DataTable feedbackData;


        public class Service
        {
            public int ServiceId { get; set; }
            public string ServiceName { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
            public string EstimatedTime { get; set; }
        }

        public Customer(string username) // Accept a username and initialize the connection
        {
            this.Username = username;
            connection = GetDatabaseConnection();  // Initialize the SQLite connection
            servicesData = LoadDataGrid("service");  // Load available services
            appointmentsData = LoadDataGrid("appointment");  // Load customer appointments
            feedbackData = LoadDataGrid("feedback");  // Load feedback table
        }

        // New constructor that accepts a username
   public Customer() : this(string.Empty) // Default constructor calls the constructor with the username parameter
        {
        }


        // Method to view services
        public List<Service> ViewAvailableServices()
        {
            List<Service> services = new List<Service>();
            string query = "SELECT * FROM Service_Table";
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        services.Add(new Service
                        {
                            ServiceId = reader.GetInt32(0),
                            ServiceName = reader.GetString(1),
                            Description = reader.GetString(2),
                            Price = reader.GetInt32(3),
                            EstimatedTime = reader.GetString(4)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching services: {ex.Message}");
            }
            return services;
        }

        // Schedule an appointment with date only
        public void ScheduleAppointment(int serviceId, DateTime preferredDate)
        {
            var appointmentData = new Dictionary<string, object>
        {
            { "CustomerId", this.Username },
            { "ServiceId", serviceId },
            { "AppointmentDate", preferredDate }
        };
            InsertRecord("Appointments", appointmentData);
            MessageBox.Show("Appointment scheduled successfully.");
        }

        // Reschedule an appointment with new date only
        public void RescheduleAppointment(int appointmentId, DateTime newDate)
        {
            string updateQuery = "UPDATE Appointments_Table SET PreferredDate = @newDate WHERE AppointmentId = @appointmentId";
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@newDate", newDate);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Appointment ID {appointmentId} successfully rescheduled.");
                    }
                    else
                    {
                        MessageBox.Show("No appointment found with that ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error rescheduling appointment: {ex.Message}");
            }
        }

        // Cancel an appointment
        public void CancelAppointment(int appointmentId)
        {
            DeleteRecord("Appointments_Table", "AppointmentId", appointmentId);
        }

        // Provide feedback for a service
        public void ProvideFeedback(int serviceId, string feedbackText, int rating)
        {
            var feedbackData = new Dictionary<string, object>
        {
            { "ServiceId", serviceId },
            { "CustomerId", this.Username },
            { "FeedbackText", feedbackText },
            { "Rating", rating }
        };
            InsertRecord("Feedback_Table", feedbackData);
            MessageBox.Show("Feedback submitted successfully.");
        }

        // Update customer profile

        public void UpdateProfile(string newName, string newEmail, string newPhoneNumber, string newAddress)
        {
            string updateQuery = "UPDATE Profile_Table SET FullName = @name, Email = @Email, PhoneNumber = @phone, Address = @address WHERE Username = @Username";
            try
            {
                Customer currentCustomer = new Customer("yourUsername"); // Replace "yourUsername" with the actual username
                currentCustomer.UpdateProfile(newName, newEmail, newPhoneNumber, newAddress);

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@phone", newPhoneNumber);
                    cmd.Parameters.AddWithValue("@address", newAddress);
                    cmd.Parameters.AddWithValue("@Username", this.Username);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error updating profile.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}");
            }
        }


        // Reusable method for inserting records into any table
        private void InsertRecord(string tableName, Dictionary<string, object> columns)
        {
            string columnNames = string.Join(",", columns.Keys);
            string parameters = string.Join(", ", columns.Keys.Select(key => $"@{key}"));
            string insertQuery = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameters})";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    foreach (var column in columns)
                    {
                        cmd.Parameters.AddWithValue($"@{column.Key}", column.Value);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record to {tableName}: {ex.Message}");
            }
        }

        // Reusable method for deleting records from any table
        private void DeleteRecord(string tableName, string columnName, object value)
        {
            string deleteQuery = $"DELETE FROM {tableName} WHERE {columnName} = @{columnName}";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue($"@{columnName}", value);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{rowsAffected} record(s) deleted from {tableName}.");
                    }
                    else
                    {
                        MessageBox.Show($"No records found with the provided {columnName} value.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }

}
