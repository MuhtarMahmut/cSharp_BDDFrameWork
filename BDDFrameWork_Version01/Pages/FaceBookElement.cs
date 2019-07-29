using System;
using BDDFrameWork_Version01;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDFrameWork_Version01
{
    [Obsolete]
    public class FaceBookElement : TestBase
    {
        [Obsolete]
        public FaceBookElement()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[text()='Sign Up']")]
        public IWebElement SignUpButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'your name')]")]
        public IWebElement WarningMessage { get; set; }

    }
}
