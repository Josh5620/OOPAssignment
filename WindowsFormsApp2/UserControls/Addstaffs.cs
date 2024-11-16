using Assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Addstaffs : UserControl
    {
        public Addstaffs()
        {
            InitializeComponent();
            LoadJobTypes();
            StaffDataGrid.DataSource = admin.staffData;
        }
        Admin admin = new Admin();

        private void LoadJobTypes()
        {
            // Check if the ComboBox is empty before adding items
            if (ComboJobType.Items.Count == 0)
            {
                // Add job types to the ComboBox
                ComboJobType.Items.Add("Admin");
                ComboJobType.Items.Add("Receptionist");
                ComboJobType.Items.Add("Mechanic");
            }
        }
        private void Btn_addnewstaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNBox.Text) ||
                string.IsNullOrEmpty(UsernBox.Text) ||
                string.IsNullOrEmpty(PassBox.Text) ||
                string.IsNullOrEmpty(ComboJobType.Text))
            {
                MessageBox.Show("Please fill in the information required.");
            }
            else
            {
                admin.AddStaff(FullNBox.Text, UsernBox.Text, PassBox.Text, ComboJobType.Text);
                StaffDataGrid.DataSource = admin.LoadDataGrid("staff");
            }

        }
    }
}
