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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            // Step 1: Create the data table
            DataTable table = new DataTable();

            table.Columns.Add("Row", typeof(int));               // New column for row number
            table.Columns.Add("Selected Book Id", typeof(string));
            table.Columns.Add("Status", typeof(string));

            // Step 2: Add rows with complete data
            table.Rows.Add(1, "MATH25", "Pending");
            table.Rows.Add(2, "ENG18",  "Pending");
            table.Rows.Add(3, "PHY31", "Returned");
            table.Rows.Add(4, "BIO42", "Pending");
            table.Rows.Add(5, "GEO56", "Returned");

            // Step 3: Bind the data to your DataGridView
            dataGridView1.DataSource = table;



            cboBookID.Items.Add("MATH25");
            cboBookID.Items.Add("ENG18");
            cboBookID.Items.Add("PHY31");
            cboBookID.Items.Add("BIO42");
            cboBookID.Items.Add("GEO56");
            cboBookID.SelectedItem = "MATH25";

        }
    }
}
