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
        public static string Regex_Character = "((?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&*_]).{8,})";
        public bool ValidateCharacter(string Character)
        {
            return Regex.IsMatch(Character, Regex_Character);
        }
    }
}
