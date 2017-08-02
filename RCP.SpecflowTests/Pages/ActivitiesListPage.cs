using OpenQA.Selenium;
using RCP.SpecflowTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RCP.SpecflowTests.Pages
{
    public class ActivitiesListPage
    {
        #region elements

        // Main page
        public static readonly By EnterACPDActivityBtn = By.Id("ctl00_ContentPlaceHolder1_lnkAddActivity");
        public static readonly By ActivityTblBody = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_ctrlCPDActivities_grdCPDActiity_ctl00']/tbody");

        // Delete Activity Window
        public static readonly By DeleteActivityForm = By.XPath("//div[@id='RadWindowWrapper_confirm1501100671184']");
        public static readonly By DeleteActivityFormOkBtn = By.XPath("//span[contains(.,'OK')]");
        public static readonly By DeleteActivityFormCancelBtn = By.XPath("//span[contains(.,'Cancel')]");

        // Locator examples
        public static readonly By a = By.CssSelector("button.app-navbar-toggle.collapsed");
        public static readonly By c = By.CssSelector("button[data-id='person-filter']");
        public static readonly By z = By.XPath("//*[@id='person-grid']/tbody");
        public static readonly By x = By.XPath("(//div[@id='person_tooltip'])[1]");
        public static readonly By v = By.XPath("//span[contains(.,'Delete Person')]");
        public static readonly By b = By.XPath("//button[@id='items-lnk']/span[1]");
        public static readonly By n = By.XPath("//div[@class='bootstrap-dialog-header']/div[@class='bootstrap-dialog-close-button']");
        public static readonly By m = By.XPath("//button[@id='filters-demos']/..");
        public static readonly By s = By.XPath("//li[@id='webapp-menu-person']/a");

        #endregion elements


        #region selenium

        public static void ClickEnterCPDActivityForm()
        {
            Driver.Click(EnterACPDActivityBtn);
        }

        public static void FillOutForm()
        {
            //TODO: Enter the steps here
        }

        public static void DeleteActivity()
        {
            //TODO: Enter the steps here
        }


        public static void VerifyActivityAppearsOnTable()
        {
            //TODO: Enter the steps here
        }

        public static void VerifyActivityNotOnTable()
        {
            //TODO: Enter the steps here
        }

        #endregion selenium
    }
}
