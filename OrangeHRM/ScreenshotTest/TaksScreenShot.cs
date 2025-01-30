using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OrangeHRM.Settings;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.ScreenshotTest
{
    public static class TakeScreenShot
    {
        public static void SaveScreenshot(String FileName)
        {
            Screenshot screen = ObjectRepo.driver.TakeScreenshot();
            screen.SaveAsFile(FileName);
        }
    }
}
