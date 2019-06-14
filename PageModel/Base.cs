using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace GittiGidiyorTestAutomation.Page {
    public class Base {

        private IWebDriver _driver;

        public Base(IWebDriver driver) {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public IWebElement Find(By by) {
            return _driver.FindElement(by);
        }

        public void Hover(IWebElement btn) {
            Actions action = new Actions(_driver);
            action.MoveToElement(btn).Build().Perform();
        }

        public void SetText(IWebElement txt, string text) {
            txt.SendKeys(text);
        }
    }
}
