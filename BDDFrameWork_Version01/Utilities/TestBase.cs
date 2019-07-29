using System;
using System.Threading;
using BDDFrameWork_Version01.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace BDDFrameWork_Version01
{
    [Obsolete]
    public class TestBase
    {

        public static IWebDriver driver;
        public static Actions act;
        public static WebDriverWait wait;
        public static TimeSpan timeout = TimeSpan.FromSeconds(10);


        // Must doi step for each Elements page:
        public  static FaceBookElement FB;



        public static void BeforeScenarios()
        {
            driver = Driver.getDriver();
            driver.Url = ConfigurationReader.getProperties("WebSite");
            driver.Manage().Timeouts().ImplicitWait = timeout;
            act = new Actions(driver);
            wait = new WebDriverWait(driver, timeout);


            FB = new FaceBookElement(); // Must do step
        }


        public static void AfterScenarios()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }

    }
}
