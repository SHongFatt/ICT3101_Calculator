using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
   
    [Binding]

    public class AddtionalSteps
    {
        private  Calculator calculator;
        private double result = 0.0;

        public AddtionalSteps(Calculator calculator)
        {
            this.calculator = calculator;
            this.calculator.changeI(8);
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            //calculator = new Calculator();
        }
        
        [Given(@"I have entered ""(.*)"" and ""(.*)"" and press add")]
        public void GivenIHaveEnteredAndAndPressAdd(int p0, int p1)
        {
            result = calculator.Add(p0, p1);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(result,Is.EqualTo(p0));
            Assert.That("8", Is.EqualTo(calculator.showI()));

        }
    }
}
