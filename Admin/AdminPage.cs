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
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPageLoad(object sender, EventArgs e)
        {
            btn_addstaf.Visible = false;
            Btn_deletestaff.Visible = false;

            btn_ServiceInfo.Top = Btn_StaffA.Bottom + 10;
            btn_CustomerFeed.Top = btn_ServiceInfo.Bottom + 10;
            btn_ServiceReport.Top = btn_CustomerFeed.Bottom + 10;
            btn_Adminlogout.Top = btn_ServiceReport.Bottom + 10;
        }


        // Add the MouseEnter event to the "Manage Staff" button
        private void BtnManageStaff_MouseEnter(object sender, EventArgs e)
        {
            btn_addstaf.Visible = true;
            Btn_deletestaff.Visible = true;

            btn_addstaf.Top = Btn_StaffA.Bottom + 1;
            Btn_deletestaff.Top = btn_addstaf.Bottom + 1;

            btn_ServiceInfo.Top = Btn_deletestaff.Bottom + 3;
            btn_CustomerFeed.Top = btn_ServiceInfo.Bottom + 3;
            btn_ServiceReport.Top = btn_CustomerFeed.Bottom + 3;
            btn_Adminlogout.Top = btn_ServiceReport.Bottom + 2;

        }

        // Add the MouseLeave event to hide the buttons when not hovering
        private void BtnManageStaff_MouseLeave(object sender, EventArgs e)
        {
            if (!btn_addstaf.ClientRectangle.Contains(btn_addstaf.PointToClient(Cursor.Position)) &&
                !Btn_deletestaff.ClientRectangle.Contains(Btn_deletestaff.PointToClient(Cursor.Position)))
            {
                btn_addstaf.Visible = false;
                Btn_deletestaff.Visible = false;

                btn_ServiceInfo.Top = Btn_StaffA.Bottom + 10;
                btn_CustomerFeed.Top = btn_ServiceInfo.Bottom + 10;
                btn_ServiceReport.Top = btn_CustomerFeed.Bottom + 10;
                btn_Adminlogout.Top = btn_ServiceReport.Bottom + 10;
            }
        }



        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AdminPContainer.Controls.Clear();
            AdminPContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Btn_StaffA_Click(object sender, EventArgs e)
        {

        }

        private void Btn_addstaf_Click(object sender, EventArgs e)
        {
            Add_Staff uc = new Add_Staff();
            AddUserControl(uc);
        }

        private void Btn_deletestaff_Click(object sender, EventArgs e)
        {
            DeleteStaff uc = new DeleteStaff();
            AddUserControl(uc); 
        }

        private void btn_CustomerFeed_Click(object sender, EventArgs e)
        {

        }

        private void btn_ServiceReport_Click(object sender, EventArgs e)
        {

        }

        private void btn_Adminlogout_Click(object sender, EventArgs e)
        {

        }
    }
}
