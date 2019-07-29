using System;
using System.Threading;
using BDDFrameWork_Version01.Utilities;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace BDDFrameWork_Version01
{
    [Binding]
    [Obsolete]
    public class Hooks : TestBase
    {
       

        [BeforeScenario( "@Test01", "@Test02")]    // that's a tag
        public void BeforeScenario()
        {
            BeforeScenarios();

        }

        [AfterScenario]
        public void TearDown()
        {
            AfterScenarios();
           
        }

        

      

    }
}
