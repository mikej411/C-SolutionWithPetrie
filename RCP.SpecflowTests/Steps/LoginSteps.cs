using OpenQA.Selenium.Support.PageObjects;
using RCP.SpecflowTests.Pages;
using RCP.SpecflowTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RCP.SpecflowTests.Steps
{
    [Binding]
    public class LoginSteps : Start
    {
        [Given(@"I am on the Login page")]
        public void GivenIAmOnTheLoginPage()
        {
            PageFactory.InitElements(Instance, this);
        }

        [When(@"I click on the Login button")]
        public void WhenIClickOnTheLoginButton()
        {
            LoginPage.ClickLoginButton();
        }

        [When(@"I login as a valid user")]
        public void WhenILoginAsAValidUser()
        {
            LoginPage.LoginAsValidUser();
        }

        [When(@"I login as an invalid user")]
        public void WhenILoginAsAnInvalidUser()
        {
            LoginPage.LoginAsInvalidUser();
        }


        [Then(@"a validation error to enter my username is displayed")]
        public void ThenAValidationErrorToEnterMyUsernameIsDisplayed()
        {
            LoginPage.VerifyEnterUsernameError();
        }

        [Then(@"the username validation error text is red")]
        public void ThenTheUsernameValidationErrorTextIsRed()
        {
            LoginPage.VerifyUsernameValidationErrorColor();
        }

        [Then(@"I am redirected to the next page")]
        public void ThenIAmRedirectedToTheNextPage()
        {
            LoginPage.VerifyLoginSuccessful();
        }

        [Then(@"a login attempt validation error is displayed")]
        public void ThenALoginAttemptValidationErrorIsDisplayed()
        {
            LoginPage.VerifyLoginAttemptError();
        }

    }
}
