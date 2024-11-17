namespace Assignment.UserControls
{
    partial class ViewFeedback
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
            this.Btn_refreshdatagrid = new System.Windows.Forms.Button();
            this.Btn_filterfeedback = new System.Windows.Forms.Button();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerFeedbackGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerFeedbackGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_refreshdatagrid
            // 
            this.Btn_refreshdatagrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refreshdatagrid.Location = new System.Drawing.Point(819, 707);
            this.Btn_refreshdatagrid.Name = "Btn_refreshdatagrid";
            this.Btn_refreshdatagrid.Size = new System.Drawing.Size(196, 81);
            this.Btn_refreshdatagrid.TabIndex = 11;
            this.Btn_refreshdatagrid.Text = "Refresh";
            this.Btn_refreshdatagrid.UseVisualStyleBackColor = true;
            this.Btn_refreshdatagrid.Click += new System.EventHandler(this.Btn_refreshdatagrid_Click);
            // 
            // Btn_filterfeedback
            // 
            this.Btn_filterfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_filterfeedback.Location = new System.Drawing.Point(580, 707);
            this.Btn_filterfeedback.Name = "Btn_filterfeedback";
            this.Btn_filterfeedback.Size = new System.Drawing.Size(196, 81);
            this.Btn_filterfeedback.TabIndex = 10;
            this.Btn_filterfeedback.Text = "Filter";
            this.Btn_filterfeedback.UseVisualStyleBackColor = true;
            this.Btn_filterfeedback.Click += new System.EventHandler(this.Btn_filterfeedback_Click);
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(160, 715);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(194, 45);
            this.MonthComboBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 712);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Month:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter:";
            // 
            // CustomerFeedbackGrid
            // 
            this.CustomerFeedbackGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerFeedbackGrid.Location = new System.Drawing.Point(23, 50);
            this.CustomerFeedbackGrid.Name = "CustomerFeedbackGrid";
            this.CustomerFeedbackGrid.RowHeadersWidth = 82;
            this.CustomerFeedbackGrid.RowTemplate.Height = 33;
            this.CustomerFeedbackGrid.Size = new System.Drawing.Size(1130, 564);
            this.CustomerFeedbackGrid.TabIndex = 6;
            // 
            // ViewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_refreshdatagrid);
            this.Controls.Add(this.Btn_filterfeedback);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerFeedbackGrid);
            this.Name = "ViewFeedback";
            this.Size = new System.Drawing.Size(1307, 902);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerFeedbackGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_refreshdatagrid;
        private System.Windows.Forms.Button Btn_filterfeedback;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomerFeedbackGrid;
    }
}
