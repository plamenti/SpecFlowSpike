using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
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

        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            player.Hit(damage);
        }

        [Then(@"My health should now be (.*)")]
        public void ThenMyHealthShouldNowBe(int expectedHealth)
        {
            Assert.Equal(expectedHealth, player.Health);
        }

        [Then(@"I should be death")]
        public void ThenIShouldBeDeath()
        {
            Assert.True(player.IsDead);
        }

        [Given(@"I have a damage resistance of (.*)")]
        public void GivenIHaveADamageResistanceOf(int damageResistance)
        {
            player.DamageResistance = damageResistance;
        }

        [Given(@"I am an Elf")]
        public void GivenIAmAnElf()
        {
            player.Race = "Elf";
        }

        [Given(@"I have the following attributes")]
        public void GivenIHaveTheFollowingAttributes(Table table)
        {
            //string race = table.Rows.First(row => row["attribute"] == "Race")["value"];
            //string resistance = table.Rows.First(row => row["attribute"] == "Resistance")["value"];
            PlayerAttributes attributes = table.CreateInstance<PlayerAttributes>();

            player.Race = attributes.Race;
            player.DamageResistance = attributes.Resistance;
        }

        [Given(@"My character class is set to (.*)")]
        public void GivenMyCharacterClassIsSetToHealer(CharacterClass characterClass)
        {
            player.CharacterClass = characterClass;
        }

        [When(@"Cast a healing spell")]
        public void WhenCastAHealingSpell()
        {
            player.CastHealingSpell();
        }

    }
}
