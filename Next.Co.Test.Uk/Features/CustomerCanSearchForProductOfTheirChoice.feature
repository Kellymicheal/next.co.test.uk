Feature: CustomerCanSearchForProductOfTheirChoice
	In order to purchase products of my choice
	As a customer
	I want the ability to search for product of my choice.


Scenario Outline:CustomerCanSearchForProductsOfTheirChoice'
	Given i navigate to next homepage
	When i enter "<Product>" of my choice
	And click on submit button
	Then searching product page displayed.




Scenarios:
| Product      |
| Men's wear   |
| ladie's wear |