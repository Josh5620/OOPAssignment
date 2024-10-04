using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.UserControls
{
    public partial class CMDEL_Control : UserControl
    {
        public CMDEL_Control()
        {
            InitializeComponent();
            
        }


        Receptionist Recep = new Receptionist();

        private void CMDEL_Control_Load(object sender, EventArgs e)
        {
                       // Loads datatable using the recep class function and 
            dataGridView1.DataSource = Recep.LoadDatagrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receptionist Recep = new Receptionist();
            dataGridView1.DataSource = Recep.LoadDatagrid();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {       
                // Bottom filters check if its empty boxes and if its not it adds it to the query string to filter
            try
            {
                int filterID;
                string filterName = NametextBox.Text.Trim();
                int filterNumber;

                DataTable dt = (DataTable)dataGridView1.DataSource;

                string rowFilter = "";


                if (int.TryParse(IDtextBox.Text.Trim(), out filterID) && filterID > 0)
                {
                    rowFilter += $"CustomerID = {filterID}";
                }



                if (!string.IsNullOrEmpty(filterName))
                {
                    if (!string.IsNullOrEmpty(rowFilter))
                    {
                        rowFilter += " AND ";
                    }
                    rowFilter += $"FullName LIKE '%{filterName}%'";
                }


                if (int.TryParse(NumtextBox.Text.Trim(), out filterNumber) && filterNumber > 0)
                {
                    if (!string.IsNullOrEmpty(rowFilter))
                    {
                        rowFilter += " AND ";
                    }
                    rowFilter += $"VehicleNumber = {filterNumber}";
                }

                if (!string.IsNullOrEmpty(rowFilter))
                {
                    dt.DefaultView.RowFilter = rowFilter;
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }



            }
            catch (Exception ex) { MessageBox.Show("Error?"); };
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IDtextBox.Text = string.Empty;
            NametextBox.Text = string.Empty;
            NumtextBox.Text = string.Empty;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string customerID = selectedRow.Cells["CustomerID"].Value.ToString();
                string customerName = selectedRow.Cells["FullName"].Value.ToString();

                var result = MessageBox.Show($"Are you sure you want to delete the selected Customer:{customerName} (ID: {customerID})?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = selectedRow.Index;
                    Recep.DeleteCustomerRecord(Convert.ToInt32(customerID));

                }
                else
                {
                    MessageBox.Show("Please select a row to delete!");
                }

                Recep.RefreshDatabase(dataGridView1.DataSource as DataTable);
                button1_Click(sender, e);

            }
        }

    }
}
