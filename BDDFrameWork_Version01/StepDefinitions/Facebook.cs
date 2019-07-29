using System;
using BDDFrameWork_Version01.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDDFrameWork_Version01
{
    [Binding]
    [Obsolete]
    public class Facebook : TestBase
    {
        

        [Given(@"Website is ready")]
        public void GivenWebsiteIsReady()
        {
            
        }

        [Then(@"Page Title should contains '(.*)' words")]
        public void ThenPageTitleShouldContainsWords(string facebook)
        {
            Assert.True(driver.Title.Contains(facebook));
        }


        [Then(@"WebSite adrees shoudl contains '(.*)'")]
        public void ThenWebSiteAdreesShoudlContains(string p0)
        {
            Assert.True(driver.Url.Contains(p0));
        }

       

        [Given(@"sign up button should be clickable")]
        public void GivenSignUpButtonShouldBeClickable()
        {
            Assert.True(FB.SignUpButton.Enabled);
        }

        [Then(@"click the sign up button")]
        public void ThenClickTheSignUpButton()
        {
            FB.SignUpButton.Click();
            Library.TakeScreenShotPLZ("Muhtar");

        }

      

        [Then(@"warning messages displayed")]
        public void ThenWarningMessagesDisplayed()
        {
            Assert.True(FB.WarningMessage.Displayed);
        }
    }
}
