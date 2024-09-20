﻿namespace WindowsFormsApp2
{
    partial class RecepForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ProfBtn = new System.Windows.Forms.Button();
            this.InvButton = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.ServBtn = new System.Windows.Forms.Button();
            this.DelCust = new System.Windows.Forms.Button();
            this.AddCust = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 595);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.ProfBtn);
            this.panel2.Controls.Add(this.InvButton);
            this.panel2.Controls.Add(this.CheckBtn);
            this.panel2.Controls.Add(this.ServBtn);
            this.panel2.Controls.Add(this.DelCust);
            this.panel2.Controls.Add(this.AddCust);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 595);
            this.panel2.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.Location = new System.Drawing.Point(0, 545);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(201, 50);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ProfBtn
            // 
            this.ProfBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfBtn.Location = new System.Drawing.Point(0, 272);
            this.ProfBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProfBtn.Name = "ProfBtn";
            this.ProfBtn.Size = new System.Drawing.Size(201, 50);
            this.ProfBtn.TabIndex = 8;
            this.ProfBtn.Text = "Profile";
            this.ProfBtn.UseVisualStyleBackColor = true;
            this.ProfBtn.Click += new System.EventHandler(this.ProfBtn_Click);
            // 
            // InvButton
            // 
            this.InvButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InvButton.Location = new System.Drawing.Point(0, 222);
            this.InvButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InvButton.Name = "InvButton";
            this.InvButton.Size = new System.Drawing.Size(201, 50);
            this.InvButton.TabIndex = 7;
            this.InvButton.Text = "View Inventory";
            this.InvButton.UseVisualStyleBackColor = true;
            this.InvButton.Click += new System.EventHandler(this.InvButton_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckBtn.Location = new System.Drawing.Point(0, 172);
            this.CheckBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(201, 50);
            this.CheckBtn.TabIndex = 5;
            this.CheckBtn.Text = "Check In / Out";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // ServBtn
            // 
            this.ServBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServBtn.Location = new System.Drawing.Point(0, 122);
            this.ServBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServBtn.Name = "ServBtn";
            this.ServBtn.Size = new System.Drawing.Size(201, 50);
            this.ServBtn.TabIndex = 4;
            this.ServBtn.Text = "Service Appointment";
            this.ServBtn.UseVisualStyleBackColor = true;
            this.ServBtn.Click += new System.EventHandler(this.ServBtn_Click);
            // 
            // DelCust
            // 
            this.DelCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.DelCust.Location = new System.Drawing.Point(0, 86);
            this.DelCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelCust.Name = "DelCust";
            this.DelCust.Size = new System.Drawing.Size(201, 36);
            this.DelCust.TabIndex = 3;
            this.DelCust.Text = "Delete";
            this.DelCust.UseVisualStyleBackColor = true;
            this.DelCust.Click += new System.EventHandler(this.DelCust_Click);
            this.DelCust.MouseLeave += new System.EventHandler(this.DelBtnLeave);
            this.DelCust.MouseHover += new System.EventHandler(this.DelCust_Hover);
            // 
            // AddCust
            // 
            this.AddCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCust.Location = new System.Drawing.Point(0, 50);
            this.AddCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCust.Name = "AddCust";
            this.AddCust.Size = new System.Drawing.Size(201, 36);
            this.AddCust.TabIndex = 2;
            this.AddCust.Text = "Add";
            this.AddCust.UseVisualStyleBackColor = true;
            this.AddCust.Click += new System.EventHandler(this.AddCust_Click);
            this.AddCust.MouseLeave += new System.EventHandler(this.AddBtnLeave);
            this.AddCust.MouseHover += new System.EventHandler(this.AddCust_Hover);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Customer Management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.listBox1);
            this.ControlPanel.Controls.Add(this.button2);
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(201, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(848, 595);
            this.ControlPanel.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(189, 379);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(488, 116);
            this.listBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand Logo Image here";
            // 
            // RecepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1057, 629);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecepForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddCust;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DelCust;
        private System.Windows.Forms.Button ServBtn;
        private System.Windows.Forms.Button ProfBtn;
        private System.Windows.Forms.Button InvButton;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

