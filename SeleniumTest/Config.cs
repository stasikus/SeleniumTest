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
    }
}
