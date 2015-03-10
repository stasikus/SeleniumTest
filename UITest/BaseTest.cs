using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumTest;
using SeleniumTest.Utils;


namespace UITest
{
    public class BaseTest
    {
        [TestFixtureSetUp]
        public void Initialize()
        {
            Driver.Initialize(Driver.drivers.Chrome.ToString());
            DriverWait.Initialize(2);

            //Driver.BrowserMaximize();
        }

        [TestFixtureTearDown]
        public void Cleanup()
        {
            Driver.Wait(3);
            Driver.Close();
        }
    }
}
