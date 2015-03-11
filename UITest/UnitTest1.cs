using System;
using SeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTest;
using SeleniumTest.Utils;
using SeleniumTest.Actions;

namespace UITest
{
    [TestFixture]
    public class UnitTest1 : BaseTest
    {
        //[Test]
        //public void Login()
        //
            
        //}

        [Test(Description = "Check if user logined")]
        public void Test1()
        {
            NUnit.Framework.Assert.AreEqual(true, Actions.isLogined(), "error to login");
        }

        [Test (Description="Check name and surname")]
        public void Test2()
        {
            NUnit.Framework.Assert.AreEqual(true, Actions.checkNameAndSurname(Config.Name, Config.Surname), "error description");
        }

        //[Test]
        //public void Logout()
        //{
            
        //}
    }
}
