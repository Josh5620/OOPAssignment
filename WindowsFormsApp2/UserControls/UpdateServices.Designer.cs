namespace Assignment.UserControls
{
    partial class UpdateServices
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridView321 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.MaskedTextBox();
            this.txtServiceId = new System.Windows.Forms.MaskedTextBox();
            this.txtAdditionalNotes = new System.Windows.Forms.MaskedTextBox();
            this.txtAppointmentDate = new System.Windows.Forms.MaskedTextBox();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView321)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridView321);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 306);
            this.panel1.TabIndex = 1;
            // 
            // DataGridView321
            // 
            this.DataGridView321.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView321.Location = new System.Drawing.Point(0, 2);
            this.DataGridView321.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView321.Name = "DataGridView321";
            this.DataGridView321.RowHeadersWidth = 82;
            this.DataGridView321.RowTemplate.Height = 33;
            this.DataGridView321.Size = new System.Drawing.Size(638, 300);
            this.DataGridView321.TabIndex = 0;
            this.DataGridView321.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView321_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FullName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CustomerID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ServiceID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "AppointmentDate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "VehichleNum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 404);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "AdditionalNotes:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(101, 335);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(114, 20);
            this.txtFullName.TabIndex = 11;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(101, 370);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(114, 20);
            this.txtCustomerId.TabIndex = 12;
            // 
            // txtServiceId
            // 
            this.txtServiceId.Location = new System.Drawing.Point(101, 404);
            this.txtServiceId.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.Size = new System.Drawing.Size(114, 20);
            this.txtServiceId.TabIndex = 13;
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Location = new System.Drawing.Point(317, 401);
            this.txtAdditionalNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.Size = new System.Drawing.Size(120, 20);
            this.txtAdditionalNotes.TabIndex = 16;
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Location = new System.Drawing.Point(317, 370);
            this.txtAppointmentDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(120, 20);
            this.txtAppointmentDate.TabIndex = 15;
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.Location = new System.Drawing.Point(317, 335);
            this.txtVehicleNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(120, 20);
            this.txtVehicleNumber.TabIndex = 14;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(498, 335);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(120, 20);
            this.txtStatus.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 27);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UpdateServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtAdditionalNotes);
            this.Controls.Add(this.txtAppointmentDate);
            this.Controls.Add(this.txtVehicleNumber);
            this.Controls.Add(this.txtServiceId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateServices";
            this.Size = new System.Drawing.Size(642, 511);
            this.Load += new System.EventHandler(this.UpdateServices_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView321)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView321;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.MaskedTextBox txtCustomerId;
        private System.Windows.Forms.MaskedTextBox txtServiceId;
        private System.Windows.Forms.MaskedTextBox txtAdditionalNotes;
        private System.Windows.Forms.MaskedTextBox txtAppointmentDate;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
