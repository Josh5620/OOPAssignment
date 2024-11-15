using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment;
using WindowsFormsApp2;

namespace Assignment
{
    public partial class LoginPage : Form
    {
        public User user;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CForm = new RecepPage();
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

            User authenticateduser = User.Authenticate(username, password);

            if (authenticateduser != null)
            {
                switch (authenticateduser.JobType)
                {
                    case "Admin":
                        AdminPage adminpage = new AdminPage();
                        adminpage.Show();
                        this.Hide();
                        break;

                    case "Receptionist":
                        RecepPage recepPage = new RecepPage();
                        recepPage.Show();
                        this.Hide();
                        break;

                    /*case "Mechanic":
                        MechanicPage mechanicPage = new MechanicPage();
                        mechanicPage.Show();
                        this.Hide();
                        break;

                    case "Customer":
                        CustomerPage customerPage = new CustomerPage();
                        customerPage.Show();
                        this.Hide();
                        break; */

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
            var CForm = new Form1();
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
