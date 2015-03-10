using OpenQA.Selenium;
using SeleniumTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Login and Logout Actions
 * 
 */

namespace SeleniumTest.Actions
{
    public class LLAction
    {
        public static void GoTo(string server)
        {
            Driver.Instance.Navigate().GoToUrl(server);
        }

        public static void Login(string email, string password)
        {
            if (MainForm.isPresendSimpleModal)
                MainForm.MainFormDialog().Close();
            
            var loginButton = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='user']/a[2]"), 5);
            if (loginButton != null)
            {
                loginButton.Click();
                var loginVal = Driver.Instance.FindElement(By.Id("username"));
                loginVal.Clear();
                loginVal.SendKeys(email);

                var passVal = Driver.Instance.FindElement(By.Id("password"));
                passVal.Clear();
                passVal.SendKeys(password);

                Driver.Instance.FindElementAndWait(By.XPath("//button[@class='button big alt3 uppercase']")).Click();
            }
        }

        public static void Logout()
        {
            var logoutButton = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='user']//a[@class='delete']"), 5);
            if (logoutButton != null)
            {
                logoutButton.Click();
            }
        }
    }
}
