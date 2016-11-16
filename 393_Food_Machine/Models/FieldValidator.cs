using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _393_Food_Machine.Models
{
    /**
     * The purpose of this class is to make field validation code reusable across all of the
     * different forms. 
     */
    class FieldValidator
    {
        public static bool ValidateDoubleNumeric(TextBox textbox, String fieldName)
        {
            double textBoxValue;
            bool valueParsed = Double.TryParse(textbox.Text, out textBoxValue);
            if (!valueParsed)
            {
                System.Windows.Forms.MessageBox.Show(String.Format("Please input a valid double numeric value for {0} before confirming",fieldName));
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateIntNumeric(TextBox textbox, String fieldName)
        {
            int textBoxValue;
            bool valueParsed = Int32.TryParse(textbox.Text, out textBoxValue);
            if (!valueParsed)
            {
                System.Windows.Forms.MessageBox.Show(String.Format("Please input a valid integer numeric value for {0} before confirming", fieldName));
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateString(TextBoxBase textbox, String fieldName, String[] invalidValues)
        {
            if(textbox.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show(String.Format("{0} cannot be left empty!", fieldName));
                return false;
            }
            foreach(String value in invalidValues)
            {
                if(textbox.Text.Equals(value))
                {
                    System.Windows.Forms.MessageBox.Show(String.Format("The given value for {0} is not accepted.", fieldName));
                    return false;
                }
            }
            //As long as the string is not either empty or in the list of invalid values, it's good!
            return true;
        }

        public static bool ValidateStructureNotEmpty<T>(List<T> list, String fieldName)
        {
            if(list.Count > 0)
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(String.Format("{0} cannot be empty.", fieldName));
                return false;
            }
        }

        public static bool ValidateWithinRange(int index, Type enumType, String fieldName, String fieldText)
        {
            if(index < Enum.GetValues(enumType).Length && index >= 0)
            {
                return true;
            }
            //In case someone happens to know the unit they want and they type it!
            if(Enum.GetNames(enumType).Contains(fieldText))
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(String.Format("The index selected for {0} is not accepted.", fieldName));
                return false;
            }
        }

        public static int getComboIndex(Type enumType, String value)
        {
            return Array.IndexOf(Enum.GetNames(enumType), value);
        }
    }

    
}
