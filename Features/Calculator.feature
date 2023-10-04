Feature: SpecFlowFeature1
	Simple command for an online transaction


@Browser:Chrome
Scenario: Purchase a macbook
	Given the user navigates to the website
	When the user purchases a macbook
	Then the trasaction should succeed
