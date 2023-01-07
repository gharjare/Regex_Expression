using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression1
{
    public class Pattern
    {
        public static string Regex_PhoneNumber = "^(91)[6-9]{1}[0-9]{9}$";

        public bool ValidateNumber(string number)
        {
            return Regex.IsMatch(number, Regex_PhoneNumber);
        }
    }
}
