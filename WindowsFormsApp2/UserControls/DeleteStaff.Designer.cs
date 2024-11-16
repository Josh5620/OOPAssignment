namespace Assignment
{
    partial class DeleteStaff
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
            this.StaffDataGrid = new System.Windows.Forms.DataGridView();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffDataGrid
            // 
            this.StaffDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDataGrid.Location = new System.Drawing.Point(40, 43);
            this.StaffDataGrid.Name = "StaffDataGrid";
            this.StaffDataGrid.RowHeadersWidth = 82;
            this.StaffDataGrid.Size = new System.Drawing.Size(1130, 563);
            this.StaffDataGrid.TabIndex = 0;
            // 
            // Btn_delete
            // 
            this.Btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_delete.Location = new System.Drawing.Point(1049, 674);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(156, 61);
            this.Btn_delete.TabIndex = 1;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.UseVisualStyleBackColor = true;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "StaffId:";
            // 
            // StaffIDBox
            // 
            this.StaffIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIDBox.Location = new System.Drawing.Point(208, 683);
            this.StaffIDBox.Name = "StaffIDBox";
            this.StaffIDBox.Size = new System.Drawing.Size(232, 44);
            this.StaffIDBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 683);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Remove Staff from Database:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insert Staff Details:";
            // 
            // DeleteStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaffIDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.StaffDataGrid);
            this.Name = "DeleteStaff";
            this.Size = new System.Drawing.Size(1259, 821);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StaffDataGrid;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StaffIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
