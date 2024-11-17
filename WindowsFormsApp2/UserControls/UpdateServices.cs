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
            txtFullName.KeyDown += TextBox_KeyDown;
            txtCustomerId.KeyDown += TextBox_KeyDown;
            txtServiceId.KeyDown += TextBox_KeyDown;
            txtVehichleNumber.KeyDown += TextBox_KeyDown;
            txtAppointmentDate.KeyDown += TextBox_KeyDown;
            txtAdditionalNotes.KeyDown += TextBox_KeyDown;
            txtStatus.KeyDown += TextBox_KeyDown;

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += btnEdit_Click;

        }

        private void DataGridView321_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateServices_Load_1(object sender, EventArgs e)
        {
            List<string> fieldsToDisplay1 = new List<string> { "FullName", "CustomerId", "ServiceId", "VehichleNumber", "AppointmentDate", "AdditionalNotes", "Status" };
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
            if (e.KeyCode == Keys.Enter)
            {
                mech.AddDataToDatabase(this);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            mech.AddDataToDatabase(this);
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

    }
}
