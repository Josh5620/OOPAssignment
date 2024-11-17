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
    public partial class Delete_Service : UserControl
    {
        public Delete_Service()
        {
            InitializeComponent();
            ServiceDataGrid.DataSource = admin.ServiceData;
        }
        Admin admin = new Admin();

        private void Btn_deleteservice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ServiceIdBox.Text))
            {
                MessageBox.Show("Please enter the ID of the service you want to delete.");
            }
            else
            {
                // Ask for confirmation
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this service?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        admin.DeleteService(int.Parse(ServiceIdBox.Text));
                        ServiceDataGrid.DataSource = admin.LoadDataGrid("service");
                        MessageBox.Show("Service successfully deleted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }

    }
}
