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

namespace WindowsFormsApp2.UserControls
{
    public partial class VI_Control : UserControl
    {
        public VI_Control()
        {
            InitializeComponent();
        }

        Receptionist Recep = new Receptionist();
        private void SearchBtn_Click(object sender, EventArgs e)
        {

            if (IDSearch.SelectedItem != null)
            {
                Recep.GetUserID(IDSearch.SelectedItem.ToString());
                MechSelfRequest.Text = ($"Here's the requested items for {Recep.FocusID}");
                
            }
            else
            {
                MessageBox.Show("Please select a valid ID!");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MechSelfRequest.Text = "";
            IDSearch.SelectedItem = null;
        }
    }
}
