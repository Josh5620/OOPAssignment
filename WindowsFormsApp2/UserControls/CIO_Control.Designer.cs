namespace Assignment.UserControls
{
    partial class CIO_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BillBtn = new System.Windows.Forms.Button();
            this.UptBtn = new System.Windows.Forms.Button();
            this.CncBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            ""});
            this.listBox1.Location = new System.Drawing.Point(56, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 196);
            this.listBox1.TabIndex = 2;

            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listBox2.Location = new System.Drawing.Point(342, 90);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(209, 196);
            this.listBox2.TabIndex = 3;

            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listBox3.Location = new System.Drawing.Point(613, 90);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(209, 196);
            this.listBox3.TabIndex = 4;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arriving";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arrived / Servicing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Completed ";
            // 
            // BillBtn
            // 
            this.BillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillBtn.Location = new System.Drawing.Point(613, 313);
            this.BillBtn.Name = "BillBtn";
            this.BillBtn.Size = new System.Drawing.Size(155, 27);
            this.BillBtn.TabIndex = 8;
            this.BillBtn.Text = "Generate Bill";
            this.BillBtn.UseVisualStyleBackColor = true;
            this.BillBtn.Click += new System.EventHandler(this.BillBtn_Click);
            // 
            // UptBtn
            // 
            this.UptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UptBtn.Location = new System.Drawing.Point(56, 313);
            this.UptBtn.Name = "UptBtn";
            this.UptBtn.Size = new System.Drawing.Size(155, 27);
            this.UptBtn.TabIndex = 9;
            this.UptBtn.Text = "Update";
            this.UptBtn.UseVisualStyleBackColor = true;
            this.UptBtn.Click += new System.EventHandler(this.UptBtn_Click);
            // 
            // CncBtn
            // 
            this.CncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CncBtn.Location = new System.Drawing.Point(56, 431);
            this.CncBtn.Name = "CncBtn";
            this.CncBtn.Size = new System.Drawing.Size(155, 27);
            this.CncBtn.TabIndex = 10;
            this.CncBtn.Text = "Cancel Order";
            this.CncBtn.UseVisualStyleBackColor = true;
            this.CncBtn.Click += new System.EventHandler(this.CncBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBtn.Location = new System.Drawing.Point(56, 369);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(155, 27);
            this.InfoBtn.TabIndex = 11;
            this.InfoBtn.Text = "View Info";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(276, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 296);
            this.panel1.TabIndex = 12;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(17, 39);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(269, 244);
            this.listBox4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill:";
            // 
            // PayBtn
            // 
            this.PayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.Location = new System.Drawing.Point(613, 369);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(155, 27);
            this.PayBtn.TabIndex = 13;
            this.PayBtn.Text = "Process Payment";
            this.PayBtn.UseVisualStyleBackColor = true;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // CIO_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.CncBtn);
            this.Controls.Add(this.UptBtn);
            this.Controls.Add(this.BillBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "CIO_Control";
            this.Size = new System.Drawing.Size(856, 629);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BillBtn;
        private System.Windows.Forms.Button UptBtn;
        private System.Windows.Forms.Button CncBtn;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button PayBtn;
    }
}
