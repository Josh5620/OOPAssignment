﻿using Assignment;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Assignment
{
    public class Customer : User
    {
        // Nested class to represent services
        public class Service
        {
            public int ServiceId { get; set; }
            public string ServiceName { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
            public string EstimatedTime { get; set; }
        }
        public DataTable appointmentsData { get; set; }
        public SQLiteConnection GetConnection()
        {
            return GetDatabaseConnection();
        }

        protected override SQLiteConnection GetDatabaseConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }
        // Constructor
        public Customer() : base() { }

        public Customer(string username) : base()
        {
            this.Username = username; // Assuming Username is a property in User class
            appointmentsData = LoadDataGrid("appointment");
        }


        // Fetch list of available services
        public override DataTable LoadDataGrid(string tableName)
        {
            var validTables = new Dictionary<string, string>()
    {
        { "staff", "Staff_Table" },
        { "customer", "Customer_Table" },
        { "service", "Service_Table" },
        { "feedback", "Feedback" },
        { "appointment", "Appointments" }, // Fixed mapping
        { "profile", "Profile_Table" },
        { "order", "Order_Table" }
    };

            if (!validTables.ContainsKey(tableName.ToLower()))
            {
                throw new ArgumentException($"Invalid table name: {tableName}");
            }

            string query = $"SELECT * FROM {validTables[tableName.ToLower()]}";
            DataTable dataTable = new DataTable();

            try
            {
                using (var connection = GetDatabaseConnection())
                {
                    using (var command = new SQLiteCommand(query, connection))
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from {tableName}: {ex.Message}");
            }

            return dataTable;
        }

        public List<Service> ViewAvailableServices()
        {
            try
            {
                List<Service> services = new List<Service>();
                using (var connection = GetConnection())
                {
                    string query = "SELECT ServiceId, ServiceName, Description, Price, EstimatedTime FROM Service_Table";
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
                return services;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving services: {ex.Message}");
                return null;
            }
        }



        // Schedule an appointment
        public void ScheduleAppointment(int serviceId, DateTime preferredDate)
        {
            var appointmentData = new Dictionary<string, object>
            {
                { "CustomerId", this.Username },
                { "ServiceId", serviceId },
                { "AppointmentDate", preferredDate }
            };

            try
            {
                InsertRecord("Appointments", appointmentData);
                MessageBox.Show("Appointment scheduled successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error scheduling appointment: {ex.Message}");
            }
        }

        // Reschedule an appointment
        public void RescheduleAppointment(int appointmentId, DateTime newDate)
        {
            const string updateQuery = "UPDATE Appointments SET AppointmentDate = @newDate WHERE AppointmentId = @appointmentId";

            try
            {
                using (var connection = GetDatabaseConnection())
                using (var cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@newDate", newDate);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected > 0
                        ? $"Appointment ID {appointmentId} successfully rescheduled."
                        : "No appointment found with that ID.");
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
            try
            {
                DeleteRecord("Appointments", "AppointmentId", appointmentId);
                MessageBox.Show("Appointment cancelled successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cancelling appointment: {ex.Message}");
            }
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

            try
            {
                InsertRecord("Feedback", feedbackData); // Ensure table name matches the database
                MessageBox.Show("Feedback submitted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting feedback: {ex.Message}");
            }
        }


        // Update customer profile
        public void UpdateProfile(string newName, string newEmail, string newPhoneNumber, string newAddress)
        {
            const string updateQuery = @"
        UPDATE Profile_Table 
        SET FullName = @name, Email = @Email, PhoneNumber = @phone, Address = @address 
        WHERE Username = @Username";

            try
            {
                using (var connection = GetDatabaseConnection())
                using (var cmd = new SQLiteCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@phone", newPhoneNumber);
                    cmd.Parameters.AddWithValue("@address", newAddress);
                    cmd.Parameters.AddWithValue("@Username", this.Username);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Show success message only if at least one row was updated
                        MessageBox.Show("Profile updated successfully.");
                    }
                    else
                    {
                        // No rows were affected; show an error message
                        MessageBox.Show("Error: Profile update failed. No changes were made.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully and display a meaningful error message
                MessageBox.Show($"Error updating profile: {ex.Message}");
            }
        }


        // Insert a record into the database
        private void InsertRecord(string tableName, Dictionary<string, object> columns)
        {
            string columnNames = string.Join(", ", columns.Keys);
            string parameters = string.Join(", ", columns.Keys.Select(key => $"@{key}"));
            string insertQuery = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameters})";

            try
            {
                using (var connection = GetDatabaseConnection())
                using (var cmd = new SQLiteCommand(insertQuery, connection))
                {
                    foreach (var column in columns)
                    {
                        cmd.Parameters.AddWithValue($"@{column.Key}", column.Value);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No rows were inserted. Check the database structure and constraints.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding record to {tableName}: {ex.Message}\nQuery: {insertQuery}");
            }
        }


        // Delete a record from the database
        private void DeleteRecord(string tableName, string columnName, object value)
        {
            string deleteQuery = $"DELETE FROM {tableName} WHERE {columnName} = @{columnName}";

            try
            {
                using (var connection = GetDatabaseConnection())
                using (var cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue($"@{columnName}", value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting record: {ex.Message}");
            }
        }
    }
}
