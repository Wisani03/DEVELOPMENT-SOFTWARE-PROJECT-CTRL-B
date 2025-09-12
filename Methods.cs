using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVELOPMENT_SOFTWARE_PROJECT_CTRL_B
{
    internal class Methods
    {
        public static void HideForms()
        {
            foreach (Form f in Application.OpenForms)
            {
                f.Hide();
            }
        }
    }
}
