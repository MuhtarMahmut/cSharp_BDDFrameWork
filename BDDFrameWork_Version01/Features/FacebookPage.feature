Feature: testing Face book SignUp Page

Background: Environemnt
    Given Website is ready

Scenario: Verify Page Title
   Then Page Title should contains 'Facebook' words

    @Test02
Scenario: Verify Web URL
   Then WebSite adrees shoudl contains 'www.facebook.com'

  @Test01
Scenario: verify sign up button is clickable and then click it
And sign up button should be clickable
Then click the sign up button
But warning messages displayed


	