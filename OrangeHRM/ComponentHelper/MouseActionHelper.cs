using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ComponentHelper
{
    public class MouseActionHelper
    {
      public static Actions act = new Actions(ObjectRepo.driver);


        public static void DragAndDrop(IWebElement DesiredElement, IWebElement TargetElement)
        {
            act.DragAndDrop(DesiredElement, TargetElement).Build().Perform();

        }
        public static void ClickMoveElement(IWebElement DesiredElement, IWebElement TargetElement)
        {
            act.ClickAndHold(DesiredElement).MoveToElement(TargetElement).Release().Build().Perform();

        }

        public static void MoveToElement(IWebElement element)
        {
            act.MoveToElement(element).Build().Perform();

        }

        public static void CopyText(IWebElement element)
        {
            act.MoveToElement(element);
            act.KeyDown(Keys.Control).SendKeys("a").SendKeys("c").KeyUp(Keys.Control).Build().Perform();


        }

        public static void PasteText(IWebElement element)
        {
            act.MoveToElement(element).Click().KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Build().Perform();
        }








    }
}
