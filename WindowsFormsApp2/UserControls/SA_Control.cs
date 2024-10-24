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
            dataGridView1.DataSource = Recep.LoadAppTable();
            reader = Recep.LoadStaffIds();
            while (reader.Read())
            {
                string staffID = reader["StaffId"].ToString();
                string staffName = reader["StaffName"].ToString();

                listBox1.Items.Add($"MechanicID: {staffID} , MechanicName: {staffName}");
            }

        }
        Receptionist Recep = new Receptionist();
        private SQLiteDataReader reader;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
