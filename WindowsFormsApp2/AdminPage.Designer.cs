namespace Assignment
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logobox = new System.Windows.Forms.PictureBox();
            this.Btn_StaffA = new System.Windows.Forms.Button();
            this.btn_addstaf = new System.Windows.Forms.Button();
            this.Btn_deletestaff = new System.Windows.Forms.Button();
            this.btn_ServiceInfo = new System.Windows.Forms.Button();
            this.Btn_AddService = new System.Windows.Forms.Button();
            this.Btn_EditService = new System.Windows.Forms.Button();
            this.Btn_DeleteService = new System.Windows.Forms.Button();
            this.btn_CustomerFeedback = new System.Windows.Forms.Button();
            this.btn_ServiceReports = new System.Windows.Forms.Button();
            this.btn_Adminlogout = new System.Windows.Forms.Button();
            this.AdminPContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logobox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.Logobox);
            this.panel1.Controls.Add(this.Btn_StaffA);
            this.panel1.Controls.Add(this.btn_addstaf);
            this.panel1.Controls.Add(this.Btn_deletestaff);
            this.panel1.Controls.Add(this.btn_ServiceInfo);
            this.panel1.Controls.Add(this.Btn_AddService);
            this.panel1.Controls.Add(this.Btn_EditService);
            this.panel1.Controls.Add(this.Btn_DeleteService);
            this.panel1.Controls.Add(this.btn_CustomerFeedback);
            this.panel1.Controls.Add(this.btn_ServiceReports);
            this.panel1.Controls.Add(this.btn_Adminlogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 1036);
            this.panel1.TabIndex = 0;
            // 
            // Logobox
            // 
            this.Logobox.BackColor = System.Drawing.SystemColors.Menu;
            this.Logobox.Image = global::WindowsFormsApp2.Properties.Resources.CarCare_Logo;
            this.Logobox.Location = new System.Drawing.Point(0, -7);
            this.Logobox.Name = "Logobox";
            this.Logobox.Size = new System.Drawing.Size(252, 223);
            this.Logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logobox.TabIndex = 8;
            this.Logobox.TabStop = false;
            // 
            // Btn_StaffA
            // 
            this.Btn_StaffA.Location = new System.Drawing.Point(0, 216);
            this.Btn_StaffA.Name = "Btn_StaffA";
            this.Btn_StaffA.Size = new System.Drawing.Size(252, 82);
            this.Btn_StaffA.TabIndex = 0;
            this.Btn_StaffA.Text = "Manage Staff";
            this.Btn_StaffA.UseVisualStyleBackColor = true;
            this.Btn_StaffA.MouseLeave += new System.EventHandler(this.BtnManageStaff_MouseLeave);
            this.Btn_StaffA.MouseHover += new System.EventHandler(this.BtnManageStaff_MouseHover);
            // 
            // btn_addstaf
            // 
            this.btn_addstaf.Location = new System.Drawing.Point(0, 298);
            this.btn_addstaf.Name = "btn_addstaf";
            this.btn_addstaf.Size = new System.Drawing.Size(252, 82);
            this.btn_addstaf.TabIndex = 5;
            this.btn_addstaf.Text = "Add Staff";
            this.btn_addstaf.UseVisualStyleBackColor = true;
            this.btn_addstaf.Click += new System.EventHandler(this.Btn_addstaf_Click);
            // 
            // Btn_deletestaff
            // 
            this.Btn_deletestaff.Location = new System.Drawing.Point(0, 380);
            this.Btn_deletestaff.Name = "Btn_deletestaff";
            this.Btn_deletestaff.Size = new System.Drawing.Size(252, 82);
            this.Btn_deletestaff.TabIndex = 7;
            this.Btn_deletestaff.Text = "Delete Staff";
            this.Btn_deletestaff.UseVisualStyleBackColor = true;
            this.Btn_deletestaff.Click += new System.EventHandler(this.Btn_deletestaff_Click);
            // 
            // btn_ServiceInfo
            // 
            this.btn_ServiceInfo.Location = new System.Drawing.Point(0, 462);
            this.btn_ServiceInfo.Name = "btn_ServiceInfo";
            this.btn_ServiceInfo.Size = new System.Drawing.Size(252, 82);
            this.btn_ServiceInfo.TabIndex = 4;
            this.btn_ServiceInfo.Text = "Manage Service Info";
            this.btn_ServiceInfo.UseVisualStyleBackColor = true;
            this.btn_ServiceInfo.MouseLeave += new System.EventHandler(this.BtnManageStaff_MouseLeave);
            // 
            // Btn_AddService
            // 
            this.Btn_AddService.Location = new System.Drawing.Point(0, 544);
            this.Btn_AddService.Name = "Btn_AddService";
            this.Btn_AddService.Size = new System.Drawing.Size(252, 82);
            this.Btn_AddService.TabIndex = 1;
            this.Btn_AddService.Text = "Add Services";
            this.Btn_AddService.UseVisualStyleBackColor = true;
            this.Btn_AddService.Click += new System.EventHandler(this.Btn_AddService_Click);
            // 
            // Btn_EditService
            // 
            this.Btn_EditService.Location = new System.Drawing.Point(0, 626);
            this.Btn_EditService.Name = "Btn_EditService";
            this.Btn_EditService.Size = new System.Drawing.Size(252, 82);
            this.Btn_EditService.TabIndex = 6;
            this.Btn_EditService.Text = "Edit Services";
            this.Btn_EditService.UseVisualStyleBackColor = true;
            this.Btn_EditService.Click += new System.EventHandler(this.Btn_EditService_Click);
            // 
            // Btn_DeleteService
            // 
            this.Btn_DeleteService.Location = new System.Drawing.Point(0, 708);
            this.Btn_DeleteService.Name = "Btn_DeleteService";
            this.Btn_DeleteService.Size = new System.Drawing.Size(252, 82);
            this.Btn_DeleteService.TabIndex = 7;
            this.Btn_DeleteService.Text = "Delete Services";
            this.Btn_DeleteService.UseVisualStyleBackColor = true;
            this.Btn_DeleteService.Click += new System.EventHandler(this.Btn_DeleteService_Click);
            // 
            // btn_CustomerFeedback
            // 
            this.btn_CustomerFeedback.Location = new System.Drawing.Point(0, 790);
            this.btn_CustomerFeedback.Name = "btn_CustomerFeedback";
            this.btn_CustomerFeedback.Size = new System.Drawing.Size(252, 82);
            this.btn_CustomerFeedback.TabIndex = 3;
            this.btn_CustomerFeedback.Text = "View Customer Feedback";
            this.btn_CustomerFeedback.UseVisualStyleBackColor = true;
            // 
            // btn_ServiceReports
            // 
            this.btn_ServiceReports.Location = new System.Drawing.Point(0, 872);
            this.btn_ServiceReports.Name = "btn_ServiceReports";
            this.btn_ServiceReports.Size = new System.Drawing.Size(252, 82);
            this.btn_ServiceReports.TabIndex = 2;
            this.btn_ServiceReports.Text = "View Service Reports";
            this.btn_ServiceReports.UseVisualStyleBackColor = true;
            // 
            // btn_Adminlogout
            // 
            this.btn_Adminlogout.Location = new System.Drawing.Point(0, 954);
            this.btn_Adminlogout.Name = "btn_Adminlogout";
            this.btn_Adminlogout.Size = new System.Drawing.Size(252, 82);
            this.btn_Adminlogout.TabIndex = 6;
            this.btn_Adminlogout.Text = "Log Out";
            this.btn_Adminlogout.UseVisualStyleBackColor = true;
            // 
            // AdminPContainer
            // 
            this.AdminPContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPContainer.Location = new System.Drawing.Point(252, 0);
            this.AdminPContainer.Margin = new System.Windows.Forms.Padding(6);
            this.AdminPContainer.Name = "AdminPContainer";
            this.AdminPContainer.Size = new System.Drawing.Size(1500, 1036);
            this.AdminPContainer.TabIndex = 1;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 1036);
            this.Controls.Add(this.AdminPContainer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPageLoad);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logobox;
        private System.Windows.Forms.Button Btn_StaffA;
        private System.Windows.Forms.Button Btn_deletestaff;
        private System.Windows.Forms.Button Btn_AddService;
        private System.Windows.Forms.Button btn_addstaf;
        private System.Windows.Forms.Button Btn_DeleteService;
        private System.Windows.Forms.Button btn_ServiceInfo;
        private System.Windows.Forms.Button btn_ServiceReports;
        private System.Windows.Forms.Button Btn_EditService;
        private System.Windows.Forms.Button btn_Adminlogout;
        private System.Windows.Forms.Button btn_CustomerFeedback;
        private System.Windows.Forms.Panel AdminPContainer;
    }
}