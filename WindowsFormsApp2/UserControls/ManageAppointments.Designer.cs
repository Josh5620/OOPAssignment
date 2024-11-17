namespace Assignment
{
    partial class ManageAppointments
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.btnViewAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAppointmentId = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxAppointments = new System.Windows.Forms.ComboBox();
            this.buttonCancelAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(16, 13);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersWidth = 51;
            this.dataGridViewAppointments.RowTemplate.Height = 24;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(722, 214);
            this.dataGridViewAppointments.TabIndex = 0;
            // 
            // btnViewAppointment
            // 
            this.btnViewAppointment.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAppointment.Location = new System.Drawing.Point(114, 415);
            this.btnViewAppointment.Name = "btnViewAppointment";
            this.btnViewAppointment.Size = new System.Drawing.Size(111, 42);
            this.btnViewAppointment.TabIndex = 2;
            this.btnViewAppointment.Text = "View ";
            this.btnViewAppointment.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Appoinntements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Date and Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Select A Service:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(212, 269);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 367);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enter Appointment Id:";
            // 
            // textBoxAppointmentId
            // 
            this.textBoxAppointmentId.Location = new System.Drawing.Point(212, 330);
            this.textBoxAppointmentId.Name = "textBoxAppointmentId";
            this.textBoxAppointmentId.Size = new System.Drawing.Size(100, 22);
            this.textBoxAppointmentId.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxAppointments
            // 
            this.comboBoxAppointments.FormattingEnabled = true;
            this.comboBoxAppointments.Location = new System.Drawing.Point(212, 301);
            this.comboBoxAppointments.Name = "comboBoxAppointments";
            this.comboBoxAppointments.Size = new System.Drawing.Size(100, 24);
            this.comboBoxAppointments.TabIndex = 15;
            this.comboBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppointments_SelectedIndexChanged);
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAppointment.Location = new System.Drawing.Point(481, 415);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(98, 42);
            this.buttonCancelAppointment.TabIndex = 16;
            this.buttonCancelAppointment.Text = "Cancel";
            this.buttonCancelAppointment.UseVisualStyleBackColor = false;
            this.buttonCancelAppointment.Click += new System.EventHandler(this.buttonCancelAppointment_Click);
            // 
            // ManageAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelAppointment);
            this.Controls.Add(this.comboBoxAppointments);
            this.Controls.Add(this.textBoxAppointmentId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewAppointment);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Name = "ManageAppointments";
            this.Size = new System.Drawing.Size(754, 531);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btnViewAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAppointmentId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxAppointments;
        private System.Windows.Forms.Button buttonCancelAppointment;
    }
}
