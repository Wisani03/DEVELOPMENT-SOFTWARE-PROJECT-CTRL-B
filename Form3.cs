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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (inputValidations.isBlank(txtStaffID.Text) == true)
            {
                MessageBox.Show("Enter your staff ID");
                txtStaffID.Focus();
                return;
            }
            if (inputValidations.validateID(txtStaffID.Text) == false)
            {
                txtStaffID.Focus();
                return;
            }

            if (inputValidations.isBlank(txtTeachPasswrdLogin.Text) == true)
            {
                MessageBox.Show("Enter your password");
                txtTeachPasswrdLogin.Focus();
                return;
            }


            string validUsername = "12345";
            string validPassword = "WisaniMabunda";

            if (txtStaffID.Text == validUsername && txtTeachPasswrdLogin.Text == validPassword)
            {
                MessageBox.Show("Login Successful!", "Success");

                Methods.HideForms();
                Form6 form6 = new Form6();
                form6.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error");
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtTeachPasswrdLogin.UseSystemPasswordChar = false;
            }
            else
            {
                txtTeachPasswrdLogin.UseSystemPasswordChar = true;
            }
        }

        private void LoginLink_Click(object sender, EventArgs e)
        {

            pnlSignUpTeacher.Visible = false;
            pnlLoginTeacher.Visible = true;
        }

        private void SignUpLink_Click(object sender, EventArgs e)
        {

            pnlLoginTeacher.Visible = false;

            pnlSignUpTeacher.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Methods.HideForms();
            Form1 form1 = new Form1();
            form1.Show();
            
        }
    }
}
