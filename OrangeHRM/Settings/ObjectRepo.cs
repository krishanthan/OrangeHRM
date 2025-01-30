using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.Interfaces;
using OrangeHRM.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OrangeHRM.Settings
{
    public class ObjectRepo
    {
        public static IConfig Config { get; set; }

        public static IWebDriver driver { get; set; }

        public static WebDriverWait Wait {  get; set; }




    }
}
