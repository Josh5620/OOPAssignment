using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.UserControls
{
    public partial class ManageInventory : UserControl
    {
        private string _username;

        public ManageInventory()

        {
            InitializeComponent();
            LoadInventoryData();    
            // _username = username;
        }

        private Mechanic mech = new Mechanic();

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            DataGridView123.DataSource = mech.LoadDataGrid("inventory");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                // Get the quantities from the NumericUpDown controls
                int enginePartsQty = (int)numericUpDownEngineParts.Value;
                int spareWheelsQty = (int)numericUpDownSpareWheels.Value;
                int oilQty = (int)numericUpDownOil.Value;
                int exhaustPipeQty = (int)numericUpDownExhaustPipe.Value;
                int headlightsQty = (int)numericUpDownHeadlights.Value;

                // Get the next OrderID
                int nextOrderId = mech.GetNextOrderId();

                // Update the Order_Table
                mech.UpdateOrderTable(nextOrderId, enginePartsQty, spareWheelsQty, oilQty, exhaustPipeQty, headlightsQty);
            }



        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Deduct inventory for each product
            mech.DeductInventory(1, (int)numericUpDownEngineParts.Value);
            mech.DeductInventory(2, (int)numericUpDownHeadlights.Value);
            mech.DeductInventory(3, (int)numericUpDownOil.Value);
            mech.DeductInventory(4, (int)numericUpDownSpareWheels.Value);
            mech.DeductInventory(5, (int)numericUpDownExhaustPipe.Value);

            MessageBox.Show("Inventory updated successfully!");
        }
        private void LoadInventoryData()
        {
            DataGridView123.DataSource = mech.LoadInventoryData();
        }

    }
}



   