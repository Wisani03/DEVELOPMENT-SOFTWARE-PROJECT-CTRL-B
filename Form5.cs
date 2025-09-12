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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            this.pnlMain.Tag = f;
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            loadform(new dashboardform());
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            loadform(new MyTextbooks());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            loadform(new Return());
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            loadform(new Notices());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the result
            if (result == DialogResult.Yes)
            {
                // Logout logic here
                Form1 form1 = new Form1();
                form1.Show();

                this.Close();

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
