using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.UserControls
{
    public partial class UpdateServices : UserControl
    {
        public UpdateServices()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }
        Mechanic mech = new Mechanic();


        private void InitializeEventHandlers()
        {
            DataGridView321.CellClick += DataGridView321_CellClick;
            btnEdit.Click += btnEdit_Click;

        }

        private void DataGridView321_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateServices_Load_1(object sender, EventArgs e)
        {
            List<string> fieldsToDisplay1 = new List<string> { "FullName", "CustomerId", "AppointmentId", "VehicleNumber", "AppointmentDate", "Status", "AdditionalNotes", "MechanicNotes", "CollectionTime" };
            DataGridView321.DataSource = mech.LoadAndFilterData("appointment", fieldsToDisplay1, "Status = 'Assigned'");


        }



        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
       
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if only MechanicNotes and Completion Time are edited
            if (txtFullName.Modified || txtCustomerId.Modified || txtAppointmentId.Modified || txtVehicleNumber.Modified || txtAppointmentDate.Modified || txtAdditionalNotes.Modified || txtStatus.Modified)
            {
                MessageBox.Show("You don't have access to change these fields.");
                return;
            }

            mech.UpdateMechanicFields(
                txtAppointmentId.Text,
                txtMechanicNotes.Text,
                txtCollectionTime.Text
            );

            mech.ClearTextBoxes(this);
            // mech.RefreshDataGridView(this, "DataGridView321", "appointment"); // Uncomment when ready to use

        }
        private void DataGridView321_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DataGridView321.Rows[e.RowIndex];
                    txtFullName.Text = row.Cells["FullName"].Value.ToString();
                    txtCustomerId.Text = row.Cells["CustomerId"].Value.ToString();
                    txtAppointmentId.Text = row.Cells["AppointmentId"].Value.ToString();
                    txtVehicleNumber.Text = row.Cells["VehicleNumber"].Value.ToString();
                    txtAppointmentDate.Text = row.Cells["AppointmentDate"].Value.ToString();
                    txtAdditionalNotes.Text = row.Cells["AdditionalNotes"].Value.ToString();
                    txtStatus.Text = row.Cells["Status"].Value.ToString();
                }
            }

        }


    }
}
