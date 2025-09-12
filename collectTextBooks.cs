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
    public partial class collectTextBooks : Form
    {
        public collectTextBooks()
        {
            InitializeComponent();
        }

        private void collectTextBooks_Load(object sender, EventArgs e)
        {

            cboBookID.Items.Add("MATH25");
            cboBookID.Items.Add("ENG18");
            cboBookID.Items.Add("PHY31");
            cboBookID.Items.Add("BIO42");
            cboBookID.Items.Add("GEO56");
            cboBookID.SelectedItem = "MATH25";
            cboBookID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(inputValidations.isBlank(txtReportComplaint.Text) == true)
            {
                MessageBox.Show("Enter your name");
                txtReportComplaint.Focus();
                return;
            }
            if(inputValidations.validateCharacters(txtReportComplaint.Text) == false)
            {
                txtReportComplaint.Focus();
                return;
            }
            if(inputValidations.isBlank(txtRptcmpStaffID.Text) == true)
            {
                MessageBox.Show("Enter your staff ID.");
                txtRptcmpStaffID.Focus();
                return;
            }
            if(inputValidations.validateID(txtRptcmpStaffID.Text) == false)
            {
                txtRptcmpStaffID.Focus();
                return;
            }
        }
    }
}
