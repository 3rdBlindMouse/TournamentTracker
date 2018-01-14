using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public class Validator
    {
        public Validator()
        {

        }
        /*
        * 
        * REGULAR EXPRESSIONs
        * 
        */

        /// <summary>
        /// Regex for a String
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true or false</returns>
        public bool isValidString(String str)
        {                       
            return Regex.IsMatch(str, @"^[a-zA-Z ]+$");           
        }

        public bool noSpaces(string str)
        {
            //return Regex.IsMatch(str, @"^\S$|^\S[\s\S]*\S$");
            return Regex.IsMatch(str, @"^([A-Za-z]+ )+[A-Za-z]+$|^[A-Za-z]+$");
        }

        public bool noNumbers(string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z ]+$");
        }

        /// <summary>
        /// Regex for validating an email address
        /// taken from https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
        /// </summary>
        /// <param name="str"></param>
        /// <returns>True if String matches regex, else false</returns>
        public bool isValidEmail(String str)
        {
            return Regex.IsMatch(str, @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
        }
        /// <summary>
        /// Regex for validating a phone number
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool isValidNumber(String str)
        {
            // TODO validate properly as phone number
            return str.All(char.IsDigit);
        }
        
      public bool isValidSex(String str)
        {
            if((str == "Male") || (str == "Female"))
            {
                return true;
            }
            return false;
        }

        public bool isValidAddress(String str)
        {
            return Regex.IsMatch(str, @"^[#.0-9a-zA-Z\s,-]+$");
                                      
        }

        public bool isValidName(String str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z\s,&]+$");
            //                      // @"[^A-Za-z0-9'\.&@:?!()$#^]"
        }

        public bool isValidPhoneNumber(String str)
        {
            return Regex.IsMatch(str, @"^([\(\)\+0-9\s\-\#]+)$");
        }
    }
}
