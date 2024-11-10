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
    public partial class AdminPage : Form
    {
        private bool hover;

        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPageLoad(object sender, EventArgs e)
        {
            HideSubButtons();
        }

        private void HideSubButtons()
        {
            btn_addstaf.Visible = false;
            Btn_deletestaff.Visible = false;
            Btn_AddService.Visible = false;
            Btn_EditService.Visible = false;
            Btn_DeleteService.Visible = false;
        }

        private void TimerCheck(params Control[] subButtons)
        {
            System.Timers.Timer timer = new System.Timers.Timer(500);
            timer.AutoReset = false;
            timer.Start();
            timer.Elapsed += (sender1, e1) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    if (!hover && !AnyFocused(subButtons))
                    {
                        foreach (var button in subButtons)
                        {
                            button.Hide();
                        }
                    }
                });
            };
        }

        private bool AnyFocused(params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control.Focused)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnHighlight(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Red; 
        }

        private void BtnManageStaff_MouseHover(object sender, EventArgs e)
        {
            hover = true;
            btn_addstaf.Show();
            Btn_deletestaff.Show();
        }

        private void BtnManageStaff_MouseLeave(object sender, EventArgs e)
        {
            hover = false;
            TimerCheck(btn_addstaf, Btn_deletestaff);
        }

        private void Btn_addstaf_MouseHover(object sender, EventArgs e)
        {
            hover = true;
        }

        private void Btn_addstaf_MouseLeave(object sender, EventArgs e)
        {
            hover = false;
            TimerCheck(btn_addstaf);
        }

        private void Btn_deletestaff_MouseHover(object sender, EventArgs e)
        {
            hover = true;
        }

        private void Btn_deletestaff_MouseLeave(object sender, EventArgs e)
        {
            hover = false;
            TimerCheck(Btn_deletestaff);
        }

        private void BtnManageServiceInfo_MouseHover(object sender, EventArgs e)
        {
            hover = true;
            Btn_AddService.Show();
            Btn_EditService.Show();
            Btn_DeleteService.Show();
        }

        private void BtnManageServiceInfo_MouseLeave(object sender, EventArgs e)
        {
            hover = false;
            TimerCheck(Btn_AddService, Btn_EditService, Btn_DeleteService);
        }

        private void Btn_AddService_MouseHover(object sender, EventArgs e)
        {
            hover = true;
        }

        private void Btn_AddService_MouseLeave(object sender, EventArgs e)
        {
            hover = false;
            TimerCheck(Btn_AddService, Btn_EditService, Btn_DeleteService);
        }

        private void Btn_EditService_MouseHover(object sender, EventArgs e)
        {
            hover = true;
        }

        private void Btn_EditService_MouseLeave(object sender, EventArgs e)
        {
            hover = false;
            TimerCheck(Btn_AddService, Btn_EditService, Btn_DeleteService);
        }

        private void Btn_DeleteService_MouseHover(object sender, EventArgs e)
        {
            hover = true;
        }

        private void Btn_DeleteService_MouseLeave(object sender, EventArgs e)
        {
            hover = false;
            TimerCheck(Btn_AddService, Btn_EditService, Btn_DeleteService);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AdminPContainer.Controls.Clear();
            AdminPContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        // Button click events to load user controls
        private void Btn_addstaf_Click(object sender, EventArgs e)
        {
            Addstaffs uc = new Addstaffs();
            AddUserControl(uc);
        }

        private void Btn_deletestaff_Click(object sender, EventArgs e)
        {
            DeleteStaff uc = new DeleteStaff();
            AddUserControl(uc);
        }

        private void Btn_AddService_Click(object sender, EventArgs e)
        {
            Add_Service uc = new Add_Service();
            AddUserControl(uc);
        }

        private void Btn_EditService_Click(object sender, EventArgs e)
        {
            Edit_Service uc = new Edit_Service();
            AddUserControl (uc);
        }

        private void Btn_DeleteService_Click(object sender, EventArgs e)
        {
            Delete_Service uc = new Delete_Service();
            AddUserControl(uc);
        }

        private void AdminPContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

