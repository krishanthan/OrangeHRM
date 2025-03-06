using OpenQA.Selenium;
using OrangeHRM.Settings;
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
            if (element.Displayed)
            {
                element.Click();
            }

            else
            {
                throw new NoSuchElementException();
            }

        }

        public static void ClickBtnOption(IReadOnlyList<IWebElement> AlldropdownButton, String ButtonName)
        {
            if (ObjectRepo.driver != null)
            {
                for (int i = 0; i < AlldropdownButton.Count; i++)
                {
                    if (Convert.ToString(AlldropdownButton[i].Text) == ButtonName)
                    {
                        AlldropdownButton[i].Click();
                    }

                }
            }

            else
            {
                throw new NoSuchElementException();
            }
        }
    }



    #endregion ClickButton
}
