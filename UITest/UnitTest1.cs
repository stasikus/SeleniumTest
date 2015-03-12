using System;
using SeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SeleniumTest;
using SeleniumTest.Utils;
using SeleniumTest.Actions;
using OpenQA.Selenium;

namespace UITest
{
    [TestFixture]
    public class UnitTest1 : BaseTest
    {
        [Test(Description = "Check if user logined")]
        public void Test1()
        {
            bool loginRes = Actions.isLogined();

            if (!loginRes)
            {
                string errorMessage = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='sign-in']//span[@class='field-validation-error']")).Text;
                NUnit.Framework.Assert.AreEqual(true, loginRes, errorMessage);
            }
        }

        [Test (Description="Check name and surname")]
        public void Test2()
        {
            NUnit.Framework.Assert.AreEqual(true, Actions.checkNameAndSurname(Config.Name, Config.Surname), "error description");
        }

        [Test(Description = "Check account number")]
        public void Test3()
        {
            bool accRes = Actions.checkAccNum(Config.Accnum);

            if (!accRes)
            {
                string actualAccNum = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='form-with-side']/dl[2]/dd[2]")).Text;
                NUnit.Framework.Assert.AreEqual(true, accRes, "Error Check acc number. Expected: " + Config.Accnum + " Actual: " + actualAccNum);
            }
        }

        [Test(Description = "Add language")]
        public void Test4()
        {
            bool addedLan = Actions.changeLanguage(Config.Language);

            if (!addedLan)
            {
                NUnit.Framework.Assert.AreEqual(true, addedLan, "Oops, language wasn't added");
            }
        }

        [Test(Description = "Filter")]
        public void Test5()
        {
            bool chosenCountry = Actions.changeFilter(Config.FilterCountry);

            if (!chosenCountry)
            {
                NUnit.Framework.Assert.AreEqual(true, chosenCountry, "No matches with chosen country filter");
            }
        }

    }
}
