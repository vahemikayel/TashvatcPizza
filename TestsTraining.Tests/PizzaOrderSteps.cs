using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace TestsTraining.Tests
{
    [Binding]
    public class PizzaOrderSteps
    {
        private int _employyeeCount;
        private Dictionary<int, decimal> _pizzas = new Dictionary<int, decimal>();

        [Given(@"PizzaOrder")]
        public void GivenPizzaOrder()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
