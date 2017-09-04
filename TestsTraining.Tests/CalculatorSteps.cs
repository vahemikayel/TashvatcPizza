using System;
using TechTalk.SpecFlow;
using Xunit;

namespace TestsTraining.Tests
{
    [Binding]
    public class CalculatorSteps
    {
        Calculator _calculator;

        [Given(@"Calculator")]
        public void GivenCalculator()
        {
            _calculator = new Calculator();
        }
        
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _calculator.Input(p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _calculator.Add();
        }
        
        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _calculator.Subtract();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.Equal(p0, _calculator.Result);
        }
        
        [Then(@"adding couses OperandsNullException exception")]
        public void ThenAddingCousesOperandsNullExceptionException()
        {
            Assert.Throws<OperandsNullException>(() => _calculator.Add());
        }
        [When(@"I press absolute")]
        public void WhenIPressAbsolute()
        {
            _calculator.Abs();
        }

    }

}
