using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OrangeHRM.ComponentHelper;
using OrangeHRM.Configuration;
using OrangeHRM.CustomException;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OrangeHRM.BaseClasses
{

    [Binding]
    public class BaseClass
    {
        static ScenarioContext _scenarioContext;
        static FeatureContext _FeatureContext;

        public BaseClass(ScenarioContext context, FeatureContext FeatureCon)
        {
            _scenarioContext = context;
            _FeatureContext = FeatureCon;

        }

        private static ChromeOptions GetChromeOptions()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;

        }

        private static InternetExplorerOptions IEOptions()
        {

            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            return options;

        }
        private static IWebDriver GetFireFoxDriver()
        {

            IWebDriver driver = new FirefoxDriver();
            return driver;

        }

        private static IWebDriver GetChromeDriver()
        {

            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;

        }

        private static IWebDriver GetIEExplorerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(IEOptions());
            return driver;

        }



        [BeforeFeature]
        [Given(@"the user launch the browser")]
        public static void giventheuserlaunchthebrowser()
        {
            //  console.writeline(_scenariocontext.scenarioinfo.title);
            ObjectRepo.Config = new AppConfigRead();

            switch (ObjectRepo.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepo.driver = GetChromeDriver();
                    break;

                case BrowserType.FireFox:
                    ObjectRepo.driver = GetFireFoxDriver();
                    break;

                case BrowserType.IEExplorer:
                    ObjectRepo.driver = GetIEExplorerDriver();
                    break;

                default:
                    throw new NoSuchDriverException("driver not found");
            }



        }


        [AfterFeature]
        [Then(@"The User Close the Browser")]
        public static void ThenTheUserCloseTheBrowser()
        {
            if (ObjectRepo.driver != null)
            {
                ObjectRepo.driver.Close();
                ObjectRepo.driver.Quit();
            }
        }



    }
}
