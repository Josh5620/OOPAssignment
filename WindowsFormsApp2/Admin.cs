using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment
{
    public class Admin : User
    {
        public SQLiteConnection connection;  // Initializes the connection and the datatables. 
        public DataTable staffData;
        public DataTable serviceTData;
        public DataTable feedbackdata;
        public DataTable ReportData;

        public Admin()
        {
            // Get the database connection from the User class
            connection = GetDatabaseConnection();

            // Initialize the DataTables by loading the respective tables
            staffData = LoadDataGrid("staff");
            serviceTData = LoadDataGrid("service");
            feedbackdata = LoadDataGrid("feedback");
            ReportData = LoadDataGrid("appointment");

        }

        public DataTable StaffData
        {
            get => staffData;
            set => staffData = value;
        }

        public DataTable ServiceData
        {
            get => serviceTData;
            set => serviceTData = value;
        }

        public DataTable FeedData
        {
            get => feedbackdata;
            set => feedbackdata = value;
        }

        public void InsertRecord(string tableName, Dictionary<string, object> columns) // Use as one of three methods to for explanation. 
        {
            // Constructs the column names and parameters for the SQL query
            string columnNames = string.Join(",", columns.Keys);
            string parameters = string.Join(", ", columns.Keys.Select(key => $"@{key}"));

            // Form the SQL query
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

        public void DeleteRecord(string tableName, string columnName, object value)
        {
            // Form the SQL query
            string deleteQuery = $"DELETE FROM {tableName} WHERE {columnName} = @{columnName}";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                {// Add the parameters for the condition
                    cmd.Parameters.AddWithValue($"@{columnName}", value);

                    // Execute the delete command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if any rows were affected
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
                // Handle any exceptions that might occur
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void AddStaff(string fullName, string username, string password, string jobType)
        {
            var staffData = new Dictionary<string, object>
            {
                { "FullName", fullName },
                { "Username", username },
                { "Password", password },
                { "JobType", jobType }
            };
            InsertRecord("Staff_Table", staffData);
            MessageBox.Show("Record Successfully Added.");
        }

        public void DeleteStaff(int StaffId)
        {
            DeleteRecord("Staff_Table", "StaffId", StaffId);
        }

        public void AddService(string ServiceName, string Description, int price, string EstimatedTime)
        {
            var serviceData = new Dictionary<string, object>
            {
                { "ServiceName", ServiceName },
                { "Description", Description },
                { "Price", price },
                { "EstimatedTime", EstimatedTime }
            };
            InsertRecord("Service_Table", serviceData);
        }

        public void DeleteService(int ServiceId)
        {
            DeleteRecord("Service_Table", "ServiceId", ServiceId);
        }

        public void EditService(int serviceId, int price, string estimatedTime)
        {
            // Correct SQL query
            string editQuery = "UPDATE Service_Table SET Price = @price, EstimatedTime = @ET WHERE ServiceId = @ServiceId";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(editQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@ET", estimatedTime);
                    cmd.Parameters.AddWithValue("@ServiceId", serviceId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Service with ID {serviceId} successfully updated!");
                    }
                    else
                    {
                        MessageBox.Show($"Service with ID {serviceId} does not exist! Please enter a valid service ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in updating service: {ex.Message}");
            }
        }

        public void GetReportsByMonth(string month)
        {
            // Updated query to select only the required columns
            string filterquery = @"
        SELECT AppointmentId, ServiceId, MechanicId, strftime('%m', AppointmentDate) AS Month, BillAmount
        FROM Appointments
        WHERE strftime('%m', AppointmentDate) = @Month";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(filterquery, connection))
                {
                    // Add the month parameter to the query
                    cmd.Parameters.AddWithValue("@Month", month);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Create a DataTable to hold filtered reports
                            DataTable filteredReports = new DataTable();
                            filteredReports.Load(reader);  // Load data from reader into DataTable

                            // Assign the filtered reports to the ReportData property
                            ReportData = filteredReports;

                            // Optionally, bind the DataTable to a DataGridView for displaying the reports
                            MessageBox.Show($"Reports successfully filtered by {month}!");
                        }
                        else
                        {
                            MessageBox.Show($"No reports found for {month}.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in filtering reports: {ex.Message}");
            }
        }
        public void GetFeedbackByMonth(string month)
        {
            // Form the SQL query to filter feedback by the FeedbackDate month
            string filterquery = @"
        SELECT FeedbackId, CustomerId, ServiceId, FeedbackText, Rating, FeedbackDate
        FROM Feedback
        WHERE strftime('%m', FeedbackDate) = @Month";  // Use strftime to get the month part of FeedbackDate

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(filterquery, connection))
                {
                    cmd.Parameters.AddWithValue("@Month", month);  // Add the selected month as a parameter

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable filteredFeedback = new DataTable();
                            filteredFeedback.Load(reader);  // Load data from reader into DataTable

                            feedbackdata = filteredFeedback;  // Store the filtered feedback in the FeedbackData table
                            MessageBox.Show($"Feedback successfully filtered by {month}!");
                        }
                        else
                        {
                            MessageBox.Show($"No feedback found for {month}.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in filtering feedback: {ex.Message}");
            }
        }

    }
}



