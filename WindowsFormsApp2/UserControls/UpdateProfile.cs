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
    public partial class UpdateProfile : UserControl
    {
        private Customer customer;

        public UpdateProfile()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            // Optionally, load the existing customer data to populate the fields
            var profileInfo = customer.GetProfileInfo();
            textBoxFullName.Text = profileInfo.ContainsKey("FullName") ? profileInfo["FullName"] : string.Empty;
            textBoxEmail.Text = profileInfo.ContainsKey("Email") ? profileInfo["Email"] : string.Empty;
            textBoxPhoneNumber.Text = profileInfo.ContainsKey("PhoneNumber") ? profileInfo["PhoneNumber"] : string.Empty;
            textBoxAddress.Text = profileInfo.ContainsKey("Address") ? profileInfo["Address"] : string.Empty;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string newName = textBoxFullName.Text;
            string newEmail = textBoxEmail.Text;
            string newPhoneNumber = textBoxPhoneNumber.Text;
            string newAddress = textBoxAddress.Text;

            // Call the update method, which already handles messaging
            customer.UpdateProfile(newName, newEmail, newPhoneNumber, newAddress);
        }
    }

}
