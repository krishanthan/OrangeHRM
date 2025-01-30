using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V126.IndexedDB;
using OpenQA.Selenium.Interactions;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ComponentHelper
{
    public class KeyBoardActions
    {
        Actions act= new Actions(ObjectRepo.driver);

        public void ClearTextBox(IWebElement element)
        {

            act.Click(element).KeyDown(Keys.LeftControl).SendKeys("a").KeyDown(Keys.Backspace).KeyUp(Keys.LeftControl).KeyUp(Keys.Backspace).Build().Perform();

        }

    }


}
