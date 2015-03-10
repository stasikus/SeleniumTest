using SeleniumTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Actions
{
    public class LoginAction
    {
        public static void GoTo(string server)
        {
            Driver.Instance.Navigate().GoToUrl(server);
        }
    }
}
