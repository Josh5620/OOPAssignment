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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(43, 21);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.Size = new System.Drawing.Size(668, 336);
            this.dataGridViewServices.TabIndex = 0;
            this.dataGridViewServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnViewServices
            // 
            this.btnViewServices.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewServices.Location = new System.Drawing.Point(303, 419);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(120, 36);
            this.btnViewServices.TabIndex = 1;
            this.btnViewServices.Text = "View ";
            this.btnViewServices.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Service:";
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(148, 378);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(121, 24);
            this.comboBoxServices.TabIndex = 4;
            this.comboBoxServices.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Viewservices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxServices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewServices);
            this.Controls.Add(this.dataGridViewServices);
            this.Name = "Viewservices";
            this.Size = new System.Drawing.Size(750, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Button btnViewServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxServices;
    }
}
