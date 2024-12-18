﻿using Assignment;
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
        UserControls.AssignedServcies udassignedServcies = new UserControls.AssignedServcies(username1);
        UserControls.UpdateServices udUpdateServcies = new UserControls.UpdateServices();
        UserControls.ManageInventory udManageInventory = new UserControls.ManageInventory();
        UserControls.MechProf udMechProf = new UserControls.MechProf(username1);

        public MechanicPage(string username)
        {
            InitializeComponent();
            username1 = username;
        }

        public static string username1;
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
            // Initialize and add the RequestParts control with the username



        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(udMechProf);
            udMechProf.Dock = DockStyle.Fill;

        }
    }
}
