﻿namespace Assignment
{
    partial class Delete_Service
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
            this.ServiceDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_deleteservice = new System.Windows.Forms.Button();
            this.ServiceIdBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceDataGrid
            // 
            this.ServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDataGrid.Location = new System.Drawing.Point(43, 62);
            this.ServiceDataGrid.Name = "ServiceDataGrid";
            this.ServiceDataGrid.RowHeadersWidth = 82;
            this.ServiceDataGrid.RowTemplate.Height = 33;
            this.ServiceDataGrid.Size = new System.Drawing.Size(1193, 552);
            this.ServiceDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 720);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "ServiceID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 658);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 720);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Delete Selected Record:";
            // 
            // Btn_deleteservice
            // 
            this.Btn_deleteservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_deleteservice.Location = new System.Drawing.Point(1068, 707);
            this.Btn_deleteservice.Name = "Btn_deleteservice";
            this.Btn_deleteservice.Size = new System.Drawing.Size(181, 59);
            this.Btn_deleteservice.TabIndex = 5;
            this.Btn_deleteservice.Text = "Delete";
            this.Btn_deleteservice.UseVisualStyleBackColor = true;
            this.Btn_deleteservice.Click += new System.EventHandler(this.Btn_deleteservice_Click);
            // 
            // ServiceIdBox
            // 
            this.ServiceIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceIdBox.Location = new System.Drawing.Point(258, 720);
            this.ServiceIdBox.Name = "ServiceIdBox";
            this.ServiceIdBox.Size = new System.Drawing.Size(220, 40);
            this.ServiceIdBox.TabIndex = 6;
            // 
            // Delete_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServiceIdBox);
            this.Controls.Add(this.Btn_deleteservice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceDataGrid);
            this.Name = "Delete_Service";
            this.Size = new System.Drawing.Size(1307, 902);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ServiceDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_deleteservice;
        private System.Windows.Forms.TextBox ServiceIdBox;
    }
}
