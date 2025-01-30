using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V125.FedCm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ComponentHelper
{
    public class ButtonHelper
    {
        #region ClickButton
        public static void ClickButton(IWebElement element)
        {
           if(element.Displayed)
            {
                element.Click();
            }

            else
            {
                throw new NoSuchElementException();
            }
        }
    }

    #endregion ClickButton
}
