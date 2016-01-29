using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Drawing;


namespace $safeprojectname$
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            Instance.Manage().Window.Size = new Size(1124, 850);
        }

        public static void Close()
        {
            Instance.Quit();
        }
    }
}
