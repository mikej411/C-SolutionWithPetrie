using NUnit.Framework;
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
    public class EnterCPDActivityPage
    {
        #region elements 
        public static readonly By EnterACPDFrame = By.XPath("//iframe[@name='wndAddActivity']");
        public static readonly By Sec1GroupLearnActSel = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_fb1_ctl06_ctl11_CEComboBox3126029");
        public static readonly By Sec1GroupLearnActSelOption = By.CssSelector("option");
        public static readonly By ActivityAccrYesRdo = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_fb1_ctl06_ctl19_3126066|1");
        public static readonly By ActivityAccrNoRdo = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_fb1_ctl06_ctl19_3126066|2");
        public static readonly By HoursTxt = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_fb1_ctl06_ctl59_t3126006");
        public static readonly By GroupActivityNameTxt = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_fb1_ctl06_ctl60_t3126028");
        public static readonly By DateTxt = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_fb1_ctl06_ctl63_dtbDatePicker3126032_dateInput");
        public static readonly By WhatDidYouLearnTxt = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_txtLearn");
        public static readonly By WhatAdditLearningTxt = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_txtAffirm");
        public static readonly By WhatChangesTxt = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_txtPractice");
        public static readonly By AddFilesBtn = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_DocUpload1_RadUploadFilesfile0");
        public static readonly By CancelBtn = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_btnCancel");
        public static readonly By SendToHoldingBtn = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_btnSaveAndFinishLater");
        public static readonly By ContinueBtn = By.Id("ctl00_ContentPlaceHolder1_AddEditExternalFormActivity1_btnSubmit");

        public static readonly By SubmitBtn = By.Id("ctl00_ContentPlaceHolder1_btnSubmitOptional");

        public static readonly By CloseBtn = By.Id("ctl00_ContentPlaceHolder1_btnClose3");

        #endregion elements


        #region selenium

        public static void VerifyActivitiesDropdownOptions(Table table)
        {
            List<string> expectedOptions = new List<string>();
            IEnumerable<string> headings = table.Rows.Select(o => o["dropdownOption"]);
            foreach (string o in headings)
                expectedOptions.Add(o);

            List<string> actualOptions = new List<string>();

            foreach (var dropdownOption in Driver.Instance.FindElement(Sec1GroupLearnActSel).FindElements(Sec1GroupLearnActSelOption))
                actualOptions.Add(dropdownOption.Text);

            for (int i = 0; i < actualOptions.Count; i++)
            {
                string expectedOption = expectedOptions[i];
                string actualOption = actualOptions[i];
                Assert.AreEqual(expectedOption, actualOption);
            }
        }

        #endregion selenium
    }
}
