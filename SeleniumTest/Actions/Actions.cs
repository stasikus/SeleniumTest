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
        public static bool isLogined()
        {
            var content = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='wrap']//div[@class='content']"));

            if (content != null)
                return true;

            return false;
        }

        public static bool checkNameAndSurname(string expName, string expSurname)
        {
            string actualNameSurname = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='user']//li[1]/a")).Text;

            if (actualNameSurname == expName + " " + expSurname)
                return true;

            return false;
        }

        public static bool checkAccNum(string expectedAccNum)
        {
            string actualAccNum = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='form-with-side']/dl[2]/dd[2]")).Text;

            if (actualAccNum == expectedAccNum)
                return true;

            return false;
        }

        public static bool changeLanguage(string language)
        {
            MainForm.MainFormDialog().Language(language);

            var actualLang = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='language']/ul//a[contains(text(),'" + language + "')]"));

            if (actualLang != null)
                return true;
            else
                MainForm.MainFormDialog().Close();

            return false;
        }

        public static bool changeFilter(string countryFilter)
        {
            MainForm.MainFormDialog().Filter(countryFilter);

            var chosenCountry = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='countries']//ul[@class='clearfix']"));

            if (chosenCountry.Text != "")
            {
                MainForm.MainFormDialog().Close();
                return true;
            }
            else
                MainForm.MainFormDialog().Close();

            return false;
        }
        
    }
}
