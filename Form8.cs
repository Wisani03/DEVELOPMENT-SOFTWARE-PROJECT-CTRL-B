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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void SignUpLink_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;

            pnlSignUp.Visible = true;
        }

        private void LoginLink_Click(object sender, EventArgs e)
        {

            pnlSignUp.Visible = false;
            pnlLogin.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtAdminPwrd.UseSystemPasswordChar = false;
            }
            else
            {
                txtAdminPwrd.UseSystemPasswordChar = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtSignUpcnfrmPasswrd.UseSystemPasswordChar = false;
            }
            else
            {
                txtSignUpcnfrmPasswrd.UseSystemPasswordChar = true;
            }
        }

        private void btnLoginStd_Click(object sender, EventArgs e)
        {

           if(inputValidations.isBlank(txtadminID.Text) == true)
            {
                MessageBox.Show("Enter your Admin ID");
                txtadminID.Focus();
                return;
            }
            if (inputValidations.validateID(txtadminID.Text) == false)
            {
                txtadminID.Focus();
                return;
            }
            if (inputValidations.isBlank(txtAdminPwrd.Text) == true)
            {
                MessageBox.Show("Enter your password");
                txtAdminPwrd.Focus();
                return;
            }
          


            string validUsername = "12345";
            string validPassword = "WisaniMabunda";

            if (txtadminID.Text == validUsername && txtAdminPwrd.Text == validPassword)
            {
                MessageBox.Show("Login Successful!", "Success");

                Form7 form7 = new Form7();
                form7.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or password", "Error");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
