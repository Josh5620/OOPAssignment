using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.UserControls
{
    public partial class SA_Control : UserControl
    {
        public SA_Control()
        {
            InitializeComponent();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEST CLEARED!");
        }

        private void AsgnBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEST ASSIGNED!");
        }

        private void SA_Control_Load(object sender, EventArgs e)
        {

        }
    }
}
