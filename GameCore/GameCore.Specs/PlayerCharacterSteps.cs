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
        private readonly PlayerCharacterStepsContext context;

        public PlayerCharacterSteps(PlayerCharacterStepsContext context)
        {
            this.context = context;
        }

        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            context.Player.Hit(damage);
        }

        [When(@"I take (.*) damage")]
        [Scope(Tag = "elf")]
        public void WhenITakeDamageAsAnElf(int damage)
        {
            context.Player.Hit(damage);
        }

        [Then(@"My health should now be (.*)")]
        public void ThenMyHealthShouldNowBe(int expectedHealth)
        {
            Assert.Equal(expectedHealth, context.Player.Health);
        }

        [Then(@"I should be death")]
        public void ThenIShouldBeDeath()
        {
            Assert.True(context.Player.IsDead);
        }

        [Given(@"I have a damage resistance of (.*)")]
        public void GivenIHaveADamageResistanceOf(int damageResistance)
        {
            context.Player.DamageResistance = damageResistance;
        }

        [Given(@"I am an Elf")]
        public void GivenIAmAnElf()
        {
            context.Player.Race = "Elf";
        }

        [Given(@"I have the following attributes")]
        public void GivenIHaveTheFollowingAttributes(Table table)
        {
            //string race = table.Rows.First(row => row["attribute"] == "Race")["value"];
            //string resistance = table.Rows.First(row => row["attribute"] == "Resistance")["value"];
            PlayerAttributes attributes = table.CreateInstance<PlayerAttributes>();

            context.Player.Race = attributes.Race;
            context.Player.DamageResistance = attributes.Resistance;
        }

        [Given(@"My character class is set to (.*)")]
        public void GivenMyCharacterClassIsSetToHealer(CharacterClass characterClass)
        {
            context.Player.CharacterClass = characterClass;
        }

        [When(@"Cast a healing spell")]
        public void WhenCastAHealingSpell()
        {
            context.Player.CastHealingSpell();
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
            context.Player.MagicalItems.AddRange(items);
        }

        [Then(@"My total magical power should be (.*)")]
        public void ThenMyTotalMagicalPowerShouldBe(int expectedTotalMagicalPower)
        {
            Assert.Equal(expectedTotalMagicalPower, context.Player.MagicPower);
        }

        [Given(@"I last slept (.* days ago)")]
        public void GivenILastSleptDaysAgo(DateTime lastSlept)
        {
            context.Player.LastSleepTime = lastSlept;
        }

        [When(@"I read a restore health scroll")]
        public void WhenIReadARestoreHealthScroll()
        {
            context.Player.ReadHealthScroll();
        }

        [Given(@"I have the following weapons")]
        public void GivenIHaveTheFollowingWeapons(IEnumerable<Weapon> weapons)
        {
            context.Player.Weapons.AddRange(weapons);
        }

        [Then(@"My weapons should be worth (.*)")]
        public void ThenMyWeaponsShouldBeWorth(int value)
        {
            Assert.Equal(value, context.Player.WeaponsValue);
        }

        [Given(@"I have an (.*) with a power of (.*)")]
        public void GivenIHaveAnAmuletWithAPowerOf(string name, int power)
        {
            // add amulet to player's magical items
            context.Player.MagicalItems.Add(new MagicalItem { Name = name, Power = power });

            // store the starting power so it can be retrieved in Then step
            context.StartingMagicalPower = power;
        }

        [When(@"I use a magical (.*)")]
        public void WhenIUseAMagicalAmulet(string name)
        {
            context.Player.UseMagicalItem(name);
        }

        [Then(@"Amulet power should not be reduced")]
        public void ThenAmuletPowerShouldNotBeReduced()
        {
            // get starting magical power from When step
            int expectedPower = context.StartingMagicalPower;

            Assert.Equal(expectedPower, context.Player.MagicalItems.First(x => x.Name == "Amulet").Power);
        }

    }
}
