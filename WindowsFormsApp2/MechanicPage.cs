using Assignment;
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
    public partial class MechanicPage : Form
    {
        UserControls.AssignedServcies udassignedServcies = new UserControls.AssignedServcies();
        UserControls.UpdateServices udUpdateServcies = new UserControls.UpdateServices();
        UserControls.ManageInventory udManageInventory = new UserControls.ManageInventory();
        public MechanicPage()
        {
            InitializeComponent();
        }

        private void Mechanic_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(udassignedServcies);
            udassignedServcies.Dock = DockStyle.Fill;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(udassignedServcies);
            udassignedServcies.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(udUpdateServcies);
            udUpdateServcies.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(udManageInventory);
            udManageInventory.Dock = DockStyle.Fill;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
