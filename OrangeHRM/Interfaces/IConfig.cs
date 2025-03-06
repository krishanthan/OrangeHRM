using OrangeHRM.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        String GetUserName();
        String GetPassword();
        String GetURL();

         
        int GetPageLoadTimeout();
    }
}
