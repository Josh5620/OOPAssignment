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
            admin.EditService(int.Parse(ServiceIdBox.Text), int.Parse(PriceBox.Text), EstimatedTBox.Text);
            ServiceDataGrid.DataSource = admin.LoadDataGrid("service");
        }
    }
}
