using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using System.IO;

namespace SeleniumTest.Utils
{
    public class Driver
    {
        public static IWebDriverExt Instance { get; private set; }

        public enum drivers
        {
            IE,
            Firefox,
            Chrome
        }

        public static void Initialize(string driver)
        {
            //driver = "Firefox";

            switch (driver)
            {
                case "Firefox":
                    FirefoxProfile properties = new FirefoxProfile();
                    properties.SetPreference("profile", "default");
                    Instance = new FirefoxDriverExt();
                    break;
                case "IE":
                    Instance = new InternetExplorerDriverExt(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest");
                    break;
                case "Chrome":
                    Instance = new ChromeDriverExt(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest");
                    break;
            }

            //Setting Implicit Wait timeout
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
        }

        //Maximize Browser window
        public static void BrowserMaximize()
        {
            Instance.Manage().Window.Maximize();
        }

        //Close Driver
        public static void Close()
        {
            Instance.Dispose();
        }

        //Thread sleep
        public static void Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

    }
}
