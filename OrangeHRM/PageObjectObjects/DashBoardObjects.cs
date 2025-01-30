using OpenQA.Selenium;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObject
{
    public class DashBoardObjects
    {
        public IWebElement PIM => ObjectRepo.driver.FindElement(By.XPath("//span[text()='PIM']"));
    }
}
