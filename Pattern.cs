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
        public static string Regex_LastName = "^[A-Z]{1}[a-z]{2,10}$";

        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, Regex_LastName);
        }
    }
}
