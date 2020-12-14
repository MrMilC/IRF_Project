using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using valYOU;

namespace valYOU_UnitTest
{
    public class vY_UnitTest
    {
        [
            Test,
            TestCase("teszt", false),
            TestCase("teszt@", false),
            TestCase("teszt@valyou", false),
            TestCase("teszt@valyou.", false),
            TestCase("teszt.valyou.hu", false),

            TestCase("teszt@valyou.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            var regisztracio = new Regisztracio();

            var actualResult = regisztracio.ValidateEmail(email);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [
            Test,
            TestCase("abcdABCD", false),
            TestCase("ABCD1234", false),
            TestCase("abcd1234", false),
            TestCase("Ab1234", false),

            TestCase("Abcd1234", true)
        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            var regisztracio = new Regisztracio();

            var actualResult = regisztracio.ValidatePassword(password);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [
            Test,
            TestCase("Teszt", false),
            TestCase("TesztElek", false),
            TestCase("teszt elek", false),
            TestCase("TESZT ELEK", false),

            TestCase("Teszt Elek", true)
        ]
        public void TestValidateName(string name, bool expectedResult)
        {
            var regisztracio = new Regisztracio();

            var actualResult = regisztracio.ValidateName(name);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [
            Test,
            TestCase("1", false),
            TestCase("12", false),
            TestCase("123", false),
            TestCase("1234", false),
            TestCase("12345", false),
            TestCase("123456", false),
            TestCase("1234567", false),

            TestCase("12345678", true)
        ]
        public void TestValidatePIN(decimal PIN, bool expectedResult)
        {
            var regisztracio = new Regisztracio();

            var actualResult = regisztracio.ValidatePIN(PIN);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [
            Test,
            TestCase("5555555", false),
            TestCase("30555555", false),
            TestCase("005555555", false),
            TestCase("105555555", false),
            TestCase("405555555", false),
            TestCase("505555555", false),
            TestCase("605555555", false),
            TestCase("905555555", false),
            TestCase("805555555", false),

            TestCase("205555555", true),
            TestCase("305555555", true),
            TestCase("705555555", true)
        ]
        public void TestValidatePhone(string phone, bool expectedResult)
        {
            var regisztracio = new Regisztracio();

            var actualResult = regisztracio.ValidatePhone(phone);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
