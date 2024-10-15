namespace WindowsFormsApp2.UserControls
{
    partial class VI_Control
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDSearch = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MechSelfRequest = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "VI CONTROL TEST";
            // 
            // IDSearch
            // 
            this.IDSearch.FormattingEnabled = true;
            this.IDSearch.Items.AddRange(new object[] {
            "Test3",
            "Alphabet",
            "231"});
            this.IDSearch.Location = new System.Drawing.Point(92, 116);
            this.IDSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDSearch.Name = "IDSearch";
            this.IDSearch.Size = new System.Drawing.Size(160, 24);
            this.IDSearch.TabIndex = 5;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(92, 180);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 28);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(223, 180);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 28);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "MechanicID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mechanic Inventory Requested";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Inventory Requested";
            // 
            // MechSelfRequest
            // 
            this.MechSelfRequest.Location = new System.Drawing.Point(92, 258);
            this.MechSelfRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MechSelfRequest.Name = "MechSelfRequest";
            this.MechSelfRequest.ReadOnly = true;
            this.MechSelfRequest.Size = new System.Drawing.Size(328, 239);
            this.MechSelfRequest.TabIndex = 11;
            this.MechSelfRequest.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(488, 46);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(324, 452);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // VI_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MechSelfRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.IDSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VI_Control";
            this.Size = new System.Drawing.Size(856, 629);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IDSearch;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox MechSelfRequest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
