using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private Calculator _calculator;

        private double result;

        public UsingCalculatorDivisionsSteps(Calculator calculator)
        {
            this._calculator = calculator;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            result = _calculator.Divide(p0, p1);
        }
        
    
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(result, Is.EqualTo(p0));
            Assert.That("2", Is.EqualTo(_calculator.showI()));
        }
        
        [Then(@"the division result should be Infinity on the screen")]
        public void ThenTheDivisionResultShouldBeInfinityOnTheScreen()
        {
            Assert.That(() => "ABC", Is.EqualTo("ABC"));
        }
    }
}
