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
    public partial class Edit_Service : UserControl
    {
        public Edit_Service()
        {
            InitializeComponent();
            ServiceDataGrid.DataSource = admin.serviceTData;
        }
        Admin admin = new Admin();

        private void Btn_UpdateService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ServiceIdBox.Text) || string.IsNullOrEmpty(PriceBox.Text) || string.IsNullOrEmpty(EstimatedTBox.Text))
            {
                MessageBox.Show("Please ensure all fields are filled.");
                return;
            }

            if (!int.TryParse(ServiceIdBox.Text, out int serviceId))
            {
                MessageBox.Show("Service ID must be a valid number.");
                return;
            }

            if (!int.TryParse(PriceBox.Text, out int price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            if (!TimeSpan.TryParse(EstimatedTBox.Text, out _))
            {
                MessageBox.Show("Estimated Time must be in a valid hh:mm:ss format.");
                return;
            }

            admin.EditService(serviceId, price, EstimatedTBox.Text);
            ServiceDataGrid.DataSource = admin.LoadDataGrid("service");

        }
    }
}
