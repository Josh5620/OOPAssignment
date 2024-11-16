namespace Assignment
{
    partial class Add_Service
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
            this.ServiceNBox = new System.Windows.Forms.TextBox();
            this.ServiceDataGrid = new System.Windows.Forms.DataGridView();
            this.DescrpBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.EstitmatedTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_AddService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceNBox
            // 
            this.ServiceNBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceNBox.Location = new System.Drawing.Point(324, 591);
            this.ServiceNBox.Name = "ServiceNBox";
            this.ServiceNBox.Size = new System.Drawing.Size(190, 44);
            this.ServiceNBox.TabIndex = 0;
            // 
            // ServiceDataGrid
            // 
            this.ServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDataGrid.Location = new System.Drawing.Point(20, 22);
            this.ServiceDataGrid.Name = "ServiceDataGrid";
            this.ServiceDataGrid.RowHeadersWidth = 82;
            this.ServiceDataGrid.RowTemplate.Height = 33;
            this.ServiceDataGrid.Size = new System.Drawing.Size(1130, 563);
            this.ServiceDataGrid.TabIndex = 1;
            // 
            // DescrpBox
            // 
            this.DescrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescrpBox.Location = new System.Drawing.Point(324, 660);
            this.DescrpBox.Name = "DescrpBox";
            this.DescrpBox.Size = new System.Drawing.Size(190, 44);
            this.DescrpBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Service Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(324, 737);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(190, 44);
            this.PriceBox.TabIndex = 5;
            // 
            // EstitmatedTBox
            // 
            this.EstitmatedTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstitmatedTBox.Location = new System.Drawing.Point(324, 824);
            this.EstitmatedTBox.Name = "EstitmatedTBox";
            this.EstitmatedTBox.Size = new System.Drawing.Size(190, 44);
            this.EstitmatedTBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 740);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 824);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estimated Time:";
            // 
            // Btn_AddService
            // 
            this.Btn_AddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddService.Location = new System.Drawing.Point(800, 663);
            this.Btn_AddService.Name = "Btn_AddService";
            this.Btn_AddService.Size = new System.Drawing.Size(272, 89);
            this.Btn_AddService.TabIndex = 9;
            this.Btn_AddService.Text = "Add";
            this.Btn_AddService.UseVisualStyleBackColor = true;
            this.Btn_AddService.Click += new System.EventHandler(this.Btn_AddService_Click);
            // 
            // Add_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_AddService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EstitmatedTBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescrpBox);
            this.Controls.Add(this.ServiceDataGrid);
            this.Controls.Add(this.ServiceNBox);
            this.Name = "Add_Service";
            this.Size = new System.Drawing.Size(1307, 902);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServiceNBox;
        private System.Windows.Forms.DataGridView ServiceDataGrid;
        private System.Windows.Forms.TextBox DescrpBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox EstitmatedTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_AddService;
    }
}
