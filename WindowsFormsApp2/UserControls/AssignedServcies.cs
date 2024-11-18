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
    public partial class AssignedServcies : UserControl
    {
        private string _username;  // Store the username to use in queries
        private Mechanic mech = new Mechanic();

        public AssignedServcies(string username)
        {
            InitializeComponent();
            _username = username;  // Store the passed username
        }

        private void AssignedServcies_Load(object sender, EventArgs e)
        {
            // Fields to display in DataGridView 1 (Assigned tasks)
            List<string> fieldsToDisplay1 = new List<string> { "AppointmentId", "FullName", "CustomerId", "AppointmentDate", "ServiceId", "VehicleNumber", "AdditionalNotes", "Status" };
            // Filter appointments by Status = 'Assigned' and the mechanic's username
            dgvToday.DataSource = mech.LoadAndFilterData("Appointments", fieldsToDisplay1, "Status = 'Assigned' AND MechanicId = (SELECT StaffId FROM Staff_Table WHERE Username = @Username)", new SQLiteParameter("@Username", _username));

            // Fields to display in DataGridView 2 (All non-completed tasks)
            List<string> fieldsToDisplay2 = new List<string> { "AppointmentId", "FullName", "CustomerId", "AppointmentDate", "ServiceId", "VehicleNumber", "AdditionalNotes", "Status" };
            // Filter appointments where Status is not 'Completed' and the mechanic's username
            dgvAll.DataSource = mech.LoadAndFilterData("Appointments", fieldsToDisplay2, "Status <> 'Completed' AND MechanicId = (SELECT StaffId FROM Staff_Table WHERE Username = @Username)", new SQLiteParameter("@Username", _username));
        }
    }
}
