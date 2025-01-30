using OpenQA.Selenium;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ComponentHelper
{
    public class NavigationHelper
    {

        public static void NavigatetoURL(String url)
        {
            ObjectRepo.driver.Navigate().GoToUrl(url);
        }

        #region DriverNavigation
        public static void NavigationBack()
        {
            ObjectRepo.driver.Navigate().Back();
        }

        public static void NavigationForward()
        {
            ObjectRepo.driver.Navigate().Forward();

        }



        public static void RefreshPage()
        {
            ObjectRepo.driver.Navigate().Refresh();
        }

        #endregion
        #region Windows Screen
        public static void MaximizeScreen()
        {
            ObjectRepo.driver.Manage().Window.Maximize();
        }

        public static void MinimizeScrren()
        {
            ObjectRepo.driver.Manage().Window.Minimize();


        }

        public static void FullScreen()
        {
            ObjectRepo.driver.Manage().Window.FullScreen();

        }




        #endregion
        #region HandleMultipleWindows
        public static void HandleMultipleWindow(int IndexPage = 0)
        {
            //Window used all the tab by id

            IReadOnlyList<String> tabs = ObjectRepo.driver.WindowHandles;

            if (tabs.Count < IndexPage)
            {
                throw new NoSuchWindowException("Invalid windows index " + IndexPage);
            }

            else
            {
                ObjectRepo.driver.SwitchTo().Window(tabs[IndexPage]);
                ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                MaximizeScreen();

            }

        }

        #endregion
        #region SwitchToIframe

        public static void SwitchToIFrameByID(int IframeID)
        {
            ObjectRepo.driver.SwitchTo().Frame(IframeID);

        }

        public static void SwitchToIFrameByElement(By locator)
        {
            ObjectRepo.driver.SwitchTo().Frame(ObjectRepo.driver.FindElement(locator));

        }

        public static void SwitchToIFrameByName(String Name)
        {
            ObjectRepo.driver.SwitchTo().Frame(Name);

        }

        public static void SwitchToDefaultContent()
        {
            ObjectRepo.driver.SwitchTo().DefaultContent();

        }

        #endregion




















    }
}
