using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCP.SpecflowTests.Pages
{
    public class RCPPage
    {
        #region elements

        public static readonly By Menu_MyDashboard = By.XPath("//span[./text()='My Dashboard']");
        public static readonly By Menu_MyCPDActivitiesList = By.XPath("//span[./text()='My CPD Activities List']");

        #endregion elements
    }
}
