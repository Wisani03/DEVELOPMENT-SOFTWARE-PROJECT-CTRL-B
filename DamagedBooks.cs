using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVELOPMENT_SOFTWARE_PROJECT_CTRL_B
{
    public partial class DamagedBooks : Form
    {
        public DamagedBooks()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void DamagedBooks_Load(object sender, EventArgs e)
        {
            // Define columns only once
            table.Columns.Add("Row", typeof(int));
            table.Columns.Add("Selected Book Id", typeof(string));
            table.Columns.Add("Status", typeof(string));

            // Add sample data
            table.Rows.Add(1, "MATH25", "Damaged");
            table.Rows.Add(2, "ENG18", "Damaged");
            table.Rows.Add(3, "PHY31", "Good");
            table.Rows.Add(4, "BIO42", "Good");
            table.Rows.Add(5, "GEO56", "Pending");

            // Bind to DataGridView
            dataGridView1.DataSource = table;

            // Populate ComboBox
            cboBookID.Items.AddRange(new string[] { "MATH25", "ENG18", "PHY31", "BIO42", "GEO56" });
            cboBookID.SelectedItem = "MATH25";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add new row when button is clicked
            int nextRowNumber = table.Rows.Count + 1;
            string selectedBookId = cboBookID.SelectedItem.ToString();
            string status = "Damaged"; // Or get this from a status field if available

            table.Rows.Add(nextRowNumber, selectedBookId, status);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Safety check: Make sure index is valid
                if (selectedIndex >= 0 && selectedIndex < table.Rows.Count)
                {
                    // Remove the row from the DataTable
                    table.Rows.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
