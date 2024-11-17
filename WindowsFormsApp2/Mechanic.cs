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

        public void AddData(string fullName, string customerId, string serviceId, string vehicleNumber, string appointmentDate, string additionalNotes, string status)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO Appointments (FullName, CustomerId, ServiceId, VehicleNumber, AppointmentDate, AdditionalNotes, Status) " +
                               "VALUES (@FullName, @CustomerId, @ServiceId, @VehicleNumber, @AppointmentDate, @AdditionalNotes, @Status)";

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
                        MessageBox.Show("Data added successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding data: {ex.Message}");
                    }
                }
            }
        }

        public bool ServiceIdExists(string serviceId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Appointments WHERE ServiceId = @ServiceId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ServiceId", serviceId);

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


        public void RefreshDataGridView(UserControl userControl, string dataGridViewName, string tableName)
        {
            var dataGridView = userControl.Controls[dataGridViewName] as DataGridView;
            if (dataGridView == null)
            {
                throw new ArgumentException($"No DataGridView with the name '{dataGridViewName}' found in the UserControl.");
            }

            // Load data from the specified table
            DataTable dataTable = LoadDataGrid(tableName);

            // Set the DataSource of the DataGridView to the loaded data
            dataGridView.DataSource = dataTable;
        }



        public void AddDataToDatabase(UserControl userControl)
        {
            TextBoxBase txtFullName = (TextBoxBase)userControl.Controls["txtFullName"];
            TextBoxBase txtCustomerId = (TextBoxBase)userControl.Controls["txtCustomerId"];
            TextBoxBase txtServiceId = (TextBoxBase)userControl.Controls["txtServiceId"];
            TextBoxBase txtVehichleNumber = (TextBoxBase)userControl.Controls["txtVehichleNumber"];
            TextBoxBase txtAppointmentDate = (TextBoxBase)userControl.Controls["txtAppointmentDate"];
            TextBoxBase txtAdditionalNotes = (TextBoxBase)userControl.Controls["txtAdditionalNotes"];
            TextBoxBase txtStatus = (TextBoxBase)userControl.Controls["txtStatus"];

            // Check if all required textboxes are filled
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerId.Text) ||
                string.IsNullOrWhiteSpace(txtServiceId.Text) ||
                string.IsNullOrWhiteSpace(txtVehichleNumber.Text) ||
                string.IsNullOrWhiteSpace(txtAppointmentDate.Text) ||
                string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Please fill in all required fields before adding the information.");
                return;
            }

            string serviceId = txtServiceId.Text;

            if (ServiceIdExists(serviceId))
            {
                MessageBox.Show("The service ID entered already exists.");
                return;
            }

            AddData(
                txtFullName.Text,
                txtCustomerId.Text,
                serviceId,
                txtVehichleNumber.Text,
                txtAppointmentDate.Text,
                txtAdditionalNotes.Text,
                txtStatus.Text
            );

            ClearTextBoxes(userControl);
            RefreshDataGridView(userControl, "DataGridView321", "appointment");
        }
    }
}