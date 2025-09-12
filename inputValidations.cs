using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DEVELOPMENT_SOFTWARE_PROJECT_CTRL_B
{
    internal class inputValidations
    {
        public static bool isBlank(string textbox)
        {
            if (textbox.Trim().Length == 0)
                return true;
            else
                return false;
        }
        public static bool validateID(string id)
        {
            for (int i = 0; i < id.Trim().Length; i++)
            {
                char ID = id.Trim()[i];

                if(char.IsDigit(ID) == false)
                {
                    MessageBox.Show("The ID must be numeric");
                    return false;
                }
            }
            return true;
            
        }
        public static bool validateCharacters(string textbox)
        {
            for (int i = 0; i < textbox.Trim().Length; i++)
            {
                char ch = textbox.Trim()[i];
                if (char.IsLetter(ch) == false)
                {
                    MessageBox.Show("Name must only contain alphabetic characters only.");
                    return false;
                }
            }
            return true;
        }
         

    }
}
