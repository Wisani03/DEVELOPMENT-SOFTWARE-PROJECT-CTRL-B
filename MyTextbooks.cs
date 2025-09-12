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
    public partial class MyTextbooks : Form
    {
        public MyTextbooks()
        {
            InitializeComponent();
        }

        private void MyTextbooks_Load(object sender, EventArgs e)
        {
            // Step 1: Create the data table
            DataTable table = new DataTable();

            // Define columns
            table.Columns.Add("Row", typeof(int));
            table.Columns.Add("Book ID", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Issue date", typeof(DateTime));
            table.Columns.Add("Return date", typeof(DateTime));
            table.Columns.Add("Status", typeof(string));

            // Step 2: Add rows with complete data
            table.Rows.Add(1, "MATH25", "Mathematics", new DateTime(2025, 01, 15), new DateTime(2025, 12, 13), "Returned");
            table.Rows.Add(2, "ENG18", "English", new DateTime(2025, 01, 15), new DateTime(2025, 12, 13), "Issued");
            table.Rows.Add(3, "PHY31", "Physical Sciences", new DateTime(2025, 01, 15), new DateTime(2025, 12, 13), "Returned");
            table.Rows.Add(4, "BIO42", "Life Sciences", new DateTime(2025, 01, 15), new DateTime(2025, 12, 13), "Issued");
            table.Rows.Add(5, "GEO56", "Geography", new DateTime(2025, 01, 15), new DateTime(2025, 12, 13), "Returned");

            // Step 3: Bind the data to your DataGridView
            dataGridView1.DataSource = table;

            // Step 4: Format the date columns (optional)
            dataGridView1.Columns["Issue date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["Return date"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Optional: Auto-size columns for better layout
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
    }
}
