using TechTalk.SpecFlow;
using Xunit;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private PlayerCharacter player;

        [Given(@"I am a new player")]
        public void GivenIAmANewPlayer()
        {
            player = new PlayerCharacter();
        }
        
        [When(@"I take 0 damage")]
        public void WhenITake0Damage()
        {
            player.Hit(0);
        }
        
        [Then(@"My health should now be 100")]
        public void ThenMyHealthShouldNowBe()
        {
            Assert.Equal(100, player.Health);
        }
    }
}
