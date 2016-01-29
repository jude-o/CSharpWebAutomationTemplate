using OpenQA.Selenium;
using System;


namespace $safeprojectname$
{
    public class BasePage
    {
        public void Navigate(string url)
        {
            Driver.Instance.Navigate().GoToUrl(url);
        }
        public void Execute(By by, Action<IWebElement> action)
        {
            var element = Driver.Instance.FindElement(by);
            action(element);
        }
    }
}
