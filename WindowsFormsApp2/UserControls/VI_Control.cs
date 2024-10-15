using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2.UserControls
{
    public partial class VI_Control : UserControl
    {
        public VI_Control()
        {
            InitializeComponent();
        }

        Receptionist Recep = new Receptionist();

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MechSelfRequest.Text = "";
            IDSearch.SelectedItem = null;
        }

        private void VI_Control_Load(object sender, EventArgs e)
        {
            SQLiteDataReader reader = Recep.LoadOrderTable();
            while (reader.Read())
            {
                string orderID = reader["OrderID"].ToString();
                string staffName = reader["FullName"].ToString();

                IDSearch.Items.Add($"OrderID: {orderID}, Staff: {staffName}");
            }
        }
    }
}
