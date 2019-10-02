Feature: Addtional
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Addtion
Scenario: Add two numbers
	Given I have a calculator
	And I have entered "50" and "70" and press add
	Then the result should be "120"


@Addtion1 
Scenario Outline:Add Zero for special case 
	Given I have a calculator
	When I have entered "<value1>" and "<value2>" into the calculator and press add
	Then the result should be "<value3>" on the screen
	Examples: 
	| value1 | value2 | value3 |
	| 0      | 20     | 0      |
	| 20     | 0      | 200    |
	| 0      | 0      | 666    |

