using OpenQA.Selenium;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ComponentHelper
{
    public class TextBoxHelper
    {
        public static void AutoSuggestListTextBox(String SendKeys, IWebElement element, IReadOnlyList<IWebElement> AllElementDropDown, String Name)
        {
            element.SendKeys(SendKeys);
            try
            {
                for (int i = 0; i < AllElementDropDown.Count; i++)
                {
                    if (Convert.ToString(AllElementDropDown[i].Text) == Name)
                    {
                        AllElementDropDown[i].Click();
                    }
                }
            }

            catch (NoSuchElementException)
            {


            }



        }

        public static void TypeIn(IWebElement element,String SendKeys)
        {
           

            if (element.Displayed)
            {
                element.SendKeys(SendKeys);
               
            }

            else
            {
               throw new NoSuchElementException();
                
            }


        }

  
    }
}
