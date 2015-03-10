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
        [Test]
        public void Login()
        {
            LoginAction.GoTo(Config.Host);
        }
    }
}
