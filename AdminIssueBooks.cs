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
    public partial class AdminIssueBooks : Form
    {
        public AdminIssueBooks()
        {
            InitializeComponent();
        }

        private void AdminIssueBooks_Load(object sender, EventArgs e)
        {
            // Populate gender options
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Other");
            cboGender.SelectedItem = "Male";

            // Populate book ID options
            cboBookID.Items.Add("MATH25");
            cboBookID.Items.Add("ENG18");
            cboBookID.Items.Add("PHY31");
            cboBookID.Items.Add("BIO42");
            cboBookID.Items.Add("GEO56");
            cboBookID.SelectedItem = "MATH25";

            // Step 1: Create DataTable with desired columns only
            DataTable table = new DataTable();
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("SURNAME", typeof(string));
            table.Columns.Add("GENDER", typeof(string));
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("BOOK ID", typeof(string));

            // Step 2: Add rows with clean student data
            table.Rows.Add("Wisani", "Baloyi", "Male", 1001, "MATH25");
            table.Rows.Add("Hope", "Mokoena", "Female", 1002, "ENG18");
            table.Rows.Add("Rendzo", "Mudau", "Male", 1003, "PHY31");
            table.Rows.Add("Lisakhanya", "Dube", "Female", 1004, "BIO42");
            table.Rows.Add("Lethabo", "Nkosi", "Other", 1005, "GEO56");

            // Step 3: Bind to grid
            dataGridView1.DataSource = table;

            // Step 4: Optional layout tweak
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }

}

