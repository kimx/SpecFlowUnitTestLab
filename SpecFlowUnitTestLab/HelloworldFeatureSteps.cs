using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowUnitTestLab
{
    [Binding]
    public class HelloworldFeatureSteps
    {
        [Given(@"我輸入 ""(.*)"" 為名字")]
        public void Given我輸入為名字(string firstName)
        {
            ScenarioContext.Current.Set(firstName, "firstName");
        }

        [Given(@"我輸入 ""(.*)"" 為姓")]
        public void Given我輸入為姓(string secondName)
        {
            ScenarioContext.Current.Set(secondName, "secondName");
        }

        [When(@"我按下查詢")]
        public void When我按下查詢()
        {
            var secondName = ScenarioContext.Current.Get<string>("secondName");
            var firstName = ScenarioContext.Current.Get<string>("firstName");
            ScenarioContext.Current.Set($"{firstName} {secondName}", "fullName");

        }

        [Then(@"應為 ""(.*)""")]
        public void Then應為(string result)
        {
            var fullName = ScenarioContext.Current.Get<string>("fullName");
            Assert.AreEqual(fullName, result);
        }

    }
}
