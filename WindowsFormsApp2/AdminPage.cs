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
            HideSubButtons();
            PositionMainButtons();
        }

        // Hide all sub-buttons (you can call this when needed)
        private void HideSubButtons()
        {
            btn_addstaf.Visible = false;
            Btn_deletestaff.Visible = false;
            Btn_AddService.Visible = false;
            Btn_EditService.Visible = false;
            Btn_DeleteService.Visible = false;
        }

        // Dynamically position the main buttons
        private void PositionMainButtons()
        {
            btn_ServiceInfo.Top = Btn_StaffA.Bottom + 10;
            btn_CustomerFeed.Top = btn_ServiceInfo.Bottom + 10;
            btn_ServiceReport.Top = btn_CustomerFeed.Bottom + 10;
            btn_Adminlogout.Top = btn_ServiceReport.Bottom + 10;
        }

        // Generic method to handle hover events and position sub-buttons
        private void ShowSubButtons(Control mainButton, params Control[] subButtons)
        {
            // Set visibility of sub-buttons to true
            foreach (Control subButton in subButtons)
            {
                subButton.Visible = true;
            }

            // Position the sub-buttons below the main button
            for (int i = 0; i < subButtons.Length; i++)
            {
                if (i == 0)
                    subButtons[i].Top = mainButton.Bottom + 1;
                else
                    subButtons[i].Top = subButtons[i - 1].Bottom + 1;
            }

            // Position the remaining main buttons after the last sub-button
            PositionMainButtons();
        }

        // Generic method to hide sub-buttons on mouse leave
        private void HideSubButtonsOnLeave(params Control[] subButtons)
        {
            foreach (Control subButton in subButtons)
            {
                if (subButton.ClientRectangle.Contains(subButton.PointToClient(Cursor.Position)))
                    return;
            }
            HideSubButtons();
            PositionMainButtons();
        }

        // Manage Staff hover event
        private void BtnManageStaff_MouseEnter(object sender, EventArgs e)
        {
            ShowSubButtons(Btn_StaffA, btn_addstaf, Btn_deletestaff);
        }

        private void BtnManageStaff_MouseLeave(object sender, EventArgs e)
        {
            HideSubButtonsOnLeave(btn_addstaf, Btn_deletestaff);
        }

        // Manage Service Info hover event
        private void BtnManageServiceInfo_MouseEnter(object sender, EventArgs e)
        {
            ShowSubButtons(btn_ServiceInfo, Btn_AddService, Btn_EditService, Btn_DeleteService);
        }

        private void BtnManageServiceInfo_MouseLeave(object sender, EventArgs e)
        {
            HideSubButtonsOnLeave(Btn_AddService, Btn_EditService, Btn_DeleteService);
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
