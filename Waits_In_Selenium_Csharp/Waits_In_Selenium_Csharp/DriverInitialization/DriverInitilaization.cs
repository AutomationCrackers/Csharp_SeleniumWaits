using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Waits_In_Selenium_Csharp.DriverInitialization
{
   public class DriverInitilaization : DriverInitialization.Base
    {
       public void LaunchChrome() 
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }
        public void LaunchFirefox()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
        }

        public void BrowserSetup()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
        }
    }
}
