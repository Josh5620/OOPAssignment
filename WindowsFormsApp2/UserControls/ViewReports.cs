using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.UserControls
{
    public partial class ViewReports : UserControl
    {
        public ViewReports()
        {
            InitializeComponent();
            ServiceReportDataGrid.DataSource = admin.ReportData;
            PopulateMonthComboBox();
        }

        private void PopulateMonthComboBox()
        {
            // Clear existing items if any
            MonthComboBox.Items.Clear();

            // Add month numbers (01, 02, etc.)
            MonthComboBox.Items.Add("01 - January");
            MonthComboBox.Items.Add("02 - February");
            MonthComboBox.Items.Add("03 - March");
            MonthComboBox.Items.Add("04 - April");
            MonthComboBox.Items.Add("05 - May");
            MonthComboBox.Items.Add("06 - June");
            MonthComboBox.Items.Add("07 - July");
            MonthComboBox.Items.Add("08 - August");
            MonthComboBox.Items.Add("09 - September");
            MonthComboBox.Items.Add("10 - October");
            MonthComboBox.Items.Add("11 - November");
            MonthComboBox.Items.Add("12 - December");

            // Optionally, set the default selected item (e.g., January)
            MonthComboBox.SelectedIndex = 0;  // This sets the default selection to January (01)
        }

        // Admin class instance
        Admin admin = new Admin();

        // Event handler for the filter button
        private void Btn_filterreport_Click(object sender, EventArgs e)
        {
            string selectedMonth = MonthComboBox.Text;  

            if (string.IsNullOrEmpty(selectedMonth))
            {
                MessageBox.Show("Please select a valid month.");
                return;
            }

            // Call the GetReportsByMonth method from Admin class
            admin.GetReportsByMonth(selectedMonth);

            ServiceReportDataGrid.DataSource = admin.ReportData;
        }

        private void Btn_refreshdatagrid_Click(object sender, EventArgs e)
        {
            admin.GetReportsByMonth("all");  

            ServiceReportDataGrid.DataSource = admin.ReportData;
        }
    }
}
