using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.Utils;

namespace SeleniumTest.Actions
{
    public class Actions
    {
        public static bool checkNameAndSurname(string name, string surname)
        {
            string nameSurname = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='user']//li[1]/a")).Text;

            if (nameSurname == name + " " + surname)
                return true;

            return false;
        }
    }
}
