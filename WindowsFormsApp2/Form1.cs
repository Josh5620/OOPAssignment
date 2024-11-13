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

    public partial class Form1 : Form
    {

        private Viewservices userControl1;
        private ManageAppointments userControl2;
        private UpdateProfile userControl3;
        private Feedback userControl4;
        private HomePage userControl5;

        public Form1()
        {
            InitializeComponent();
            InitializeUserControls();
        }

   

        private void InitializeUserControls()
        {
            userControl1 = new Viewservices();
            userControl2 = new ManageAppointments();
            userControl3 = new UpdateProfile();
            userControl4 = new Feedback();
            userControl5 = new HomePage();


            userControl1.Dock = DockStyle.Fill;
            userControl2.Dock = DockStyle.Fill;
            userControl3.Dock = DockStyle.Fill;
            userControl4.Dock = DockStyle.Fill;
            userControl5.Dock = DockStyle.Fill;

            panel2.Controls.Add(userControl1);
            panel2.Controls.Add(userControl2);
            panel2.Controls.Add(userControl3);
            panel2.Controls.Add(userControl4);
            panel2.Controls.Add(userControl5);

            userControl1.Visible = false;
            userControl2.Visible = false;
            userControl3.Visible = false;
            userControl4.Visible = false;
            userControl5.Visible = false;

            // Debugging output
            Console.WriteLine(userControl1 != null); // Should print "True"
            Console.WriteLine(userControl2 != null); // Should print "True"
            Console.WriteLine(userControl3 != null); // Should print "True"
            Console.WriteLine(userControl4 != null); // Should print "True"
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            userControl1.Visible = true;
        }

        private void feedback2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            userControl2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            userControl3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            userControl4.Visible = true;

        }

        private void HideAllUserControls()
        {
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is UserControl)
                {
                    ctrl.Visible = false;
                }
            }
        }
    }
}
