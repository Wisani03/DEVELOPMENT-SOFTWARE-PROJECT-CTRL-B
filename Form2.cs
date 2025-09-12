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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;

            pnlSignUp.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = false;
            pnlLogin.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void txtSignUpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSignUpName_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtSignUpName_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtSignUpLstName_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtSignUpLstName_Leave(object sender, EventArgs e)
        {
            
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtLoginPasswrd.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginPasswrd.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (inputValidations.isBlank(txtStudentID.Text)== true)
            {
                MessageBox.Show("Enter your student ID");
                txtStudentID.Focus();
                return;
            }
            if (inputValidations.validateID(txtStudentID.Text) == false)
            {
                txtStudentID.Focus();
                return;
            }

            if (inputValidations.isBlank(txtLoginPasswrd.Text)== true)
            {
                MessageBox.Show("Enter your password");
                txtLoginPasswrd.Focus();
                return;
            }

          

          

            string validUsername = "12345";
            string validPassword = "WisaniMabunda";

            if (txtStudentID.Text == validUsername && txtLoginPasswrd.Text == validPassword)
            {
                MessageBox.Show("Login Successful!", "Success");

                Methods.HideForms();
                Form5 form5 = new Form5();
                form5.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or password", "Error");
                return;
            }

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
