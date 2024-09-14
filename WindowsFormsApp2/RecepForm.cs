using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Drawing2D;
using WindowsFormsApp2.UserControls;



namespace WindowsFormsApp2
{
    public partial class RecepForm : Form
    {
        public RecepForm()
        {
            InitializeComponent();
            AddCust.Hide(); 
            DelCust.Hide();

        }
        bool hover = false;
        private void TimerCheck() // Counts as a method ig cause i might use it abunch 
                                  // for !hover and !add can be changed to accept arguements if want to use for other buttons
        {
            System.Timers.Timer timer = new System.Timers.Timer(500);
            timer.AutoReset = false;
            timer.Start();
            timer.Elapsed += (sender1, e1) =>
            {
                if (!hover && (!AddCust.Focused && !DelCust.Focused))
                {
                    AddCust.Hide();
                    DelCust.Hide();
                }
            };

        }

        private void BtnHighlight(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Red;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            hover = true;
            DelCust.Show();
            AddCust.Show();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            hover = false;
            TimerCheck();
        }

        private void AddCust_Hover(object sender, EventArgs e)
        {
            hover = true;
        }

        private void DelCust_Hover(object sender, EventArgs e)
        {
            hover = true;
        }
        private void AddBtnLeave(object sender, EventArgs e)
        {
            hover = false;
            TimerCheck();
        }
        private void DelBtnLeave(object sender, EventArgs e)
        {
            hover = false;
            TimerCheck();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ControlPanel.Controls.Clear();
            ControlPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void ServBtn_Click(object sender, EventArgs e)
        {   
            SA_Control sac = new SA_Control();
            addUserControl(sac);
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            CIO_Control cio = new CIO_Control();
            addUserControl(cio);
        }

        private void InvButton_Click(object sender, EventArgs e)
        {
            VI_Control vi = new VI_Control();
            addUserControl(vi);
        } 
        private void ProfBtn_Click(object sender, EventArgs e)
        {
            PROF_Control prof = new PROF_Control();
            addUserControl(prof);
        }

        private void DelCust_Click(object sender, EventArgs e)
        {
            CMDEL_Control cmdel = new CMDEL_Control();
            addUserControl(cmdel);
        }

        private void AddCust_Click(object sender, EventArgs e)
        {
            CMADD_Control cmadd = new CMADD_Control();
            addUserControl(cmadd);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
