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
    }
}
