using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumTest;
using SeleniumTest.Utils;
using SeleniumTest.Actions;


namespace UITest
{
    public class BaseTest
    {
        [TestFixtureSetUp]
        public void Initialize()
        {
            Driver.Initialize(Config.Webdriver); //type of driver
            DriverWait.Initialize(2);
            Driver.BrowserMaximize();

            LLAction.GoTo(Config.Host); // go to webpage
            LLAction.Login(Config.LoginName, Config.LoginPass); // login
        }

        [TestFixtureTearDown]
        public void Cleanup()
        {
            LLAction.Logout(); //logout

            Driver.Wait(3);
            Driver.Close();
        }
    }
}
