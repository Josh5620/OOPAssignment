using Assignment;
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
    public partial class ViewFeedback : UserControl
    {
        public ViewFeedback()
        {
            InitializeComponent();
            CustomerFeedbackGrid.DataSource = admin.feedbackdata;  // Bind the data on initialization
            PopulateMonthComboBox();  // Populate the month combo box
        }

        Admin admin = new Admin();

        // Populate MonthComboBox with months (January to December)
        private void PopulateMonthComboBox()
        {
            MonthComboBox.Items.Clear();
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

            // Set default selection to January
            MonthComboBox.SelectedIndex = 0;
        }

        // Event handler for filter button
        private void Btn_filterfeedback_Click(object sender, EventArgs e)
        {
            // Get the selected month from ComboBox (e.g., "01 - January")
            string selectedMonth = MonthComboBox.SelectedItem.ToString();

            // Extract the month number from the selected month string (first two characters)
            string monthNumber = selectedMonth.Substring(0, 2);

            if (string.IsNullOrEmpty(monthNumber))
            {
                MessageBox.Show("Please select a valid month.");
                return;
            }

            // Call GetFeedbackByMonth from Admin class (filter feedback by selected month)
            admin.GetFeedbackByMonth(monthNumber);

            // Bind the filtered feedback data to the DataGridView
            CustomerFeedbackGrid.DataSource = admin.feedbackdata;
        }

        // Event handler for refresh button (optional)
        private void Btn_refreshdatagrid_Click(object sender, EventArgs e)
        {
            // Bind the refreshed data to the DataGridView (CustomerFeedbackGrid)
            CustomerFeedbackGrid.DataSource = admin.feedbackdata;
        }
    }
}
