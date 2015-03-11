using OpenQA.Selenium;
using SeleniumTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Whole actions related to Main Form with languages
 * 
 */

namespace SeleniumTest.Actions
{
    public class MainForm
    {
        public static bool isPresendSimpleModal
        {
            get
            {
                //IWebElement mainFormElement = Driver.Instance.IsElementPresent(By.XPath("//div[@id='simplemodal-container']")); //if the main form is present
                var mainFormElement = Driver.Instance.FindElementAndWait(By.XPath("//div[@id='simplemodal-container']")); //if the main form is present
                
                if (mainFormElement != null)
                {
                    return true;
                }
                return false;
            }
        }

        public static AllActionsMainForm MainFormDialog()
        {
            return new AllActionsMainForm();
        }
    }

    public class AllActionsMainForm
    {
        public AllActionsMainForm Close()
        {
            try
            {
                var mainFormElement = Driver.Instance.FindElementAndWait(By.XPath("//div[@id='simplemodal-container']")); //if the main form is present
                
                if (mainFormElement != null)
                {
                    Driver.Instance.FindElement(By.XPath("//div[@id='simplemodal-container']/a[@class='modalCloseImg simplemodal-close']")).Click();
                }
            }
            catch (Exception)
            {
                
            }
            return this;
        }

        public AllActionsMainForm Language(string language)
        {
            try
            {
                Driver.Instance.FindElementAndWait(By.XPath("//div[@class='language']/a[@class='open-country-chooser']")).Click(); //open language form

                Driver.Instance.FindElementAndWait(By.XPath("//ul[@class='clearfix']/li[@data-country='xx']/a[@class='more_languages']")).Click(); //add new language

                Driver.Instance.FindElementAndWait(By.XPath("//div[@class='simplemodal-wrap']//div[@class='languages']//a[contains(text(),'" + language + "')]")).Click(); //choose language
            }
            catch (Exception)
            {

            }
            return this;
        }
    }
}
