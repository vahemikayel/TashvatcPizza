Feature: PizzaOrder
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Set Pizzas pricies
	Given I have entered 1000 , 1500 , 1800  into the SetPizzasPricies
	Given I have entered 3 into SetEmployyessCount
	Given I have entered tuple into SetEemployyeePizzaPairs
	| empl  | p1	| p2	|
	| 0     | 2     | 0     |
	| 1     | 1     | 1     |
	| 2     | 0     | 1     |
	Given GetTotalPizzaCount
	Given GetAvergePrice
	And I have entered 1000 , 1500 , 1800 into the GetAvergePriceFunc
	Then the result should be 252 on the GetAvergePriceFunc
	




