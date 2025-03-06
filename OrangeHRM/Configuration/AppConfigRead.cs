using OrangeHRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Configuration
{
    public class AppConfigRead : IConfig
    {
        public BrowserType GetBrowser()
        {

            String browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
              return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            //return (BrowserType)Enum.GetValues(typeof(BrowserType));

        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
           
        }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserName);
        }

        public string GetURL()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.URL);
        }

        public int GetPageLoadTimeout()
        {
            String Timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeOut);
            if (Timeout == null)
            {
                return 30;
            }

            return Convert.ToInt32(Timeout);
        }

    
    }
}
