using OpenQA.Selenium;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ComponentHelper
{
    public class JavaScripHandler
    {

        IJavaScriptExecutor executor = ((IJavaScriptExecutor)ObjectRepo.driver);

        public static bool IsAlertPresent()
        {
            try
            {
                ObjectRepo.driver.SwitchTo().Alert();
                return true;


            }

            catch (NoAlertPresentException)
            {

                return false;

            }

        }


        public static String ReadAlertMessage(String alertMessage)
        {

            if (IsAlertPresent())
            {
                IAlert alert = ObjectRepo.driver.SwitchTo().Alert();
                alertMessage = alert.Text;
                return alertMessage;

            }

            else
            {
                throw new NoAlertPresentException();
            }

        }
        public static void AcceptAlert()
        {
            if (IsAlertPresent())
            {
                IAlert alert = ObjectRepo.driver.SwitchTo().Alert();
                alert.Accept();
            }

            else { throw new NoAlertPresentException();}
        }

        public static void DismissAlert()
        {
            if (IsAlertPresent())
            {
                IAlert alert = ObjectRepo.driver.SwitchTo().Alert();
                alert.Dismiss();
            }

            else { throw new NoAlertPresentException(); }
        }

        public static void PromptResponse(String PromptMessage)
        {
            {
                if (IsAlertPresent())
                {
                    IAlert alert = ObjectRepo.driver.SwitchTo().Alert();
                    alert.SendKeys(PromptMessage);
                }

                else { throw new NoAlertPresentException(); }
            }

        }


  





    }
}
