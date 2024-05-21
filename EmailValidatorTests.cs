using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailValidatorApp;

namespace EmailValidatorTests
{
    [TestClass]
    public class EmailValidatorTests : BaseTest
    {
        [TestInitialize]
        public void Setup()
        {
            TestContext = TestContext;
        }

        [TestMethod]
        public void TestValidEmails()
        {
            string[] validEmails = GetTestParameter("ValidEmails");

            foreach (var email in validEmails)
            {
                Assert.IsTrue(EmailValidator.IsValidEmail(email), $"Expected valid email: {email}");
            }
        }

        [TestMethod]
        public void TestInvalidEmails()
        {
            string[] invalidEmails = GetTestParameter("InvalidEmails");

            foreach (var email in invalidEmails)
            {
                Assert.IsFalse(EmailValidator.IsValidEmail(email), $"Expected invalid email: {email}");
            }
        }
    }
}
