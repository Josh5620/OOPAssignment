namespace Assignment.UserControls
{
    partial class ViewReports
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
            this.ServiceReportDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.Btn_filterreport = new System.Windows.Forms.Button();
            this.Btn_refreshdatagrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceReportDataGrid
            // 
            this.ServiceReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceReportDataGrid.Location = new System.Drawing.Point(20, 27);
            this.ServiceReportDataGrid.Name = "ServiceReportDataGrid";
            this.ServiceReportDataGrid.RowHeadersWidth = 82;
            this.ServiceReportDataGrid.RowTemplate.Height = 33;
            this.ServiceReportDataGrid.Size = new System.Drawing.Size(1130, 564);
            this.ServiceReportDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Month:";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(157, 692);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(194, 45);
            this.MonthComboBox.TabIndex = 3;
            // 
            // Btn_filterreport
            // 
            this.Btn_filterreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_filterreport.Location = new System.Drawing.Point(577, 684);
            this.Btn_filterreport.Name = "Btn_filterreport";
            this.Btn_filterreport.Size = new System.Drawing.Size(196, 81);
            this.Btn_filterreport.TabIndex = 4;
            this.Btn_filterreport.Text = "Filter";
            this.Btn_filterreport.UseVisualStyleBackColor = true;
            this.Btn_filterreport.Click += new System.EventHandler(this.Btn_filterreport_Click);
            // 
            // Btn_refreshdatagrid
            // 
            this.Btn_refreshdatagrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refreshdatagrid.Location = new System.Drawing.Point(816, 684);
            this.Btn_refreshdatagrid.Name = "Btn_refreshdatagrid";
            this.Btn_refreshdatagrid.Size = new System.Drawing.Size(196, 81);
            this.Btn_refreshdatagrid.TabIndex = 5;
            this.Btn_refreshdatagrid.Text = "Refresh";
            this.Btn_refreshdatagrid.UseVisualStyleBackColor = true;
            this.Btn_refreshdatagrid.Click += new System.EventHandler(this.Btn_refreshdatagrid_Click);
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_refreshdatagrid);
            this.Controls.Add(this.Btn_filterreport);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceReportDataGrid);
            this.Name = "ViewReports";
            this.Size = new System.Drawing.Size(1307, 902);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ServiceReportDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Button Btn_filterreport;
        private System.Windows.Forms.Button Btn_refreshdatagrid;
    }
}
