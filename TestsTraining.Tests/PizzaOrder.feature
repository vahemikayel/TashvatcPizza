Feature: PizzaOrder
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Input Pizzas
	Given PizzaOrder
	And I have entered <val> into the calculator
	When I press add 
	Then the result should be <res> on the screen
	Examples: 
	| val | res |
	| 1000  | 1000 |
	| 1250  | 1250 |
	| 1400  | 1400 |


