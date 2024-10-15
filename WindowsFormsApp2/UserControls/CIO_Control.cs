using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.UserControls
{
    public partial class CIO_Control : UserControl
    {
        public CIO_Control()
        {
            InitializeComponent();
            // for smth in range to put all the stuff in database to the listboxes
        }
        Dictionary<string, string> studentGrades = new Dictionary<string, string>();
        private void PayBtn_Click(object sender, EventArgs e)
        {
            // Idk what to do with this maybe show QR code on MessageBox or just leave here to look nice
        }

        private void UptBtn_Click(object sender, EventArgs e)
        {
            // Switches arriving to arrived and arrived to completed (maybe make an undo btn?)
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            // Brings up a message box to show all the info of the specific order clicked maybe switch case to check which listbox its checking
        }

        private void CncBtn_Click(object sender, EventArgs e)
        {
            // Deletes that specific order, popup msgbox to confirm as ths will delte from dtbs too
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            // Changes the middle listbox to show the billing details then allow me to click the payment button.
        }
    }
}
