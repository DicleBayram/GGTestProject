﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GGTestProject.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GittiGidiyor")]
    public partial class GittiGidiyorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GittiGidiyor.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GittiGidiyor", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GittiGidiyorSepeteEkle")]
        [NUnit.Framework.CategoryAttribute("GittiGidiyorAddToBasket")]
        public virtual void GittiGidiyorSepeteEkle()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GittiGidiyorSepeteEkle", null, new string[] {
                        "GittiGidiyorAddToBasket"});
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.And("GittiGidiyor anasayfası açılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 6
 testRunner.And("Açılan popup için daha sonra butonu tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 7
 testRunner.And("Giriş yap butonu üzerine gelinir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 8
 testRunner.And("Giriş yap butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 9
 testRunner.And("Email alanına \'bayramdicleggtestautomation@hotmail.com\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 10
 testRunner.And("Sifre alanına \'123456gg\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 11
 testRunner.And("Üye girişi ekranında giriş yap butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 12
 testRunner.And("Elektronik menüsü üzerine gelinir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 13
 testRunner.And("Kulaklık menüsü tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 14
 testRunner.And("İlk ürün seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 15
 testRunner.And("Sepete Ekle butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
