using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waits_In_Selenium_Csharp.DriverInitialization;

namespace Waits_In_Selenium_Csharp.ImplicitWaitSynchronization
{
   public class ImplicitWaitSync : Base
    {
       
        public void ImplicitWaitSynchronization()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(45);
        }
    }
}
