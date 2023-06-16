using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waits_In_Selenium_Csharp.ExplicitWaits
{
   public class ExplicitWaits : DriverInitialization.Base
    {

        //Dynamic Explicit Waits
        //Explicitwait - StalenessOf
        public bool WaitForStalenessOf(IWebElement element, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.StalenessOf(element));
                        result = true;
                        Console.WriteLine("Wait Till StalenessOf : Element Loaded successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitForStalenessOf() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitForStalenessOf() : " + ex.Message);
            }
            return result;
        }

        //Explicitwait - ElementExists
        public bool WaitTillElementExists(By locator, double waitTimeInSeconds) 
        {
            bool result = false;

            try 
            {
                for(int i = 0; i <= 10; i++)
                {
                    try 
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.ElementExists(locator));
                        result = true;
                        Console.WriteLine("Wait Till ElementExists : Element existed successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitTillElementExists() : " + ex.Message);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                result = false;
                Console.WriteLine("WaitTillElementExists() : " + ex.Message);
            }
            return result;
        }

        //Explicitwait - ElementIsVisible using By Locator
        public bool WaitTillElementIsVisible(By locator, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.ElementIsVisible(locator));
                        result = true;
                        Console.WriteLine("Wait Till ElementIsVisible : Element is visible successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitTillElementIsVisible() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitTillElementIsVisible() : " + ex.Message);
            }
            return result;
        }

        //Explicitwait - ElementToBeClickable using By Locator
        public bool WaitForElementToBeClickable(By locator, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.ElementToBeClickable(locator));
                        result = true;
                        Console.WriteLine("Wait for ElementToBeClickable : Element is ready to click");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitForElementToBeClickable() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitForElementToBeClickable() : " + ex.Message);
            }
            return result;
        }


        //Explicitwait - ElementToBeClickable using WebElement
        public bool WaitForElementToBeClickable(IWebElement element, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.ElementToBeClickable(element));
                        result = true;
                        Console.WriteLine("Wait for ElementToBeClickable : Element is ready to click");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitForElementToBeClickable() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitForElementToBeClickable() : " + ex.Message);
            }
            return result;
        }

        //Explicitwait - ElementToBeSelected using By Locator
        public bool WaitTillElementToBeSelected(By locator, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.ElementToBeSelected(locator));
                        result = true;
                        Console.WriteLine("Wait Till ElementToBeSelected : Element is Selected successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitTillElementToBeSelected() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitTillElementToBeSelected() : " + ex.Message);
            }
            return result;
        }

        //Explicitwait - ElementToBeSelected using WebElement
        public bool WaitTillElementToBeSelected(IWebElement element, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.ElementToBeSelected(element));
                        result = true;
                        Console.WriteLine("Wait Till ElementToBeSelected : Element is Selected successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitTillElementToBeSelected() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitTillElementToBeSelected() : " + ex.Message);
            }
            return result;
        }
       
        //Explicitwait - ElementToBeSelected using WebElement with Boolean value
        public bool WaitTillElementToBeSelectedIsTrue(IWebElement element, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.ElementToBeSelected(element,true));
                        result = true;
                        Console.WriteLine("Wait Till ElementToBeSelected : Element is Selected successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitTillElementToBeSelected() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitTillElementToBeSelected() : " + ex.Message);
            }
            return result;
        }
        //Explicitwait - ElementSelectionStateToBe using By Locator
        public bool WaitTillElementSelectionStateToBeTrue(By locator, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.ElementSelectionStateToBe(locator,true));
                        result = true;
                        Console.WriteLine("Wait Till ElementSelectionStateToBeTrue : Element is Selected successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitTillElementSelectionStateToBeTrue() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitTillElementToBeSelected() : " + ex.Message);
            }
            return result;
        }

        //Explicitwait - ElementSelectionStateToBe using By WebElement
        public bool WaitTillElementSelectionStateToBeTrue(IWebElement element, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.ElementSelectionStateToBe(element, true));
                        result = true;
                        Console.WriteLine("Wait Till ElementSelectionStateToBeTrue : Element is Selected successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitTillElementSelectionStateToBeTrue() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitTillElementToBeSelected() : " + ex.Message);
            }
            return result;
        }

        //Explicitwait - TextToBePresentInElement
        public bool WaitForTextToBePresentInElement(IWebElement element, string text, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.TextToBePresentInElement(element,text));
                        result = true;
                        Console.WriteLine("Wait For TextToBePresentInElement : Text in the element is presented successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitForTextToBePresentInElement() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitForTextToBePresentInElement() : " + ex.Message);
            }
            return result;
        }

        //Explicitwait - TextToBePresentInElementLocated using By Locator
        public bool WaitForTextToBePresentInElementLocated(By locator, string text, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.TextToBePresentInElementLocated(locator, text));
                        result = true;
                        Console.WriteLine("Wait For TextToBePresentInElementLocated : Text in the element is presented successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitForTextToBePresentInElementLocated() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitForTextToBePresentInElementLocated() : " + ex.Message);
            }
            return result;
        }
        //Explicitwait - TextToBePresentInElementValue using By Locator
        public bool WaitForTextToBePresentInElementValue(By locator, string text, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.TextToBePresentInElementValue(locator, text));
                        result = true;
                        Console.WriteLine("Wait For TextToBePresentInElementValue : Text in the element is presented successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitForTextToBePresentInElementValue() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitForTextToBePresentInElementValue() : " + ex.Message);
            }
            return result;
        }

        //Explicitwait - TextToBePresentInElementValue using WebElement
        public bool WaitForTextToBePresentInElementValue(IWebElement element, string text, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.TextToBePresentInElementValue(element, text));
                        result = true;
                        Console.WriteLine("Wait For TextToBePresentInElementValue : Text in the element is presented successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitForTextToBePresentInElementValue() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitForTextToBePresentInElementValue() : " + ex.Message);
            }
            return result;
        }
        //Explicitwait - InvisibilityOfElementLocated using By Locator
        public bool WaitTillInvisibilityOfElementLocated(By locator, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
                        result = true;
                        Console.WriteLine("Wait Till InvisibilityOfElementLocated : Invisible element is located successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("WaitTillInvisibilityOfElementLocated() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("WaitTillInvisibilityOfElementLocated() : " + ex.Message);
            }
            return result;
        }
        //Explicitwait - InvisibilityOfElementWithText using By Locator with Text
        public bool VerifyInvisibilityOfElementWithText(By locator, string text, double waitTimeInSeconds)
        {
            bool result = false;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    try
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeInSeconds));
                        wait.Until(ExpectedConditions.InvisibilityOfElementWithText(locator, text));
                        result = true;
                        Console.WriteLine("Wait Till InvisibilityOfElementWithText : Invisible element text is verified successfully");
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Retrying times - " + i);
                        if (i == 10)
                        {
                            Console.WriteLine("VerifyInvisibilityOfElementWithText() : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("VerifyInvisibilityOfElementWithText() : " + ex.Message);
            }
            return result;
        }
    }
}
