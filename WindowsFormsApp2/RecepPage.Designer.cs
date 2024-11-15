namespace Assignment
{
    partial class RecepPage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProfBtn = new System.Windows.Forms.Button();
            this.InvButton = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.ServBtn = new System.Windows.Forms.Button();
            this.DelCust = new System.Windows.Forms.Button();
            this.AddCust = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 511);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.ProfBtn);
            this.panel2.Controls.Add(this.InvButton);
            this.panel2.Controls.Add(this.CheckBtn);
            this.panel2.Controls.Add(this.ServBtn);
            this.panel2.Controls.Add(this.DelCust);
            this.panel2.Controls.Add(this.AddCust);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 511);
            this.panel2.TabIndex = 0;
            // 
            // ProfBtn
            // 
            this.ProfBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfBtn.Location = new System.Drawing.Point(0, 370);
            this.ProfBtn.Name = "ProfBtn";
            this.ProfBtn.Size = new System.Drawing.Size(151, 41);
            this.ProfBtn.TabIndex = 17;
            this.ProfBtn.Text = "Profile";
            this.ProfBtn.UseVisualStyleBackColor = true;
            this.ProfBtn.Click += new System.EventHandler(this.ProfBtn_Click);
            // 
            // InvButton
            // 
            this.InvButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InvButton.Location = new System.Drawing.Point(0, 329);
            this.InvButton.Name = "InvButton";
            this.InvButton.Size = new System.Drawing.Size(151, 41);
            this.InvButton.TabIndex = 16;
            this.InvButton.Text = "View Inventory";
            this.InvButton.UseVisualStyleBackColor = true;
            this.InvButton.Click += new System.EventHandler(this.InvButton_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckBtn.Location = new System.Drawing.Point(0, 288);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(151, 41);
            this.CheckBtn.TabIndex = 15;
            this.CheckBtn.Text = "Check In / Out";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // ServBtn
            // 
            this.ServBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServBtn.Location = new System.Drawing.Point(0, 247);
            this.ServBtn.Name = "ServBtn";
            this.ServBtn.Size = new System.Drawing.Size(151, 41);
            this.ServBtn.TabIndex = 14;
            this.ServBtn.Text = "Service Appointment";
            this.ServBtn.UseVisualStyleBackColor = true;
            this.ServBtn.Click += new System.EventHandler(this.ServBtn_Click);
            // 
            // DelCust
            // 
            this.DelCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.DelCust.Location = new System.Drawing.Point(0, 218);
            this.DelCust.Name = "DelCust";
            this.DelCust.Size = new System.Drawing.Size(151, 29);
            this.DelCust.TabIndex = 13;
            this.DelCust.Text = "Delete";
            this.DelCust.UseVisualStyleBackColor = true;
            this.DelCust.Click += new System.EventHandler(this.DelCust_Click);
            this.DelCust.MouseLeave += new System.EventHandler(this.DelBtnLeave);
            this.DelCust.MouseHover += new System.EventHandler(this.DelCust_Hover);
            // 
            // AddCust
            // 
            this.AddCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCust.Location = new System.Drawing.Point(0, 189);
            this.AddCust.Name = "AddCust";
            this.AddCust.Size = new System.Drawing.Size(151, 29);
            this.AddCust.TabIndex = 12;
            this.AddCust.Text = "Add";
            this.AddCust.UseVisualStyleBackColor = true;
            this.AddCust.Click += new System.EventHandler(this.AddCust_Click);
            this.AddCust.MouseLeave += new System.EventHandler(this.AddBtnLeave);
            this.AddCust.MouseHover += new System.EventHandler(this.AddCust_Hover);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Customer Management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Assignment.Properties.Resources.CarCare_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.Location = new System.Drawing.Point(0, 470);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(151, 41);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(151, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(642, 511);
            this.ControlPanel.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // RecepPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(793, 511);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecepPage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button ProfBtn;
        private System.Windows.Forms.Button InvButton;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button ServBtn;
        private System.Windows.Forms.Button DelCust;
        private System.Windows.Forms.Button AddCust;
        private System.Windows.Forms.Button button1;
    }
}

