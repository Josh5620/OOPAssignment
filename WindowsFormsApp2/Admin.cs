﻿using System;
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
        private SQLiteConnection connection;  // Initializes the connection and the datatables. 
        private DataTable staffData;
        private DataTable serviceTData;
        private DataTable feedbackdata;
        private DataTable ReportData;

        public Admin()
        {
            // Get the database connection from the User class
            connection = GetDatabaseConnection();

            // Initialize the DataTables by loading the respective tables
            staffData = LoadDataGrid("staff");
            serviceTData = LoadDataGrid("service");
            feedbackdata = LoadDataGrid("feedback");

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

        public void InsertRecord(string tableName, Dictionary<string, object> columns)
        {
            // Constructs the column names and parameters for the SQL query
            string columnNames = string.Join(",", columns.Keys);
            string parameters = string.Join(", ", columns.Keys.Select(k => $"@{k}"));

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
                { "FN", fullName },
                { "username", username },
                { "password", password },
                { JobType, jobType }
            };
            InsertRecord("Staff_Table", staffData);
            RefreshDatabase(StaffData);
        }

        public void DeleteStaff(int StaffId)
        {
            DeleteRecord("Staff_Table", "StaffId", StaffId);
            RefreshDatabase(staffData);
        }

        public void AddService(string ServiceName, string Description, int price, string EstimatedTime)
        {
            var serviceData = new Dictionary<string, object>
            {
                { "Sn", ServiceName },
                { "description", Description },
                { "Price", price },
                { "ET", EstimatedTime }
            };
            InsertRecord("Service_Table", serviceData);
            RefreshDatabase(serviceTData);
        }

        public void DeleteService(int ServiceId)
        {
            DeleteRecord("Service_Table", "ServiceId", ServiceId);
            RefreshDatabase(serviceTData);
        }

        public void EditService(int ServiceId, int price, int EstimatedTime)
        {
            //Form the SQL query
            string Editquery = $"UPDATE Service_Table SET Price = @price AND EstimatedTime = @ET WHERE ServiceId = @ServiceId";
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(Editquery, connection))
                {
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@ET", EstimatedTime);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Service {ServiceId} ID successfully updated!");
                    }
                    else
                    {
                        MessageBox.Show($"Service with {ServiceId} ID does not exist! Please enter a valid service ID!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in updating service! {ex.Message}");
            }
            RefreshDatabase(serviceTData);
        }
    }
}



