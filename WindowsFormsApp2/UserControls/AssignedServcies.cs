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
            List<string> fieldsToDisplay1 = new List<string> { "AppointmentId", "FullName", "CustomerId", "AppointmentDate", "ServiceId", "VehichleNumber", "AdditionalNotes", "Status" };
            dgvToday.DataSource = mech.LoadAndFilterData("appointment", fieldsToDisplay1, "Status = 'Assigned'");

            List<string> fieldsToDisplay2 = new List<string> { "AppointmentId", "FullName", "CustomerId", "AppointmentDate", "ServiceId", "VehichleNumber", "AdditionalNotes", "Status" };
            dgvAll.DataSource = mech.LoadAndFilterData("appointment", fieldsToDisplay2, "Status <> 'Completed'");
        }
    }
}