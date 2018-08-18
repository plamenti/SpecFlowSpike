﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GameCore.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PlayerCharacterFeature : Xunit.IClassFixture<PlayerCharacterFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PlayerCharacter.feature"
#line hidden
        
        public PlayerCharacterFeature(PlayerCharacterFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PlayerCharacter", "\tIn order play the game\r\n\tAs a human player\r\n\tI want my character attributes to b" +
                    "e correctly represented", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("I am a new player", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Health reduction")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Health reduction")]
        [Xunit.InlineDataAttribute("0", "100", new string[0])]
        [Xunit.InlineDataAttribute("40", "60", new string[0])]
        [Xunit.InlineDataAttribute("50", "50", new string[0])]
        public virtual void HealthReduction(string damage, string remainingHealth, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Health reduction", exampleTags);
#line 9
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 10
 testRunner.When(string.Format("I take {0} damage", damage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("My health should now be {0}", remainingHealth), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Taking too much damage should results in player death")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Taking too much damage should results in player death")]
        public virtual void TakingTooMuchDamageShouldResultsInPlayerDeath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Taking too much damage should results in player death", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 20
 testRunner.When("I take 100 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("I should be death", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Elf race characters get additional 20 damage resistance")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Elf race characters get additional 20 damage resistance")]
        public virtual void ElfRaceCharactersGetAdditional20DamageResistance()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elf race characters get additional 20 damage resistance", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 24
 testRunner.And("I have a damage resistance of 10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I am an Elf", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("I take 40 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("My health should now be 90", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Elf race characters get additional 20 damage resistance using data table")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Elf race characters get additional 20 damage resistance using data table")]
        public virtual void ElfRaceCharactersGetAdditional20DamageResistanceUsingDataTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elf race characters get additional 20 damage resistance using data table", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "attribute",
                        "value"});
            table1.AddRow(new string[] {
                        "Race",
                        "Elf"});
            table1.AddRow(new string[] {
                        "Resistance",
                        "10"});
#line 30
 testRunner.And("I have the following attributes", ((string)(null)), table1, "And ");
#line 34
 testRunner.When("I take 40 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("My health should now be 90", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Healers restore all health")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Healers restore all health")]
        public virtual void HealersRestoreAllHealth()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Healers restore all health", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 38
 testRunner.Given("My character class is set to Healer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.When("I take 40 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.And("Cast a healing spell", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("My health should now be 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Total magic power")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Total magic power")]
        public virtual void TotalMagicPower()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Total magic power", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value",
                        "power"});
            table2.AddRow(new string[] {
                        "Ring",
                        "200",
                        "100"});
            table2.AddRow(new string[] {
                        "Amulet",
                        "400",
                        "200"});
            table2.AddRow(new string[] {
                        "Gloves",
                        "100",
                        "400"});
#line 44
 testRunner.Given("I have the following magical items", ((string)(null)), table2, "Given ");
#line 49
 testRunner.Then("My total magical power should be 700", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Reading a restore health scroll when over tired has no effect")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Reading a restore health scroll when over tired has no effect")]
        public virtual void ReadingARestoreHealthScrollWhenOverTiredHasNoEffect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reading a restore health scroll when over tired has no effect", ((string[])(null)));
#line 51
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 52
 testRunner.Given("I last slept 3 days ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
 testRunner.When("I take 40 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.And("I read a restore health scroll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.Then("My health should now be 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Weapons are worth money")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Weapons are worth money")]
        public virtual void WeaponsAreWorthMoney()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Weapons are worth money", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Sword",
                        "50"});
            table3.AddRow(new string[] {
                        "Pick",
                        "40"});
            table3.AddRow(new string[] {
                        "Knife",
                        "10"});
#line 58
 testRunner.Given("I have the following weapons", ((string)(null)), table3, "Given ");
#line 63
 testRunner.Then("My weapons should be worth 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Elf race characters don\'t lose magical item power")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Elf race characters don\'t lose magical item power")]
        public virtual void ElfRaceCharactersDontLoseMagicalItemPower()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elf race characters don\'t lose magical item power", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 66
 testRunner.Given("I am an Elf", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
 testRunner.And("I have an Amulet with a power of 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.When("I use a magical Amulet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("Amulet power should not be reduced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PlayerCharacterFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PlayerCharacterFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
