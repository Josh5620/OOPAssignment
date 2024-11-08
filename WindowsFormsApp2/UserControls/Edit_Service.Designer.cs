namespace Assignment
{
    partial class Edit_Service
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
            this.ServiceIdBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.EstimatedTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_UpdateService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceDataGrid
            // 
            this.ServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDataGrid.Location = new System.Drawing.Point(59, 54);
            this.ServiceDataGrid.Name = "ServiceDataGrid";
            this.ServiceDataGrid.RowHeadersWidth = 82;
            this.ServiceDataGrid.RowTemplate.Height = 33;
            this.ServiceDataGrid.Size = new System.Drawing.Size(1151, 539);
            this.ServiceDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 691);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "ServiceID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menu:";
            // 
            // ServiceIdBox
            // 
            this.ServiceIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceIdBox.Location = new System.Drawing.Point(242, 691);
            this.ServiceIdBox.Name = "ServiceIdBox";
            this.ServiceIdBox.Size = new System.Drawing.Size(220, 40);
            this.ServiceIdBox.TabIndex = 7;
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(242, 763);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(220, 40);
            this.PriceBox.TabIndex = 8;
            // 
            // EstimatedTBox
            // 
            this.EstimatedTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimatedTBox.Location = new System.Drawing.Point(299, 834);
            this.EstimatedTBox.Name = "EstimatedTBox";
            this.EstimatedTBox.Size = new System.Drawing.Size(220, 40);
            this.EstimatedTBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 763);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 834);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estimated Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 691);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Update selected record:";
            // 
            // Btn_UpdateService
            // 
            this.Btn_UpdateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdateService.Location = new System.Drawing.Point(1078, 668);
            this.Btn_UpdateService.Name = "Btn_UpdateService";
            this.Btn_UpdateService.Size = new System.Drawing.Size(168, 63);
            this.Btn_UpdateService.TabIndex = 13;
            this.Btn_UpdateService.Text = "Update";
            this.Btn_UpdateService.UseVisualStyleBackColor = true;
            this.Btn_UpdateService.Click += new System.EventHandler(this.Btn_UpdateService_Click);
            // 
            // Edit_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_UpdateService);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EstimatedTBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.ServiceIdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceDataGrid);
            this.Name = "Edit_Service";
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
        private System.Windows.Forms.TextBox ServiceIdBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox EstimatedTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_UpdateService;
    }
}
