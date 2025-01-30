using OpenQA.Selenium;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ComponentHelper
{
    public class ElementHelper
    {

        public static String GetText(IWebElement element)
        {
            if (element.Displayed && element.Text != null)
            {
                return element.Text;
            }

            else
            {
                throw new NoSuchElementException();
            }



        }

        public static String GetAttributeValue(IWebElement element)
        {
            if (ObjectRepo.driver != null && element.Displayed)
            { 
            return element.GetAttribute("value");
            }

            else
            {
                return null;
            }
        }

        public static String GetPageTitle()
        {
            if (ObjectRepo.driver != null)
            {

                return ObjectRepo.driver.Title;

            }

            else
            {
                return null;
            }


        }

        public static String GetPageURL()
        {
            if (ObjectRepo.driver != null)
            {
                return ObjectRepo.driver.Url;
            }

            else
            {
                throw new NoSuchWindowException();
            }
        }

        public static bool isDisplayed(IWebElement element)
        {
            if (ObjectRepo.driver != null)
            {
                return element.Displayed;

            }
            else
            {
                return false;
            }
        }


    }

}

