using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Add_Service : UserControl
    {
        public Add_Service()
        {
            InitializeComponent();
            ServiceDataGrid.DataSource = admin.serviceTData;
        }
        Admin admin = new Admin();

        private void Btn_AddService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ServiceNBox.Text) ||
                string.IsNullOrEmpty(DescrpBox.Text) ||
                string.IsNullOrEmpty(PriceBox.Text) ||
                string.IsNullOrEmpty(EstitmatedTBox.Text))
            {
                MessageBox.Show("Please fill in the information required.");
            }
            else
            {
                admin.AddService(ServiceNBox.Text, DescrpBox.Text, int.Parse(PriceBox.Text), EstitmatedTBox.Text);
                ServiceDataGrid.DataSource = admin.LoadDataGrid("service");
            }
                
            }
        }
    }

