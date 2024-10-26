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

namespace Assignment.UserControls
{
    public partial class CIO_Control : UserControl
    {
        public CIO_Control()
        {
            InitializeComponent();
            LoadLists();
            // for smth in range to put all the stuff in database to the listboxes
        }
        
        Receptionist Recep = new Receptionist();
        string appointmentId;
        int selectedAppointmentId;
        string billAmount;

        private void PayBtn_Click(object sender, EventArgs e)
        {
            // Idk what to do with this maybe show QR code on MessageBox or just leave here to look nice
        }

        private void UptBtn_Click(object sender, EventArgs e)
        {
            Recep.UpdateStatus(Convert.ToInt32(selectedAppointmentId));
            LoadLists();

        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = Recep.LoadDataGrid("appointment");
            richTextBox1.Clear();  // Clear existing text

            // Iterate over each row in the DataTable
            DataRow[] selectedRows = dataTable.Select($"AppointmentId = {selectedAppointmentId}");

            if (selectedRows.Length > 0)
            {
                DataRow row = selectedRows[0];  // Get the first matching row

                // Display each field with label and value
                richTextBox1.AppendText($"AppointmentID: {row["AppointmentId"]}\n");
                richTextBox1.AppendText($"FullName: {row["FullName"]}\n");
                richTextBox1.AppendText($"CustomerId: {row["CustomerId"]}\n");
                richTextBox1.AppendText($"ServiceId: {row["ServiceId"]}\n");
                richTextBox1.AppendText($"MechanicId: {row["MechanicId"]}\n");
                richTextBox1.AppendText($"VehicleNumber: {row["VehicleNumber"]}\n");
                richTextBox1.AppendText($"AppointmentDate: {row["AppointmentDate"]}\n");
                richTextBox1.AppendText($"Status: {row["Status"]}\n");
                richTextBox1.AppendText($"PaymentStatus: {row["PaymentStatus"]}\n");
                richTextBox1.AppendText($"BillAmount: ${row["BillAmount"]}\n");
                richTextBox1.AppendText($"AdditionalNotes: {row["AdditionalNotes"]}\n");
            }
            else
            {
                richTextBox1.AppendText("No appointment found with the selected ID.");
            }

        }


        private void BillBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Current Bill for selected ID is {billAmount}");
        }

        private void LoadLists()
        {
            SQLiteDataReader reader = Recep.LoadAppLists();
            // Clear existing items
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            // Populate ListBoxes based on Status
            while (reader.Read())
            {
                appointmentId = reader["AppointmentId"].ToString();
                string fullName = reader["FullName"].ToString();
                string status = reader["Status"].ToString();
                string billAmount = reader["BillAmount"].ToString();

                // Format display text for each ListBox
                string displayText = $"ID: {appointmentId} , Name: {fullName}, Bill: ${billAmount}";

                // Add data to appropriate ListBox based on status
                switch (status)
                {
                    case "Arriving":
                        listBox1.Items.Add(displayText);
                        break;
                    case "Servicing":
                        listBox2.Items.Add(displayText);
                        break;
                    case "Completed":
                        listBox3.Items.Add(displayText);
                        break;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedAppointmentFromListBox(listBox1);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedAppointmentFromListBox(listBox2);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedAppointmentFromListBox(listBox3);
        }

        private void DisplaySelectedAppointmentFromListBox(ListBox listBox)
        {
            if (listBox.SelectedItem != null)
            {
                string[] selectedID = listBox.SelectedItem.ToString().Split(' ');
                selectedAppointmentId = Convert.ToInt32(selectedID[1]);
                billAmount = selectedID[6];
            }
        }
    }
}
