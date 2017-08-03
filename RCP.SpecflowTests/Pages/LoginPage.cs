using NUnit.Framework;
using OpenQA.Selenium;
using RCP.SpecflowTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCP.SpecflowTests.Pages
{
    class LoginPage
    {
        #region elements

        private static readonly By UserNameTxt = By.Id("ctl00_ContentPlaceHolder1_cpLoginAspx_ctl00_LoginControl1_LTLogin_UserName");
        private static readonly By UserNameWarningLbl = By.Id("ctl00_ContentPlaceHolder1_cpLoginAspx_ctl00_LoginControl1_LTLogin_UserNameRequired");
        private static readonly By PasswordTxt = By.Id("ctl00_ContentPlaceHolder1_cpLoginAspx_ctl00_LoginControl1_LTLogin_Password");
        private static readonly By PasswordWarningLbl = By.Id("ctl00_ContentPlaceHolder1_cpLoginAspx_ctl00_LoginControl1_LTLogin_PasswordRequired");
        private static readonly By RememberMeChk = By.Id("ctl00_ContentPlaceHolder1_cpLoginAspx_ctl00_LoginControl1_LTLogin_RememberMe");
        public static readonly By LoginBtn = By.Id("ctl00_ContentPlaceHolder1_cpLoginAspx_ctl00_LoginControl1_LTLogin_Login");
        private static readonly By LoginUnsuccessfullWarningLbl = By.Id("ctl00_ContentPlaceHolder1_cpLoginAspx_ctl00_LoginControl1_LTLogin_FailureText");
        private static readonly By ForgotPasswordLnk = By.Id("ctl00_ContentPlaceHolder1_cpLoginAspx_ctl00_LoginControl1_LTLogin_forgotPasswordbutton");

        #endregion elements

        #region selenium

        public static void ClickLoginButton()
        {
            Driver.Click(LoginBtn);
        }

        public static void VerifyEnterUsernameError()
        {
            Assert.AreEqual("Please enter your username.", Driver.Instance.FindElement(UserNameWarningLbl).Text);
        }

        public static void VerifyUsernameValidationErrorColor()
        {
            Assert.AreEqual("rgba(255, 0, 0, 1)", Driver.Instance.FindElement(UserNameWarningLbl).GetAttribute("color"));
        }

        public static void LoginAsValidUser()
        {
            Driver.SendKeys(UserNameTxt, "ADEULA11");
            Driver.SendKeys(PasswordTxt, "test");
            Driver.SendKeys(PasswordTxt, Keys.Tab);
            Driver.Click(LoginBtn);
            Driver.WaitForInvisibilityOfElement(LoginBtn);
        }

        public static void VerifyLoginSuccessful()
        {
            //TODO: Need to enter code here to confirm the page URL or an element visible on the page confirming user is logged in
        }


        public static void LoginAsInvalidUser()
        {
            Driver.SendKeys(UserNameTxt, "Not a valid user");
            Driver.SendKeys(PasswordTxt, "blah");
            Driver.SendKeys(PasswordTxt, Keys.Tab);

            Assert.False(Driver.Instance.FindElement(UserNameWarningLbl).Displayed);

            Driver.Click(LoginBtn);

            Driver.WaitForElementVisible(LoginUnsuccessfullWarningLbl);
            Assert.AreEqual("rgba(255, 0, 0, 1)", Driver.Instance.FindElement(LoginUnsuccessfullWarningLbl).GetAttribute("color"));
        }

        public static void VerifyLoginAttemptError()
        {
            //TOD: Enter steps here
        }

        #endregion selenium
    }
}
