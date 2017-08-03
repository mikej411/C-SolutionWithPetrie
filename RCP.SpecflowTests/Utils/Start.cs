using TechTalk.SpecFlow;

namespace RCP.SpecflowTests.Utils
{
    public class Start : Driver
    {
        [BeforeScenario]
        public void Setup()
        {
            Initialise();
            Instance.Navigate().GoToUrl(BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Close();
        }
    }
}
