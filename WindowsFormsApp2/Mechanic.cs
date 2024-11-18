using Assignment;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Mechanic : User
    {
        public SQLiteConnection connection;

        public Mechanic()
        {
            connection = GetDatabaseConnection();
        }
        public int GetNextOrderId()
        {
            int nextOrderId = 1;
            string query = "SELECT MAX(OrderID) FROM Order_Table";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                connection.Open();
                object result = cmd.ExecuteScalar();
                connection.Close();
                if (result != DBNull.Value)
                {
                    nextOrderId = Convert.ToInt32(result) + 1;
                }
            }

            return nextOrderId;
        }

        public void DeductInventory(int productId, int quantity)
        {
            string query = "UPDATE Inventory_Table SET Quantity = Quantity - @Quantity WHERE ProductID = @ProductID";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable LoadInventoryData()
        {
            string query = "SELECT * FROM Inventory_Table";
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }



        public void UpdateOrderTable(int orderId, int engineParts, int spareWheels, int oil, int exhaustPipe, int headlights)
        {
            string query = "INSERT INTO Order_Table (OrderID, EngineParts, SpareWheels, Oil, ExhaustPipe, Headlights) " +
                           "VALUES (@OrderID, @EngineParts, @SpareWheels, @Oil, @ExhaustPipe, @Headlights)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.Parameters.AddWithValue("@EngineParts", engineParts);
                cmd.Parameters.AddWithValue("@SpareWheels", spareWheels);
                cmd.Parameters.AddWithValue("@Oil", oil);
                cmd.Parameters.AddWithValue("@ExhaustPipe", exhaustPipe);
                cmd.Parameters.AddWithValue("@Headlights", headlights);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


        public DataTable LoadAndFilterData(string tableName, List<string> fieldsToDisplay, string filter)
        {
            DataTable fullDataTable = LoadDataGrid(tableName);
            DataView dataView = new DataView(fullDataTable);
            dataView.RowFilter = filter;

            DataTable filteredTable = dataView.ToTable();

            foreach (DataColumn column in filteredTable.Columns)
            {
                if (!fieldsToDisplay.Contains(column.ColumnName))
                {
                    column.ColumnMapping = MappingType.Hidden;
                }
            }

            return filteredTable;
        }


        public bool AppointmentIdExists(string appointmentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Appointments WHERE AppointmentId = @AppointmentId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void ClearTextBoxes(UserControl userControl)
        {
            foreach (Control control in userControl.Controls)
            {
                if (control is TextBoxBase) // TextBoxBase is the base class for both TextBox and MaskedTextBox
                {
                    ((TextBoxBase)control).Text = string.Empty;
                }
                else if (control is Panel || control is GroupBox)
                {
                    // Recursively clear textboxes in nested containers
                    ClearTextBoxes(control);
                }
            }
        }

        private void ClearTextBoxes(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBoxBase) // TextBoxBase is the base class for both TextBox and MaskedTextBox
                {
                    ((TextBoxBase)control).Text = string.Empty;
                }
                else if (control is Panel || control is GroupBox)
                {
                    ClearTextBoxes(control);
                }
            }
        }


        //public void RefreshDataGridView(UserControl userControl, string dataGridViewName, string tableName)
        //{
        //  var dataGridView = userControl.Controls[dataGridViewName] as DataGridView;
        // if (dataGridView == null)
        //{
        //  throw new ArgumentException($"No DataGridView with the name '{dataGridViewName}' found in the UserControl.");
        //}

        // Load data from the specified table
        //DataTable dataTable = LoadDataGrid(tableName);

        // Set the DataSource of the DataGridView to the loaded data
        //dataGridView.DataSource = dataTable;
        //}





        public void UpdateData(string fullName, string customerId, string serviceId, string vehicleNumber, string appointmentDate, string additionalNotes, string status)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "UPDATE Appointments SET FullName = @FullName, CustomerId = @CustomerId, VehicleNumber = @VehicleNumber, AppointmentDate = @AppointmentDate, AdditionalNotes = @AdditionalNotes, Status = @Status WHERE ServiceId = @ServiceId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@ServiceId", serviceId);
                    command.Parameters.AddWithValue("@VehicleNumber", vehicleNumber);
                    command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    command.Parameters.AddWithValue("@AdditionalNotes", additionalNotes);
                    command.Parameters.AddWithValue("@Status", status);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data updated successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating data: {ex.Message}");
                    }
                }
            }
        }

        public void UpdateMechanicFields(string appointmentId, string MechanicNotes, string CollectionTime)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "UPDATE Appointments SET MechanicNotes = @MechanicNotes, CollectionTime = @CollectionTime WHERE AppointmentId = @AppointmentId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MechanicNotes", MechanicNotes);
                    command.Parameters.AddWithValue("@CollectionTime", CollectionTime);
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data updated successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating data: {ex.Message}");
                    }
                }
            }
        }
        public DataTable LoadAndFilterData(string tableName, List<string> fields, string filterCondition, params SQLiteParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Build the SELECT query dynamically based on the fields
                string query = $"SELECT {string.Join(", ", fields)} FROM {tableName} WHERE {filterCondition}";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to the query if provided
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(param);
                    }

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        public void UpdateProfile(
    string username,
    string fullName,
    string password,
    string email,
    string phoneNumber,
    string address)
        {
            // Dictionary for updating Profile_Table fields
            var profileUpdates = new Dictionary<string, string>
    {
        { "Email", email?.Trim() },
        { "PhoneNumber", phoneNumber?.Trim() },
        { "Address", address?.Trim() }
    };

            // Dictionary for updating Staff_Table fields
            var staffUpdates = new Dictionary<string, string>
    {
        { "FullName", fullName?.Trim() },
        { "Password", password?.Trim() }
    };

            // Update Profile_Table if any fields are provided
            UpdateTable("Profile_Table", profileUpdates, username);

            // Update Staff_Table if any fields are provided
            UpdateTable("Staff_Table", staffUpdates, username);

            MessageBox.Show("Profile updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Helper method to update a specific table
        private void UpdateTable(string tableName, Dictionary<string, string> updates, string username)
        {
            // Only update fields that are not empty
            var fieldsToUpdate = updates
                .Where(field => !string.IsNullOrEmpty(field.Value))
                .Select(field => $"{field.Key} = @{field.Key}");

            if (fieldsToUpdate.Any())
            {
                string query = tableName == "Profile_Table"
                    ? $"UPDATE {tableName} SET {string.Join(", ", fieldsToUpdate)} WHERE ProfileID = (SELECT StaffId FROM Staff_Table WHERE Username = @Username)"
                    : $"UPDATE {tableName} SET {string.Join(", ", fieldsToUpdate)} WHERE Username = @Username";

                using (var command = new SQLiteCommand(query, connection))
                {
                    // Add parameters for the fields to be updated
                    foreach (var field in updates.Where(field => !string.IsNullOrEmpty(field.Value)))
                    {
                        command.Parameters.AddWithValue($"@{field.Key}", field.Value);
                    }
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

        public Dictionary<string, string> GetProfileInfo(string username)
        {
            Dictionary<string, string> profileInfo = new Dictionary<string, string>();

            string query = @"
        SELECT 
            p.ProfileID, 
            p.Email, 
            p.PhoneNumber, 
            p.Address, 
            s.FullName, 
            s.Password, 
            s.Username
        FROM 
            Profile_Table p
            JOIN Staff_Table s ON p.ProfileID = s.StaffId
        WHERE 
            s.Username = @Username";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        profileInfo["FullName"] = reader["FullName"].ToString();
                        profileInfo["Username"] = reader["Username"].ToString();
                        profileInfo["Email"] = reader["Email"].ToString();
                        profileInfo["PhoneNumber"] = reader["PhoneNumber"].ToString();
                        profileInfo["Address"] = reader["Address"].ToString();
                        profileInfo["Password"] = reader["Password"].ToString();
                    }
                }
            }

            return profileInfo;
        }



    }


}