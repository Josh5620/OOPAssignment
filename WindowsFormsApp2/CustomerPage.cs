using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CustomerPage : Form
    {
        // Declare user controls
        private Viewservices userControl1;
        private ManageAppointments userControl2;
        private UpdateProfile userControl3;
        private Feedback userControl4;
        private HomePage userControl5;

        public CustomerPage()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        // Initialize user controls
        private void InitializeUserControls()
        {
            // Initialize each user control and set its Dock style
            userControl1 = new Viewservices { Dock = DockStyle.Fill };
            userControl2 = new ManageAppointments { Dock = DockStyle.Fill };
            userControl3 = new UpdateProfile { Dock = DockStyle.Fill };
            userControl4 = new Feedback { Dock = DockStyle.Fill };
            userControl5 = new HomePage { Dock = DockStyle.Fill };

            // Add user controls to the panel
            panel2.Controls.Add(userControl1);
            panel2.Controls.Add(userControl2);
            panel2.Controls.Add(userControl3);
            panel2.Controls.Add(userControl4);
            panel2.Controls.Add(userControl5);

            // Initially hide all user controls
            HideAllUserControls();
        }

        // Button click to show Viewservices user control
        private void button1_Click(object sender, EventArgs e)
        {
            ShowUserControl(userControl1);
        }

        // Button click to show ManageAppointments user control
        private void button4_Click(object sender, EventArgs e)
        {
            ShowUserControl(userControl2);
        }

        // Button click to show UpdateProfile user control
        private void button3_Click(object sender, EventArgs e)
        {
            ShowUserControl(userControl3);
        }

        // Button click to show Feedback user control
        private void button2_Click(object sender, EventArgs e)
        {
            ShowUserControl(userControl4);
        }

        // Helper method to hide all user controls
        private void HideAllUserControls()
        {
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is UserControl userControl)
                {
                    userControl.Visible = false;
                }
            }
        }

        // Helper method to show a specific user control
        private void ShowUserControl(UserControl userControl)
        {
            HideAllUserControls();
            userControl.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
