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
        private SQLiteDataReader reader;

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MechSelfRequest.Text = "";
            IDSearch.Text = string.Empty;
        }

        private void VI_Control_Load(object sender, EventArgs e)
        {
            reader = Recep.LoadOrderTable();
            while (reader.Read())
            {
                string orderID = reader["OrderID"].ToString();
                string staffName = reader["StaffName"].ToString();

                IDSearch.Items.Add($"OrderID: {orderID} , Staff: {staffName}");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string[] selectedMechanic = IDSearch.SelectedItem.ToString().Split(' ');        // Splits the combobox string to get the orderID
            reader = Recep.LoadOrderTable();
            MechSelfRequest.Text = "";
            while (reader.Read())
            {
                string orderID = reader["OrderID"].ToString();
                string engineParts = reader["EngineParts"].ToString();
                string spareWheels = reader["SpareWheels"].ToString();
                string oil = reader["Oil"].ToString();
                string headlights = reader["Headlights"].ToString();
                string exhaustPipe = reader["ExhaustPipe"].ToString();
                if (selectedMechanic[1] == orderID)     // Uses the splited string to match and print the specific one
                {
                    // Append parts info into the RichTextBox
                    MechSelfRequest.AppendText($"Order ID: {orderID}\n");
                    MechSelfRequest.AppendText($"Engine Parts: {engineParts}\n");
                    MechSelfRequest.AppendText($"Spare Wheels: {spareWheels}\n");
                    MechSelfRequest.AppendText($"Oil: {oil}\n");
                    MechSelfRequest.AppendText($"Headlights: {headlights}\n");
                    MechSelfRequest.AppendText($"Exhaust Pipe: {exhaustPipe}\n\n");
                }
                else { continue; }
            }
        }




    }
}
