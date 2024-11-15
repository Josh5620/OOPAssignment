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
    public partial class AssignedServcies : UserControl
    {
        public AssignedServcies()
        {
            InitializeComponent();
        }
     Mechanic mech = new Mechanic();

        private void AssignedServcies_Load(object sender, EventArgs e)
        {
            // Load data for the first DataGridView
            DataTable fullDataTable1 = mech.LoadDataGrid("appointment");
            List<string> fieldsToDisplay1 = new List<string> { "Field1", "Field2", "Field3", "AppointmentDate" };
            dgvToday.DataSource = fullDataTable1;
            foreach (DataGridViewColumn column in dgvToday.Columns)
            {
                if (!fieldsToDisplay1.Contains(column.Name))
                {
                    column.Visible = false;
                }
            }

            // Filter the first DataGridView to show only today's appointments
            DataView dataView1 = new DataView(fullDataTable1);
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            dataView1.RowFilter = $"AppointmentDate = '{today}'";
            dgvToday.DataSource = dataView1;


            // Load data for the second DataGridView
            DataTable fullDataTable2 = mech.LoadDataGrid("appointment");
            List<string> fieldsToDisplay2 = new List<string> { "AppointmentId", "AppointmentDate", "FieldC" };
            dgvAll.DataSource = fullDataTable2;
            foreach (DataGridViewColumn column in dgvAll.Columns)
            {
                if (!fieldsToDisplay2.Contains(column.Name))
                {
                    column.Visible = false;
                }





            }

        }
    }
}
