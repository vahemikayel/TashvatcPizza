using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xunit;
using System.Linq;

namespace TestsTraining.Tests
{
    [Binding]
    public class PizzaOrderSteps
    {
        PizzaOrder _pizza;
        List<int> _wholPizza;
        int expected;
        
      
        [Given(@"GetAvergePrice")]
        public void GivenGetAvergePrice()
        {
            _pizza = new PizzaOrder();
        }

        [Given(@"SetPizzasPricies")]
        public void GivenSetPizzasPricies()
        {
            if (_pizza == null)
                _pizza = new PizzaOrder();
        }

        [Given(@"I have entered (.*) , (.*) , (.*)  into the SetPizzasPricies")]
        public void GivenIHaveEnteredIntoTheSetPizzasPricies(int p0, int p1, int p2)
        {
            if (_pizza == null)
                _pizza = new PizzaOrder();
            _pizza.SetPizasPricies(new List<int>() { p0, p1, p2 });
        }


        [Given(@"I have entered (.*) , (.*) , (.*) into the GetAvergePriceFunc")]
        public void GivenIHaveEnteredIntoTheGetAvergePriceFunc(int p0, int p1, int p2)
        {
            //expected= _pizza.GetAvergePrice();
        }
        
        [Then(@"the result should be (.*) on the GetAvergePriceFunc")]
        public void ThenTheResultShouldBeOnTheGetAvergePriceFunc(int p0)
        {
            //Assert.Equal(expected, p0);
        }

        [Given(@"GetTotalPizzaCount")]
        public void GivenGetTotalPizzaCount()
        {
            _wholPizza = _pizza.GetTotalPizzaCount();
        }
        
       
        [Given(@"I have entered (.*) into SetEmployyessCount")]
        public void GivenIHaveEnteredIntoSetEmployyessCount(int p0)
        {
            _pizza.SetEmployeesCount(p0);
        }

        [Given(@"I have entered tuple into SetEemployyeePizzaPairs")]
        public void GivenIHaveEnteredTupleIntoSetEemployyeePizzaPairs(Table table)
        {           
            var axtung = table.Rows.AsEnumerable()
                                   .Select(x => new Tuple<int, int, int>(Convert.ToInt32(x["empl"]), 
                                                                         Convert.ToInt32(x["p1"]),
                                                                         Convert.ToInt32(x["p2"])))
                                   .ToList();

            _pizza.SetEemployyeePizzaPairs(axtung);
        }
    }
}
