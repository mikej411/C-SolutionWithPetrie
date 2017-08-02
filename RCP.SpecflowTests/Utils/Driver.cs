using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RCP.SpecflowTests.Utils
{
    public class Driver
    {
        public static IWebDriver Instance { get; private set; }
        public static string BaseAddress => ConstantUtils.Url;

        public static void Initialise()
        {
            string location = Assembly.GetExecutingAssembly().Location;
            string driverPath = Path.Combine(Path.GetDirectoryName(location), "drivers");

            // This is run from Visual Studio with a DEBUG build.
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--start-maximized");
            Instance = new ChromeDriver(driverPath, chromeOptions);

            TurnOnWait();
        }

        internal static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }

        public static void Close()
        {
            Instance.Quit();
        }

        internal static void WaitForStalenessOfElement(By element)
        {
            WebDriverWait wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.StalenessOf(Instance.FindElement(element)));
        }

        internal static void WaitForDocumentPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(30));
            wait.Until(driver1 => ((IJavaScriptExecutor)Instance).ExecuteScript("return jQuery.active == 0"));
        }

        internal static void WaitForInvisibilityOfElement(By element)
        {
            WebDriverWait wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(element));
        }


        internal static void WaitForElementVisible(By element)
        {
            WebDriverWait wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }


        public static void Click(By element)
        {
            try
            {
                new WebDriverWait(Instance, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
                Instance.FindElement(element).Click();
            }
            catch (StaleElementReferenceException)
            {
                // simply retry finding the element in the refreshed DOM
                Instance.FindElement(element).Click();
            }
        }

        public static void Clear(By element)
        {
            try
            {
                new WebDriverWait(Instance, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
                Instance.FindElement(element).Clear();
            }
            catch (StaleElementReferenceException)
            {
                // simply retry finding the element in the refreshed DOM
                Instance.FindElement(element).Clear();
            }
        }

        public static void SendKeys(By element, string text)
        {
            try
            {
                new WebDriverWait(Instance, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(element));
                Instance.FindElement(element).SendKeys(text);
            }
            catch (StaleElementReferenceException)
            {
                // simply retry finding the element in the refreshed DOM
                Instance.FindElement(element).SendKeys(text);
            }
        }

        public static void SelectByText(By element, string text)
        {
            try
            {
                new SelectElement(Instance.FindElement(element)).SelectByText(text);
            }
            catch (StaleElementReferenceException)
            {
                // simply retry finding the element in the refreshed DOM
                new SelectElement(Instance.FindElement(element)).SelectByText(text);
            }
        }
    }
}
