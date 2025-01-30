using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ComponentHelper
{
    public class DropDownList

    {
        private SelectElement select;
        public void SelectElemetByText(IWebElement element, String VisibleText)
        {
            select = new SelectElement(element);
            select.SelectByText(VisibleText);

        }

        public void SelectElemetByIndex(IWebElement element, int index)
        {
            select = new SelectElement(element);
            select.SelectByIndex(index);

        }

        public IList<String> GetSelectedBoxTest(IWebElement element)
        {
            select = new SelectElement(element);
            return select.Options.Select((x => x.Text)).ToList();


        }

        public static void AutoSuggestListDropDown(IReadOnlyList<IWebElement> AllElementDropDown, String Name)
        {
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





    }
}
