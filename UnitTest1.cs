using RegularExpression1;
using System.Text.RegularExpressions;

namespace RegularExpressionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Chetan", "Chetan")]
        [DataRow("Che", "Che")]
        [DataRow("c", null)]
        [DataRow("Chetan02", null)]
        public void ValidateFirstName(string a, string expected)
        {
            var actual = Pattern.ValidateFirstName(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Gharjare", "Gharjare")]
        [DataRow("Gh", null)]
        [DataRow("Gharja", "Venkat")]
        [DataRow("Gharja01", null)]
        public void ValidateUserLastname(string a, string expected)
        {
            var actual = Pattern.ValidateLName(a);
            Assert.AreEqual(expected, actual);
        }
        //Validation for Email
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", null)]
        [DataRow("abc@.com.my", null)]
        [DataRow("abc123@.com", null)]
        [DataRow("abc123@.com.com", null)]
        [DataRow("abc()*@gmail.com", null)]
        [DataRow(".abc@abc.com", null)]
        [DataRow("abc@%*.com", null)]
        [DataRow("abc..2002@gmail.com", null)]
        [DataRow("abc.@gmail.com", null)]
        [DataRow("abc@abc@gmail.com", null)]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]

        public void ValidateUserEmail(string a, string expected)
        {
            var actual = Pattern.ValidateEmail(a);
            Assert.AreEqual(expected, actual);
        }

        //Validation for Phone Number
        [TestMethod]
        [DataRow("1 1000987267", "1 1000987267")]
        [DataRow("91 9842905050", "91 9842905050")]
        [DataRow("100 9842905050", "100 9842905050")]
        [DataRow("919842905050", null)]
        [DataRow("919842905", null)]
        [DataRow("91 984290", null)]
        [DataRow("91 984290505000000", null)]
        public void ValidateUserPhoneNumber(string a, string expected)
        {
            var actual = Pattern.ValidatePhoneNum(a);
            Assert.AreEqual(expected, actual);
        }

        ////Validation for Password
        [TestMethod]
        [DataRow("Chetan@123", "Chetan@123")]
        [DataRow("@Chetan129", "@Chetan129")]
        [DataRow("Che-tan123", "Che-tan123")]
        [DataRow("chetan123)@1234", null)]
        [DataRow("Che@tan", null)]
        [DataRow("che123", null)]
        [DataRow("che@123", null)]
        [DataRow("@che#12che", null)]
        [DataRow(")chetu12", null)]
        [DataRow(")chetu12", null)]
        [DataRow("che-tu@12S", null)]
        [DataRow("cheTu@s", null)]

        public void ValidateUserPassword(string a, string expected)
        {
            var actual = Pattern.ValidatePassWord(a);
            Assert.AreEqual(expected, actual);
        }
    }
}