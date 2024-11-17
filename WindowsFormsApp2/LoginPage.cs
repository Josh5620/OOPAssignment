using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
            LoadJobTypes();
        }
        //Authenticate function now takes the jobtype of the user before entering.
        private void LoadJobTypes()
        {
            // Check if the ComboBox is empty 
            if (RoleBox.Items.Count == 0)
            {
                // Add JobTypes to the Combo Box
                RoleBox.Items.Add("Admin");
                RoleBox.Items.Add("Receptionist");
                RoleBox.Items.Add("Mechanic");
                RoleBox.Items.Add("Customer");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CForm = new RecepPage("Mac10");
            CForm.Closed += (s, args) => this.Close();
            CForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CForm = new AdminPage();
            CForm.Closed += (s, args) => this.Close();
            CForm.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            string JobType = RoleBox.Text;

            User authenticateduser = User.Authenticate(username, password, JobType);

            if (authenticateduser != null && authenticateduser.JobType == JobType)
            {
                switch (authenticateduser.JobType)
                {
                    case "Admin":
                        AdminPage adminpage = new AdminPage();
                        adminpage.Show();
                        this.Hide();
                        break;

                    case "Receptionist":
                        RecepPage recepPage = new RecepPage(username);
                        recepPage.Show();
                        this.Hide();
                        break;

                    case "Mechanic":
                        MechanicPage mechanicPage = new MechanicPage();
                        mechanicPage.Show();
                        this.Hide();
                        break;

                    case "Customer":
                        CustomerPage customerPage = new CustomerPage();
                        customerPage.Show();
                        this.Hide();
                        break; 

                    default:
                        MessageBox.Show("JobType Not Found.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again.");
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CForm = new CustomerPage();
            CForm.Closed += (s, args) => this.Close();
            CForm.Show();
        }

        private void Mechanic_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CForm = new MechanicPage();
            CForm.Closed += (s, args) => this.Close();
            CForm.Show();

        }
    }
}
