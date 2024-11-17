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
    public partial class ManageInventory : UserControl
    {
        private string _username;
        private Mechanic mech = new Mechanic();
        public ManageInventory()
        
        {
            InitializeComponent();
           // _username = username;
        }
     
        private void ManageInventory_Load(object sender, EventArgs e)
        {
            DataGridView123.DataSource = mech.LoadDataGrid("order");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the logged-in mechanic's StaffID
            string query = "SELECT StaffId FROM Staff_Table WHERE Username = @Username";
            int staffId = 0;

            //using (SQLiteCommand command = new SQLiteCommand(query, mech.Connection))
            {
                //command.Parameters.AddWithValue("@Username", _username);
               // using (SQLiteDataReader reader = command.ExecuteReader())
                {
                   // if (reader.Read())
                    {
                    //    staffId = reader.GetInt32(0);
                    }
                }
            }

            // Prepare the parts request data
            var partsRequests = new List<(string PartName, int Quantity)>
            {
                ("EngineParts", (int)numericUpDownEngineParts.Value),
                ("SpareWheels", (int)numericUpDownSpareWheels.Value),
                ("Oil", (int)numericUpDownOil.Value),
                ("Headlights", (int)numericUpDownHeadlights.Value),
                ("ExhaustPipe", (int)numericUpDownExhaustPipe.Value)
            };

            // Insert the parts request into the Order_Table
            foreach (var request in partsRequests)
            {
                if (request.Quantity > 0)
                {
                    string insertQuery = "INSERT INTO Order_Table (StaffId, PartName, Quantity) VALUES (@StaffId, @PartName, @Quantity)";
                    //using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, mech.Connection))
                    {
                       // insertCommand.Parameters.AddWithValue("@StaffId", staffId);
                        //insertCommand.Parameters.AddWithValue("@PartName", request.PartName);
                        //insertCommand.Parameters.AddWithValue("@Quantity", request.Quantity);
                        //insertCommand.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Parts requested successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
   