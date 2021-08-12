Feature: Step1
	Selecting values for options and entering address

Scenario: Navigation from Step 1 to Step 2 selecting necessary values
	Given I'm on step 1 page
	When I select the vehicle type
	And I select engine capacity
	And I enter the address
	And I select the permit duration
	And click on Next button
	Then I'm on Step 2 of 7
	