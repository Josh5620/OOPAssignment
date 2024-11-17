using Assignment;
using System;
using System.Collections.Generic;
using System.Data;
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

        public void UpdateMechanicFields(string appointmentId, string additionalRepairs, string CollectionTime)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "UPDATE Appointments SET AdditionalRepairs = @AdditionalRepairs, CollectionTime = @CollectionTime WHERE AppointmentId = @AppointmentId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdditionalRepairs", additionalRepairs);
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


    }


}