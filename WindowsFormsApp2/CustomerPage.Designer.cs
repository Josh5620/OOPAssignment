namespace Assignment
{
    partial class CustomerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPage));
            this.Buttonspanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.btnManageAppointments = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnViewServices = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homePage1 = new Assignment.HomePage();
            this.feedback2 = new Assignment.Feedback();
            this.updateProfile2 = new Assignment.UpdateProfile();
            this.manageAppointments2 = new Assignment.ManageAppointments();
            this.viewservices2 = new Assignment.Viewservices();
            this.Buttonspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buttonspanel
            // 
            this.Buttonspanel.BackColor = System.Drawing.SystemColors.Control;
            this.Buttonspanel.Controls.Add(this.btnExit);
            this.Buttonspanel.Controls.Add(this.btnSendFeedback);
            this.Buttonspanel.Controls.Add(this.btnManageAppointments);
            this.Buttonspanel.Controls.Add(this.btnUpdateProfile);
            this.Buttonspanel.Controls.Add(this.btnViewServices);
            this.Buttonspanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Buttonspanel.Location = new System.Drawing.Point(0, 0);
            this.Buttonspanel.Name = "Buttonspanel";
            this.Buttonspanel.Size = new System.Drawing.Size(184, 506);
            this.Buttonspanel.TabIndex = 0;
            this.Buttonspanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 51);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.Location = new System.Drawing.Point(0, 297);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(184, 51);
            this.btnSendFeedback.TabIndex = 6;
            this.btnSendFeedback.Text = "Submit feedback";
            this.btnSendFeedback.UseVisualStyleBackColor = true;
            this.btnSendFeedback.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManageAppointments
            // 
            this.btnManageAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAppointments.Location = new System.Drawing.Point(0, 181);
            this.btnManageAppointments.Name = "btnManageAppointments";
            this.btnManageAppointments.Size = new System.Drawing.Size(184, 53);
            this.btnManageAppointments.TabIndex = 5;
            this.btnManageAppointments.Text = "Manage Appointments ";
            this.btnManageAppointments.UseVisualStyleBackColor = true;
            this.btnManageAppointments.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(0, 240);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(184, 51);
            this.btnUpdateProfile.TabIndex = 4;
            this.btnUpdateProfile.Text = "Update Profile ";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewServices
            // 
            this.btnViewServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewServices.Location = new System.Drawing.Point(0, 118);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(184, 57);
            this.btnViewServices.TabIndex = 2;
            this.btnViewServices.Text = "View Services ";
            this.btnViewServices.UseVisualStyleBackColor = true;
            this.btnViewServices.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.homePage1);
            this.panel2.Controls.Add(this.feedback2);
            this.panel2.Controls.Add(this.updateProfile2);
            this.panel2.Controls.Add(this.manageAppointments2);
            this.panel2.Controls.Add(this.viewservices2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 506);
            this.panel2.TabIndex = 2;
            // 
            // homePage1
            // 
            this.homePage1.Location = new System.Drawing.Point(6, 0);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(829, 506);
            this.homePage1.TabIndex = 4;
            // 
            // feedback2
            // 
            this.feedback2.Location = new System.Drawing.Point(0, 0);
            this.feedback2.Name = "feedback2";
            this.feedback2.Size = new System.Drawing.Size(835, 506);
            this.feedback2.TabIndex = 3;
            this.feedback2.Load += new System.EventHandler(this.feedback2_Load);
            // 
            // updateProfile2
            // 
            this.updateProfile2.Location = new System.Drawing.Point(3, 4);
            this.updateProfile2.Name = "updateProfile2";
            this.updateProfile2.Size = new System.Drawing.Size(832, 502);
            this.updateProfile2.TabIndex = 2;
            // 
            // manageAppointments2
            // 
            this.manageAppointments2.Location = new System.Drawing.Point(3, 4);
            this.manageAppointments2.Name = "manageAppointments2";
            this.manageAppointments2.Size = new System.Drawing.Size(832, 502);
            this.manageAppointments2.TabIndex = 1;
            // 
            // viewservices2
            // 
            this.viewservices2.Location = new System.Drawing.Point(6, 0);
            this.viewservices2.Name = "viewservices2";
            this.viewservices2.Size = new System.Drawing.Size(829, 503);
            this.viewservices2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Buttonspanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Buttonspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Buttonspanel;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnManageAppointments;
        private System.Windows.Forms.Button btnViewServices;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private ManageAppointments manageAppointments2;
        private Viewservices viewservices2;
        private Feedback feedback2;
        private UpdateProfile updateProfile2;
        private HomePage homePage1;
    }
}

