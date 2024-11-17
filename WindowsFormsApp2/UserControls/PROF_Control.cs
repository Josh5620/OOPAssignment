using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment.UserControls
{
    public partial class PROF_Control : UserControl
    {
        public PROF_Control(string Username)
        {
            InitializeComponent();

            Username1 = Username;
            LoadData();
        }
        
        public User user { get; set; }

        Receptionist Recep = new Receptionist();
        string FullName;
        string Password;
        string Email;
        string PhoneNumber;
        string Address;
        string Username1;


        private void LoadData()
        {

            Dictionary<string,string> profileInfo =  Recep.GetProfileInfo(Username1);

            label2.Text = $"Fullname: {profileInfo["FullName"]}";
            label3.Text = $"Password: {profileInfo["Password"]}";
            label4.Text = $"Email: {profileInfo["Email"]}";
            label5.Text = $"P/N: {profileInfo["PhoneNumber"]}";
            label6.Text = $"Address: {profileInfo["Address"]}";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PROF_Control_Load(object sender, EventArgs e)

        {


        }
    }
}
