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
        

        Receptionist Recep = new Receptionist();
        string Username1;
        string FullName;
        string Password;
        string Email;
        string PhoneNumber;
        string Address;

        private void LoadData()
        {

            Dictionary<string,string> profileInfo =  Recep.GetProfileInfo(Username1);

            label1.Text = $"Current Profile: {profileInfo["Username"]}";
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

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            FullName = textBox1.Text;
            Password = textBox2.Text;
            Email = textBox3.Text;
            PhoneNumber = textBox4.Text;
            Address = textBox5.Text;
            Recep.UpdateProfile(Username1,FullName,Password,Email,PhoneNumber,Address);
            LoadData();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }
    }
}
