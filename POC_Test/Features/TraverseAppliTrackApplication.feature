Feature: To Login to application and validate functionality of available options on dashboard
 check if the user is succesfully able to log into the system and perform the desired operations

 Background: User should have correct user credentials to login

@smoke
Scenario: Check user login with correct user name and password and other features available
	Given User has entered the correct application url on browser
	| Url |
	| https://www.applitrack.com/dex/    |
	And the application is loaded correctly
	When User entered correct Username and Password
		| Username | Password |
	    | tryout   | tryout   |
	
	When User clicks on MyDashbard icon to visit News and Activitis section
    And  User clicks on ClickNews section to validate Message board
	And  User clicks on Recent Activities button to validate Recent vacancies available
	Then User closed the browser
	

	
   


	
	

