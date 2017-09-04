Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given Calculator 
	And I have entered 70 into the calculator
	And I have entered 90 into the calculator
	When I press add 
	Then the result should be 160 on the screen

Scenario: Exception when one argument is not supplied
	Given Calculator 
	And I have entered 70 into the calculator	
	Then adding couses OperandsNullException exception

Scenario: Subtract two numbers
	Given Calculator 
	And I have entered 70 into the calculator
	And I have entered 90 into the calculator
	When I press subtract 
	Then the result should be -20 on the screen

Scenario Outline: Get Absolute value
	Given Calculator
	And I have entered <val> into the calculator
	When I press absolute	 
	Then the result should be <res> on the screen

	Examples: 
	| val | res |
	| 50  | 50  |
	| -7  | 7   |
	| 0   | 0   |
