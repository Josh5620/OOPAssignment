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
        }
        Mechanic mech = new Mechanic(); 

        private void DataGridView321_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateServices_Load_1(object sender, EventArgs e)
        {
            DataTable fullDataTable1 = mech.LoadDataGrid("appointment");
            List<string> fieldsToDisplay1 = new List<string> { "FullName", "CustomerId", "ServiceId", "VehicleNumber", "AppointmentDate", "AdditionalNotes", "Status" };
            DataGridView321.DataSource = fullDataTable1;
            foreach (DataGridViewColumn column in DataGridView321.Columns)
            {
                if (!fieldsToDisplay1.Contains(column.Name))
                {
                    column.Visible = false;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
