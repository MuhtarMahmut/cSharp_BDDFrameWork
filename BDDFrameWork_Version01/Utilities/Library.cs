using System;
using OpenQA.Selenium;

namespace BDDFrameWork_Version01.Utilities
{
    [Obsolete]
    public class Library : TestBase
    {
        public static void TakeScreenShotPLZ(String saveAs)
        {
            // String DateTime= LocalDate.now().toString()+ LocalTime.now().toString().substring(0,5);


            String now = DateTime.Now.ToString();
            now = now.Replace("/", "").Replace(":", "").Replace(" ", "");


            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            String foldername =
                "/Users/maihemutimuhetaerjiang/Projects/Cucumber_WithMarufjon/BDDFrameWork_Version01/CapturedScreenShots/" + saveAs + "_" + now;
            ss.SaveAsFile(foldername, ScreenshotImageFormat.Png);

        }

    }
}
