﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ContactIdentificationFeature : Xunit.IClassFixture<ContactIdentificationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Contact Identification.feature"
#line hidden
        
        public ContactIdentificationFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Contact Identification", "As a sales person \r\nI want to show that Sitecore tracks the indentifiction of a v" +
                    "isitor \r\nso that I can show the we know a person across visits", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(ContactIdentificationFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Contact Identification")]
        [Xunit.TraitAttribute("Description", "Accounts_Contact Identification_UC1_Identification is shown in the demo contact p" +
            "anel")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Accounts_ContactIdentification_UC1_IdentificationIsShownInTheDemoContactPanel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Contact Identification_UC1_Identification is shown in the demo contact p" +
                    "anel", new string[] {
                        "NeedImplementation"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("Actor clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("Actor expands Identification section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("Contact ID term with it\'s ID presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("Identifier is empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("Identification status is <None>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number of visits"});
            table1.AddRow(new string[] {
                        "1"});
#line 15
 testRunner.And("System shows following info on Contact panel title", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Contact Identification")]
        [Xunit.TraitAttribute("Description", "Accounts_Contact Identification_UC2_Identification is shown in the demo contact p" +
            "anel for just registered user")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Accounts_ContactIdentification_UC2_IdentificationIsShownInTheDemoContactPanelForJustRegisteredUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Contact Identification_UC2_Identification is shown in the demo contact p" +
                    "anel for just registered user", new string[] {
                        "NeedImplementation"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table2.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 22
 testRunner.And("Actor entered following data in to the register fields", ((string)(null)), table2, "And ");
#line 25
 testRunner.And("Actor clicked Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.And("User expands Identification section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("Contact ID term with it\'s ID presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.And("Identifier is <extranet\\kov@sitecore.net>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("Identification status is <Known>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number of visits"});
            table3.AddRow(new string[] {
                        "1"});
#line 31
 testRunner.And("System shows following info on Contact panel title", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Contact Identification")]
        [Xunit.TraitAttribute("Description", "Accounts_Contact Identification_UC3_Identification is shown in the demo contact p" +
            "anel for logged in user")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Accounts_ContactIdentification_UC3_IdentificationIsShownInTheDemoContactPanelForLoggedInUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Contact Identification_UC3_Identification is shown in the demo contact p" +
                    "anel for logged in user", new string[] {
                        "NeedImplementation"});
#line 36
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table4.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 37
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table4, "Given ");
#line 40
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number of visits"});
            table5.AddRow(new string[] {
                        "1"});
#line 41
 testRunner.And("System contained following info on Contact panel title", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table6.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 44
 testRunner.When("Actor enteres following data into Login page fields", ((string)(null)), table6, "When ");
#line 47
 testRunner.And("Actor clicks Login button on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("User expands Identification section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then("Contact ID term with it\'s ID presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.And("Identifier is <extranet\\kov@sitecore.net>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("Identification status is <Known>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number of visits"});
            table7.AddRow(new string[] {
                        "2"});
#line 53
 testRunner.And("System shows following info on Contact panel title", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Contact Identification")]
        [Xunit.TraitAttribute("Description", "Accounts_Contact Identification_UC4_Start a new session")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Accounts_ContactIdentification_UC4_StartANewSession()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Contact Identification_UC4_Start a new session", new string[] {
                        "NeedImplementation"});
#line 59
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table8.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 60
 testRunner.Given("User is registered in Habitat and logged in", ((string)(null)), table8, "Given ");
#line 63
 testRunner.And("Identification section in the demo contact panel is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("Contact ID term with it\'s ID presented", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("Identifier was <extranet\\kov@sitecore.net>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("Identification status was <Known>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number of visits"});
            table9.AddRow(new string[] {
                        "2"});
#line 67
 testRunner.And("System shown following info on Contact panel title", ((string)(null)), table9, "And ");
#line 70
 testRunner.When("User clicks END VISIT button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("User expands Identification section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.Then("System shows the same Contact ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number of visits"});
            table10.AddRow(new string[] {
                        "3"});
#line 74
 testRunner.And("System shows following info on Contact panel title", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Contact Identification")]
        [Xunit.TraitAttribute("Description", "Accounts_Contact Identification_UC5_Clear browser cookies")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Accounts_ContactIdentification_UC5_ClearBrowserCookies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Contact Identification_UC5_Clear browser cookies", new string[] {
                        "NeedImplementation"});
#line 80
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table11.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 81
testRunner.Given("User is registered in Habitat and logged in", ((string)(null)), table11, "Given ");
#line 84
 testRunner.And("Identification section in the demo contact panel is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("Contact ID term with it\'s ID presented", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("Identifier was <extranet\\kov@sitecore.net>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("Identification status was <Known>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number of visits"});
            table12.AddRow(new string[] {
                        "2"});
#line 88
 testRunner.And("System shown following info on Contact panel title", ((string)(null)), table12, "And ");
#line 91
 testRunner.When("clear browser cookies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table13.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 92
 testRunner.And("login with following user", ((string)(null)), table13, "And ");
#line 95
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("User expands Identification section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.Then("System shows the same Contact ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.And("Identifier is <extranet\\kov@sitecore.net>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("Identification status is <Known>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number of visits"});
            table14.AddRow(new string[] {
                        "3"});
#line 100
 testRunner.And("System shows following info on Contact panel title", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ContactIdentificationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ContactIdentificationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
