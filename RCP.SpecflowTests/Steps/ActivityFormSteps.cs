using RCP.SpecflowTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RCP.SpecflowTests.Steps
{
    [Binding]
    public class ActivityFormSteps
    {
        [When(@"I click on the Enter a CPD Activity form button")]
        public void WhenIClickOnTheEnterACPDActivityFormButton()
        {
            ActivitiesListPage.ClickEnterCPDActivityForm();
        }

        [When(@"I fill out the form")]
        public void WhenIFillOutTheForm()
        {
            ActivitiesListPage.FillOutForm();
        }

        [When(@"I delete the activity")]
        public void WhenIDeleteTheActivity()
        {
            ActivitiesListPage.DeleteActivity();
        }

        [Then(@"the learning activities dropdown contains the following options")]
        public void ThenTheLearningActivitiesDropdownContainsTheFollowingOptions(Table table)
        {
            EnterCPDActivityPage.VerifyActivitiesDropdownOptions(table);
        }

        [Then(@"the activity shows on the table")]
        public void ThenTheActivityShowsOnTheTable()
        {
            ActivitiesListPage.VerifyActivityAppearsOnTable();
        }

        [Then(@"the activity no longer appears on the table")]
        public void ThenTheActivityNoLongerAppearsOnTheTable()
        {
            ActivitiesListPage.VerifyActivityNotOnTable();
        }

    }
}
