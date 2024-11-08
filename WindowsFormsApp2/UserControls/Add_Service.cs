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
            admin.AddService(ServiceNBox.Text, DescrpBox.Text, int.Parse(PriceBox.Text), EstitmatedTBox.Text);
            ServiceDataGrid.DataSource = admin.LoadDataGrid("service");
        }
    }
}
