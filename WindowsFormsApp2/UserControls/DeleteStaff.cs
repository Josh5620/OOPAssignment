﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class DeleteStaff : UserControl
    {
        public DeleteStaff()
        {
            InitializeComponent();
            StaffDataGrid.DataSource = admin.staffData;
        }
        Admin admin = new Admin();

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            admin.DeleteStaff(int.Parse(StaffIDBox.Text));
            StaffDataGrid.DataSource = admin.LoadDataGrid("staff");
        }
    }
}
