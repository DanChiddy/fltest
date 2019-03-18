/*
 * Funds Library Automated Test Instructions
This test uses the following pages:
https://www.bbc.com/signin
http://www.bbc.co.uk/weather/
 
Also contained within the zip file should be the following files:
-	Tests.cs
-	LoginPage.cs
-	HomePage.cs
-	WeatherPage.cs
There are 4 basic tests I would like you to complete, detailed below.
It is worth noting that the tests themselves are incomplete and not working due to some files not being included in the zip (for example a base class and a config file). The expectation is not that these files should run when returned to me.
My interest is seeing the code you use and the approach. Feel free to comment any code if you feel it would help explain your approach.
For security reasons I am unable to provide you with a username and password to login into the BBC site. Hopefully you do not mind creating a dummy one for the purpose of this test. 
Although these files contain C# I am happy for you to complete the answers in either C# or Java.
Tests:
1 – When created, please enter the username and password (or a fake password if you do not wish to provide the one you used) into the correct area in one of the .cs files

2 – Open LoginPage.cs. This contains Page Objects for the BBC login page provided above.
The method ‘public homePage Login’ is called by the line ‘HomePage homePage = loginPage.Login("", "");’ from the Tests.cs file.
Please complete the necessary steps in the LoginPage.cs file to allow the test to run through the login process when run. Eg. Enter a username, enter a password, click submit.

3 – Continuing from the question 2 above. In the Tests.cs file you have the will see the test ‘LoginAsAnExistingUser’. Complete the test, add an Assertation so that when the test runs you confirm that login has been successful. 

4 – For the final test we will use WeatherPage.cs and Tests.cs.
Tests.cs contains a test ‘SearchForCurrentWeatherInBristol”. Complete the code in the Test.cs file and the WeatherPage.cs file to be able to search for Bristol on the weather page and confirm the correct results for Bristol were returned.
*/