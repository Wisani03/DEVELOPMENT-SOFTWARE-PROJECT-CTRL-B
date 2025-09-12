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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStdLogin_Click(object sender, EventArgs e)
        {
            Methods.HideForms();
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void btnLoginAsTeacher_Click(object sender, EventArgs e)
        {
            Methods.HideForms();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods.HideForms();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
