Feature: Compare products
As a user
I want to compare different products
In order to find a most suitable product for me

As a user
I want to see only difference of products in comparison
In order to see what makes this product unique

As a user
I want to delete products from comparison
In order to exclude the least suitable products from the comparison

Background:
	Given user is on the Homepage

Scenario: Add a 2 vitamins B6 into the comparison
	When user clicks on Search field
	And user enters the Search Query "Витамин B6" in the search field
	And user clicks Enter key on the keyboard
	Then user is on the Search result page
	When user clicks on the add to comparison button on the first vitamin on the page
	And user clicks on the add to comparison button on the second vitamin on the page
	And user clicks on the button with scales icon
	Then user is on the page with the comparison of the chosen products

Scenario: Switch the parametrs list for only differences between vitamins
	When user clicks on Search field
	And user enters the Search Query "Витамин B6" in the search field
	And user clicks Enter key on the keyboard
	Then user is on the Search result page
	When user clicks on the add to comparison button on the first vitamin on the page
	And user clicks on the add to comparison button on the second vitamin on the page
	And user clicks on the button with scales icon
	Then user is on the page with the comparison of the chosen products
	When user clicks on the Comparison Only button
	Then user sees only differences between chosen products in the parametrs table

Scenario: Delete a vitamin from the comparison
	When user clicks on Search field
	And user enters the Search Query "Витамин B6" in the search field
	And user clicks Enter key on the keyboard
	Then user is on the Search result page
	When user clicks on the add to comparison button on the first vitamin on the page
	And user clicks on the add to comparison button on the second vitamin on the page
	And user clicks on the button with scales icon
	Then user is on the page with the comparison of the chosen products
	When user clicks on the button with the X icon on the first vitamin in the comparison list
	Then user sees changed list of comparisons

Scenario: Find the article in the "Витамины" category
    When user clicks on Blog Link
	Then user is on the blog page
	When user clicks on the Vitamins category button
	Then user is on the page with the articles from the chosen category