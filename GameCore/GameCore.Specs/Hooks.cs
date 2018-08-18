using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    // Inheriting Steps makes Hooks class thread safe 
    [Binding]
    public class Hooks : Steps
    {
        // using hooks with tags limit the their execution to the scenarios decorated with these specific tags
        [BeforeScenario("elf")]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
