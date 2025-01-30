using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ComponentHelper
{
    public class WebDriverWaitHelper
    {

        public static void ImplicitWait(int Seconds)
        {
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Seconds);

        }



   
    }
}
