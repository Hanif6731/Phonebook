using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.PhoneBook
{
    internal class ValidateText
    {
        public static bool Text(params string[] text)
        {
            int i = 0;
            foreach(string item in text)
            {
                if (string.IsNullOrEmpty(text[i]) || string.IsNullOrWhiteSpace(text[i++]))
                {
                    return false;
                }
                
            }
            
            return true;
        }
        public static bool IsNumber(String str)
        {
            int Number;
            if (int.TryParse(str, out Number)) return true;
            return false;
        }
        public static bool IsDouble(String str)
        {
            double Number;
            if (double.TryParse(str, out Number)) return true;
            return false;
        }
        public static bool DoesStringContainsDigit(string str)
        {
            try
            {

                foreach (char item in str)
                {
                    if (ValidateText.IsNumber(item.ToString()))
                    {
                        return true;

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;
        }

        public static bool ValidEmail(string email)
        {
            string[] domains = { ".com", ".net", ".edu", ".co", ".COM", ".NET", ".EDU", ".CO" };
            
                if (email.Contains("@"))
                {
                    string[] str = email.Split('@');
                    if (str.Length == 2)
                    {
                        foreach (string domain in domains)
                        {
                            if (str[1].EndsWith(domain))
                            {
                                return true;
                            }
                        }
                    }

                }
            
            
            
            return false;
        }
    }
}
