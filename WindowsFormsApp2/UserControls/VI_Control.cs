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
using System.Security.Cryptography;

namespace Assignment.UserControls
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
             totalEngineParts = 0;
             totalSpareWheels = 0;
             totalOil = 0;
             totalHeadlights = 0;
             totalExhaustPipe = 0;
            LoadTotal();
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
            LoadTotal();
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
                int totalPrice =
                    int.Parse(engineParts) * 200
                    + int.Parse(spareWheels) * 100
                    + int.Parse(oil) * 50
                    + int.Parse(headlights) * 75
                    + int.Parse(exhaustPipe) * 85;
                if (selectedMechanic[1] == orderID)     // Uses the splited string to match and print the specific one
                {
                    // Append parts info into the RichTextBox
                    MechSelfRequest.AppendText($"Order ID: {orderID}\n");
                    MechSelfRequest.AppendText($"Engine Parts: {engineParts}\n");
                    MechSelfRequest.AppendText($"Spare Wheels: {spareWheels}\n");
                    MechSelfRequest.AppendText($"Oil: {oil}\n");
                    MechSelfRequest.AppendText($"Headlights: {headlights}\n");
                    MechSelfRequest.AppendText($"Exhaust Pipe: {exhaustPipe}\n");
                    MechSelfRequest.AppendText($"Total Price: RM{totalPrice}");
                }
                else { continue; }
                totalEngineParts += int.Parse(engineParts);
                totalSpareWheels += int.Parse(spareWheels);
                totalOil += int.Parse(oil);
                totalHeadlights += int.Parse(headlights);
                totalExhaustPipe += int.Parse(exhaustPipe);
                LoadTotal();
            }
        }

        int totalEngineParts = 0;
        int totalSpareWheels = 0;
        int totalOil = 0;
        int totalHeadlights = 0;
        int totalExhaustPipe = 0;

        private void LoadTotal()
        {
            int totalPrice =
                totalEngineParts * 200
                + totalSpareWheels * 100
                + totalOil * 50
                + totalHeadlights * 75
                + totalExhaustPipe * 85;

            StringBuilder sb = new StringBuilder();
            sb.Append("=======================\n");
            sb.AppendLine($"Engine Parts: {totalEngineParts}");
            sb.Append("=======================\n");
            sb.AppendLine($"Spare Wheels: {totalSpareWheels}");
            sb.Append("=======================\n");
            sb.AppendLine($"Oil: {totalOil}");
            sb.Append("=======================\n");
            sb.AppendLine($"Headlights: {totalHeadlights}");
            sb.Append("=======================\n");
            sb.AppendLine($"Exhaust Pipe: {totalExhaustPipe}");
            sb.Append("=======================\n");
            sb.Append($"Total Price: RM{totalPrice}");

            TotalInv.Text = sb.ToString();
        }
    }
}
