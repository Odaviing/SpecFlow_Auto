﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestProject5.Feature_File
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CompareProductsFeature : object, Xunit.IClassFixture<CompareProductsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "featureNumberTwo.feature"
#line hidden
        
        public CompareProductsFeature(CompareProductsFeature.FixtureData fixtureData, TestProject5_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature_File", "Compare products", @"As a user
I want to compare different products
In order to find a most suitable product for me

As a user
I want to see only difference of products in comparison
In order to see what makes this product unique

As a user
I want to delete products from comparison
In order to exclude the least suitable products from the comparison", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 14
#line hidden
#line 15
 testRunner.Given("user is on the Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add a 2 vitamins B6 into the comparison")]
        [Xunit.TraitAttribute("FeatureTitle", "Compare products")]
        [Xunit.TraitAttribute("Description", "Add a 2 vitamins B6 into the comparison")]
        public virtual void AddA2VitaminsB6IntoTheComparison()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a 2 vitamins B6 into the comparison", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
this.FeatureBackground();
#line hidden
#line 18
 testRunner.When("user clicks on Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.And("user enters the Search Query \"Витамин B6\" in the search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("user clicks Enter key on the keyboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("user is on the Search result page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.When("user clicks on the add to comparison button on the first vitamin on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.And("user clicks on the add to comparison button on the second vitamin on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("user clicks on the button with scales icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.Then("user is on the page with the comparison of the chosen products", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Switch the parametrs list for only differences between vitamins")]
        [Xunit.TraitAttribute("FeatureTitle", "Compare products")]
        [Xunit.TraitAttribute("Description", "Switch the parametrs list for only differences between vitamins")]
        public virtual void SwitchTheParametrsListForOnlyDifferencesBetweenVitamins()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Switch the parametrs list for only differences between vitamins", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
this.FeatureBackground();
#line hidden
#line 28
 testRunner.When("user clicks on Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.And("user enters the Search Query \"Витамин B6\" in the search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("user clicks Enter key on the keyboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.Then("user is on the Search result page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("user clicks on the add to comparison button on the first vitamin on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.And("user clicks on the add to comparison button on the second vitamin on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("user clicks on the button with scales icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Then("user is on the page with the comparison of the chosen products", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.When("user clicks on the Comparison Only button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("user sees only differences between chosen products in the parametrs table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Delete a vitamin from the comparison")]
        [Xunit.TraitAttribute("FeatureTitle", "Compare products")]
        [Xunit.TraitAttribute("Description", "Delete a vitamin from the comparison")]
        public virtual void DeleteAVitaminFromTheComparison()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete a vitamin from the comparison", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
this.FeatureBackground();
#line hidden
#line 40
 testRunner.When("user clicks on Search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.And("user enters the Search Query \"Витамин B6\" in the search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("user clicks Enter key on the keyboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.Then("user is on the Search result page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.When("user clicks on the add to comparison button on the first vitamin on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.And("user clicks on the add to comparison button on the second vitamin on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("user clicks on the button with scales icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.Then("user is on the page with the comparison of the chosen products", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.When("user clicks on the button with the X icon on the first vitamin in the comparison " +
                        "list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("user sees changed list of comparisons", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Find the article in the \"Витамины\" category")]
        [Xunit.TraitAttribute("FeatureTitle", "Compare products")]
        [Xunit.TraitAttribute("Description", "Find the article in the \"Витамины\" category")]
        public virtual void FindTheArticleInTheВитаминыCategory()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find the article in the \"Витамины\" category", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
this.FeatureBackground();
#line hidden
#line 52
    testRunner.When("user clicks on Blog Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("user is on the blog page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When("user clicks on the Vitamins category button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("user is on the page with the articles from the chosen category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CompareProductsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CompareProductsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
