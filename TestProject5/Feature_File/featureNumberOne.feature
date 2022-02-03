Feature: Search the medicine
As a user
I want to find a medicine via search field
In order to find a specific product

As a user
I want to choose a category
In order to search a medicine in chosen category

As a user
I want to find medicine using filters
In order to search a medicine with a different requirements

Background:
	Given user is on the homepage

Scenario: Find a vitamin B6 via search field
	When user clicks on search field
	And user enters the search query "Витамин B6" in the search field
	And user clicks Enter on the keyboard
	Then user is on the search result page


Scenario: Find all products in Vitamins for stress category
	When user clicks on the Categories drop-down menu
	And user clicks on the Vitamins by symptoms category
	Then user is on the page with subcategories from the chosen category
	When user clicks on the Vitamins for stress subcategory
	Then user is on the page with the products from the chosen subcategory


Scenario: Find a vitamin B6 from brand AB PRO NUTRITION with a discount
	When user clicks on search field
	And user enters the search query "Витамин B6" in the search field
	And user clicks Enter on the keyboard
	Then user is on the search result page
	When user clicks on the In stock filter
	And user clicks on the AB PRO NUTRITION manufacturer filter
	Then user is on the page with the products chosen by filters


Scenario: Choose the article in the blog
	When user clicks on Blog link
	Then user is o the blog page