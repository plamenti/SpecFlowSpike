using System;
using System.Collections.Generic;
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

        [Given(@"I have the following magical items")]
        public void GivenIHaveTheFollowingMagicalItems(Table table)
        {
            // Weakly type example
            //foreach (var row in table.Rows)
            //{
            //    var name = row["item"];
            //    var value = row["value"];
            //    var power = row["power"];

            //    player.MagicalItems.Add(new MagicalItem
            //    {
            //        Name = name,
            //        Value = int.Parse(value),
            //        Power = int.Parse(power)
            //    });
            //}

            // Strongly type example
            IEnumerable<MagicalItem> items = table.CreateSet<MagicalItem>();
            player.MagicalItems.AddRange(items);
        }

        [Then(@"My total magical power should be (.*)")]
        public void ThenMyTotalMagicalPowerShouldBe(int expectedTotalMagicalPower)
        {
            Assert.Equal(expectedTotalMagicalPower, player.MagicPower);
        }

        [Given(@"I last slept (.* days ago)")]
        public void GivenILastSleptDaysAgo(DateTime lastSlept)
        {
            player.LastSleepTime = lastSlept;
        }

        [When(@"I read a restore health scroll")]
        public void WhenIReadARestoreHealthScroll()
        {
            player.ReadHealthScroll();
        }

        [Given(@"I have the following weapons")]
        public void GivenIHaveTheFollowingWeapons(IEnumerable<Weapon> weapons)
        {
            player.Weapons.AddRange(weapons);
        }

        [Then(@"My weapons should be worth (.*)")]
        public void ThenMyWeaponsShouldBeWorth(int value)
        {
            Assert.Equal(value, player.WeaponsValue);
        }

        [Given(@"I have an Amulet with a power of (.*)")]
        public void GivenIHaveAnAmuletWithAPowerOf(int p0)
        {
            // TODO: add amulet to player's magical items

            // TODO: store the starting power so it can be retrieved in Then step
        }

        [When(@"I use a magical amulet")]
        public void WhenIUseAMagicalAmulet()
        {
            // TODO: PLAYER CHARACTER INSTANCE.UseMagicalItem("Amulet);
        }

        [Then(@"Amulet power should not be reduced")]
        public void ThenAmuletPowerShouldNotBeReduced()
        {
            int expectedPower;
            // TODO: get starting magical power from When step


            // TODO: Assert.Equal(expectedPower, ACTUAL POWER);
        }

    }
}
