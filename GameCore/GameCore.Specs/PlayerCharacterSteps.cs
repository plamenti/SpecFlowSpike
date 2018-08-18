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
        public void ThenMyHealthShouldNowBe100()
        {
            Assert.Equal(100, player.Health);
        }

        [When(@"I take 40 damage")]
        public void WhenITake40Damage()
        {
            player.Hit(40);
        }

        [Then(@"My health should now be 60")]
        public void ThenMyHealthShouldNowBe60()
        {
            Assert.Equal(60, player.Health);
        }

        [When(@"I take 100 damage")]
        public void WhenITake100Damage()
        {
            player.Hit(100);
        }

        [Then(@"I should be death")]
        public void ThenIShouldBeDeath()
        {
            Assert.True(player.IsDead);
        }

    }
}
