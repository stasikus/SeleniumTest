using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SeleniumTest
{
    public class Config
    {
        private static string host;
        private static string loginName;
        private static string loginPass;
        private static string name;
        private static string surname;
        private static string accNu;
        private static string language;
        private static string filterCountry;
        private static string webdriver;
        static XmlDocument xDoc = new XmlDocument();

        public static string Host
        {
            get 
            {
                xDoc.Load(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest\\Configuration.xml");
                host = xDoc.SelectSingleNode("/Configuration/webpage").InnerText.ToString() ;
                return host; 
            }
            
        }

        public static string LoginName
        {
            get
            {
                xDoc.Load(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest\\Configuration.xml");
                loginName = xDoc.SelectSingleNode("/Configuration/login").InnerText.ToString();
                return loginName;
            }
        }

        public static string LoginPass
        {
            get
            {
                xDoc.Load(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest\\Configuration.xml");
                loginPass = xDoc.SelectSingleNode("/Configuration/password").InnerText.ToString();
                return loginPass;
            }
        }

        public static string Name
        {
            get
            {
                xDoc.Load(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest\\Configuration.xml");
                name = xDoc.SelectSingleNode("/Configuration/name").InnerText.ToString();
                return name;
            }
        }

        public static string Surname
        {
            get
            {
                xDoc.Load(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest\\Configuration.xml");
                surname = xDoc.SelectSingleNode("/Configuration/surname").InnerText.ToString();
                return surname;
            }
        }

        public static string Accnum
        {
            get
            {
                xDoc.Load(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest\\Configuration.xml");
                accNu = xDoc.SelectSingleNode("/Configuration/accNu").InnerText.ToString();
                return accNu;
            }
        }

        public static string Language
        {
            get
            {
                xDoc.Load(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest\\Configuration.xml");
                language = xDoc.SelectSingleNode("/Configuration/language").InnerText.ToString();
                return language;
            }
        }

        public static string FilterCountry
        {
            get
            {
                xDoc.Load(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest\\Configuration.xml");
                filterCountry = xDoc.SelectSingleNode("/Configuration/filterCountry").InnerText.ToString();
                return filterCountry;
            }
        }
        
        public static string Webdriver
        {
            get
            {
                xDoc.Load(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\SeleniumTest\\Configuration.xml");
                webdriver = xDoc.SelectSingleNode("/Configuration/webdriver").InnerText.ToString();
                return webdriver;
            }
        }
    }
}
