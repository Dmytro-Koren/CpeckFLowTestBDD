Feature: SpecFlowMenuTest
	In order to easily find needed documentation
	As a cpecflow user
	I want to be able to navigate to serch pages trough main menu and find current search result page 

@smoke
Scenario Outline: Clicking menu option from the main menu should open corresponding page
	Given I open official SpecFlow web site
	When I hover the '<menuItem>' menu item from the main menu
	And I click '<subMenuItem>' option from the main menu 
	And I click on searchField field
	And I input '<inputText>' text to input field 
	And I click to '<searchResult>' result 
	Then Page with '<title>' title should be the same that search request

    Examples: 
	| menuItem | subMenuItem | inputText    | searchResult | title        |
	| Docs     | SpecFlow    | Installation | Installation | Installation |
	