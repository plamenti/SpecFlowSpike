using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    [Binding]
    public class CommonPlayerCharacterSteps
    {
        private readonly PlayerCharacterStepsContext context;

        public CommonPlayerCharacterSteps(PlayerCharacterStepsContext context)
        {
            this.context = context;
        }

        [Given(@"I am a new player")]
        public void GivenIAmANewPlayer()
        {
            context.Player = new PlayerCharacter();
        }
    }
}
