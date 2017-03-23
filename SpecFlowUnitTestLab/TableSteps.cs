using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
namespace SpecFlowUnitTestLab
{
    [Binding]
    public class TableSteps
    {
        [Given(@"預計資料應有")]
        public void Given預計資料應有(Table table)
        {
            List<ProductDto> products = table.CreateSet<ProductDto>().ToList();
            ScenarioContext.Current["products"] = products;
        }



        [When(@"我按下查詢資枓")]
        public void When我按下查詢資枓()
        {
            var products = ScenarioContext.Current.Get<List<ProductDto>>("products");
            ScenarioContext.Current.Set(products.Count, "actual");

        }


        [Then(@"查詢結果應該有 (.*) 筆")]
        public void Then查詢結果應該有筆(int result)
        {
            var actual = ScenarioContext.Current.Get<int>("actual");
            Assert.AreEqual(actual, result);
            actual.Should().Be(result);
        }
    }

    public class ProductDto
    {
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
