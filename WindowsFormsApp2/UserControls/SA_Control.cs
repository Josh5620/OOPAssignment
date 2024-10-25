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
    public partial class SA_Control : UserControl
    {
        public SA_Control()

        {
            InitializeComponent();

        }
        Receptionist Recep = new Receptionist();
        private SQLiteDataReader reader;
        string staffID;


        private void SA_Control_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Recep.LoadAppTable();
            reader = Recep.LoadStaffIds();
            while (reader.Read())
            {
                staffID = reader["StaffId"].ToString();
                string staffName = reader["StaffName"].ToString();

                listBox1.Items.Add($"MechanicID: {staffID} , MechanicName: {staffName}");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CustNameTxtBox.Text = string.Empty;
            VNTextBox.Text = string.Empty;
            AppIDTxtBox.Text = string.Empty;
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            string filterName = CustNameTxtBox.Text.Trim();
            int filterVN;
            int filterAPPID;

            DataTable dt = (DataTable)dataGridView1.DataSource;

            string rowFilter = "";


            if (!string.IsNullOrEmpty(filterName))
            {
                rowFilter += $"FullName LIKE '%{filterName}%'";
            }



            if (int.TryParse(VNTextBox.Text.Trim(), out filterVN) && filterVN > 0)
            {
                if (!string.IsNullOrEmpty(rowFilter))
                {
                    rowFilter += " AND ";
                }
                rowFilter += $"VehicleNumber = {filterVN}";
            }


            if (int.TryParse(AppIDTxtBox.Text.Trim(), out filterAPPID) && filterAPPID > 0)
            {
                if (!string.IsNullOrEmpty(rowFilter))
                {
                    rowFilter += " AND ";
                }
                rowFilter += $"AppointmentId = {filterAPPID}";
            }

            if (!string.IsNullOrEmpty(rowFilter))
            {
                dt.DefaultView.RowFilter = rowFilter;
            }
            else
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            string[] selectedMechanic = listBox1.SelectedItem.ToString().Split(' ');
            Receptionist Recep = new Receptionist();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedAppointmentId = dataGridView1.SelectedRows[0].Cells["AppointmentId"].Value != null
                    ? Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AppointmentId"].Value)
                    : 0;

                // SQL Update command
                string query = "UPDATE Appointments SET MechanicID = @MechanicID WHERE AppointmentId = @AppointmentId";

                using (SQLiteConnection conn = Recep.connection)
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MechanicID", Convert.ToInt32(selectedMechanic[1]));
                        cmd.Parameters.AddWithValue("@AppointmentId", selectedAppointmentId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Recep.LoadAppTable();
            reader = Recep.LoadStaffIds();
            listBox1.Text = "";
            listBox1.Items.Clear();
            while (reader.Read())
            {
                staffID = reader["StaffId"].ToString();
                string staffName = reader["StaffName"].ToString();

                listBox1.Items.Add($"MechanicID: {staffID} , MechanicName: {staffName}");

            }
        }


    }
}
