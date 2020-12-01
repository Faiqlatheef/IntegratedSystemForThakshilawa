using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IntegratedSystemThakshilawa
{
    class commonValitations
    {
        //Method for Name Valitation 
        public static Regex Valid_Name = StringOnly();
        public static Regex Valid_Number = NumberOnly();
        public static Regex Valid_Name_Limit = StringLimit();
        public static Regex Valid_Password = ValidPassword();

        private static Regex StringOnly()
        {
            string StringAndNumber_Pattern = "^[a-zA-Z]";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        private static Regex StringLimit()
        {
            string StringLimit_Pattern = "^[a-zA-Z]{6}";

            return new Regex(StringLimit_Pattern, RegexOptions.IgnoreCase);
        }

        //Method for password validation 
        private static Regex ValidPassword()
        {
            string Password_Pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(Password_Pattern, RegexOptions.IgnoreCase);
        }

        private static Regex NumberOnly()
        {
            string StringAndNumber_Pattern = "^[a-zA-Z]";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
    }
}
