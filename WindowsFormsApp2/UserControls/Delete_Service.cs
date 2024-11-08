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
            admin.DeleteService(int.Parse(ServiceIdBox.Text));
            ServiceDataGrid.DataSource = admin.LoadDataGrid("service");
        }
    }
}
