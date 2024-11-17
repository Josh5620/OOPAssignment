namespace Assignment
{
    partial class Viewservices
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
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.btnViewServices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(48, 17);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.Size = new System.Drawing.Size(668, 310);
            this.dataGridViewServices.TabIndex = 0;
            this.dataGridViewServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnViewServices
            // 
            this.btnViewServices.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewServices.Location = new System.Drawing.Point(175, 447);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(120, 36);
            this.btnViewServices.TabIndex = 1;
            this.btnViewServices.Text = "View ";
            this.btnViewServices.UseVisualStyleBackColor = false;
            this.btnViewServices.Click += new System.EventHandler(this.btnViewServices_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Service:";
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(146, 375);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(121, 24);
            this.comboBoxServices.TabIndex = 4;
            this.comboBoxServices.SelectedIndexChanged += new System.EventHandler(this.comboBoxServices_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select a Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Make an Appointment";
            // 
            // dateTimePickerAppointment
            // 
            this.dateTimePickerAppointment.Location = new System.Drawing.Point(523, 398);
            this.dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            this.dateTimePickerAppointment.Size = new System.Drawing.Size(165, 22);
            this.dateTimePickerAppointment.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Date:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(523, 369);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Your Name:";
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(388, 443);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(118, 42);
            this.btnSchedule.TabIndex = 11;
            this.btnSchedule.Text = "Book";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // Viewservices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxServices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewServices);
            this.Controls.Add(this.dataGridViewServices);
            this.Name = "Viewservices";
            this.Size = new System.Drawing.Size(750, 499);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Button btnViewServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSchedule;
    }
}
