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
    public partial class MechProf : UserControl
    {
        public MechProf(string username)
        {
            InitializeComponent();
            Username1 = username;
            LoadData();
        }

        Mechanic Mech = new Mechanic();  // Use Mechanic class
        string Username1;
        string FullName;
        string Password;
        string Email;
        string PhoneNumber;
        string Address;

        public void LoadData()
        {
            Dictionary<string, string> profileInfo = Mech.GetProfileInfo(Username1);

            var profileLabels = new Dictionary<string, Label>
    {
        { "Username", label12 },
        { "FullName", label11 },
        { "Password", label10 },
        { "Email", label9 },
        { "PhoneNumber", label8 },
        { "Address", label7 }
    };

            foreach (var key in profileLabels.Keys)
            {
                if (profileInfo.ContainsKey(key))
                {
                    profileLabels[key].Text = $"{key}: {profileInfo[key]}";
                }
                else
                {
                    profileLabels[key].Text = $"{key}: Not Available";
                }
            }
        }


        private void MechProf_Load(object sender, EventArgs e)
        {
            // You can load additional setup if needed when the UserControl is loaded
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            FullName = textBox1.Text;
            Password = textBox2.Text;
            Email = textBox3.Text;
            PhoneNumber = textBox4.Text;
            Address = textBox5.Text;

            // Update profile for the mechanic
            Mech.UpdateProfile(Username1, FullName, Password, Email, PhoneNumber, Address);

            // Reload data to update the display
            LoadData();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clear all the input fields
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }
    }
}
