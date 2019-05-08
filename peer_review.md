## List of issues found in the existing feature file

1. Feature description has a spelling mistake.
2. There are two `the` in `When I go the the header` sentence
3. Feature is not very clear and does not give the correct idea about what is being tested
4. If we are using Scenario Outline we should use parameters. But in this example no parameters were used but Scenario Outline key word is used.
5. Expected result or assertions of the scenario are not written using `Then` key word
6. Actions are not specific and clear
7. User entered text is not highlighted using quotes



## List of suggestions on how to improve it

1. Feature can be written as `Search functionality for Clearchannel International website` to give a clear idea about the feature to be tested
2. Feature description can be written `As a user I want to be able to search Clearchannel International website so that I can find the information I am looking for`
3. We should use `Scenario` key word instead of `Scenario Outline` key word if we are not using parameters or we have to use parameters if we are using `Scenario Outline`
4. We can use double quotes to highlight the text entered by the user
5. We should use `Then` key word to write expected behaviour
6. We can write two scenarios for this feature so that it will be more clear and will make it easier to isolate errors


As an example I would rewrite the scenario as below and it will provide a clear idea on what we are going to test.
In this web site `Search` is implemented as a modal. So it's not a page and we don't have a searchpage url. That's why I started the 2nd scenario with loading the main web site again. Otherwise we can start with that specific search page url.

**Using scenario without parameters**<br>

**Feature:** Search functionality of Clearchannel International website <br>
As a user I want to be able to search the website
So that I can find the information I am looking for

**Scenario:** Display Search modal <br>
**Given** I am on https://www.clearchannelinternational.com/ <br>
**When** I click search icon on the top right corner of the header <br>
**Then** I see Search textfield and Submit button


**Scenario:** Perform Search<br>
**Given** I am on https://www.clearchannelinternational.com/<br>
**When** I click Search icon on the top right corner of the header<br>
**And** I type "Careers" on the Search field<br>
**And** I click Submit button<br>
**Then** I see Careers link in search results<br>

<br>

**Using scenario outline with parameters**<br>
If we use scenario outline with parameters we can test the same scenario with different inputs.

**Feature:** Search functionality of Clearchannel International website <br>
As a user I want to be able to search the website
So that I can find the information I am looking for

**Scenario:** Display search modal <br>
**Given** I am on https://www.clearchannelinternational.com/ <br>
**When** I click search icon on the top right corner of the header <br>
**Then** I see the Search modal


**Scenario Outline:** Perform Search<br>
**Given** I am on https://www.clearchannelinternational.com/<br>
**When** I click Search icon on the top right corner of the header<br>
**And** I type <User_text> on the Search field<br>
**And** I click Submit button<br>
**Then** I see <Search_results>

**Examples:**<br>
	| User_text | Search_results |<br>
	| Careers	| Careers link   |<br>
	| About Us  | About us link  |<br>