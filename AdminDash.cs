using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVELOPMENT_SOFTWARE_PROJECT_CTRL_B
{
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }



        private void AdminDash_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.SelectedItem = "Male";


            cboBookID.Items.Add("MATH25");
            cboBookID.Items.Add("ENG18");
            cboBookID.Items.Add("PHY31");
            cboBookID.Items.Add("BIO42");
            cboBookID.Items.Add("GEO56");
            cboBookID.SelectedItem = "MATH25";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(inputValidations.isBlank(txtFirstName.Text) == true)
            {
                MessageBox.Show("Enter student first name to proceed.");
                txtFirstName.Focus();
                return;
            }
            if(inputValidations.isBlank(txtLastName.Text) == true)
            {
                MessageBox.Show("Enter the student last name to proceed.");
                txtLastName.Focus();
                return;
            }
            if (inputValidations.validateID(txtStudentID.Text) == false)
            {
                txtStudentID.Focus();
                return;
                
            }

        }
    }
    }

