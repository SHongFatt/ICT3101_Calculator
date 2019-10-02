using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class AddtionalSteps1
    {
        private Calculator _calculator;
        private int result;
        public AddtionalSteps1(Calculator calculator)
        {
            this._calculator = calculator;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
           // _calculator = new Calculator();
            result = _calculator.SpecialAdd(p0, p1);
            
        }
        
        [Then(@"the result should be ""(.*)"" on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }
    }
}
