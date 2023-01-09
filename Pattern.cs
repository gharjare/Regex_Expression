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
        public static string ValidateFirstName(string firstName)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            bool res = regex.IsMatch(firstName);
            if (res)
            {
                Console.WriteLine("Valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
        }
        public static string ValidateLName(string lastName)
        {
            string pattern = "^[A-Z][a-z]{2,}$";
            Regex regex = new Regex(pattern);
            bool res1 = regex.IsMatch(lastName);
            if (res1)
            {
                Console.WriteLine("Valid");
                return lastName;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;

        }
        public static string ValidateEmail(string email)
        {

            string emailPattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);
           
            bool result = regex.IsMatch(email);
            if (result)
            {
                Console.WriteLine(email + " ----->Valid");
                return email;
            }
            else
            {
                Console.WriteLine(email + " ----->Invalid");
            }

            return default;
        }

        public static string ValidatePhoneNum(string phoneNum)
        {
            string[] phoneNumInput = { "91 7852234896", " 91 9865741548", "919865795312", "91@123", "A865" };
            string phoneNumPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);

            bool result = regex.IsMatch(phoneNum);
            if (result)
            {
                Console.WriteLine(phoneNum + " ----->Valid");
                return phoneNum;
            }
            else
            {
                Console.WriteLine(phoneNum + " ----->InValid");
            }
            return default;
        }


        public static string ValidatePassWord(string password)
        {
            string[] passwordInput = { "Chetan@12", "CheTan_32", "rahul123", "kunal" };
            string passwordPattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";

            Regex regex = new Regex(passwordPattern);

            bool result = regex.IsMatch(password);
            if (result)
            {
                Console.WriteLine(password + " ----->Valid");
                return password;
            }
            else
            {
                Console.WriteLine(password + " ----->InValid");
            }

            return default;
        }
    }
}
