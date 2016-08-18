using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FabrikamFiberCalcBillNS;

namespace MyProject.Specs
{
    [Binding]
    public class FabrikamFiberBillCalcSteps_SpecFlow
    {
        private int result { get; set; }
        private FabrikamFiberCalcBill FabrikamFiberCalcBill = new FabrikamFiberCalcBill();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            FabrikamFiberCalcBill.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            FabrikamFiberCalcBill.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = FabrikamFiberCalcBill.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}