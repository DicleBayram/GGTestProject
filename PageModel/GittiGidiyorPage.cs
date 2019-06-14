using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;

namespace GittiGidiyorTestAutomation.Page {
    [Binding]
    [TestFixture]
    public class GittiGidiyorPage : Base {
        [FindsBy(How = How.Id, Using = "later-subscription-button")]
        public IWebElement btnCloseSubscription { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".profile-icon-container~.profile-icon-title")]
        public IWebElement btnProfileIcon { get; set; }


        [FindsBy(How = How.Id, Using = "SignIn")]
        public IWebElement btnSignin { get; set; }


        [FindsBy(How = How.Id, Using = "L-UserNameField")]
        public IWebElement txtEmail { get; set; }


        [FindsBy(How = How.Id, Using = "L-PasswordField")]
        public IWebElement txtPassword { get; set; }


        [FindsBy(How = How.Id, Using = "gg-login-enter")]
        public IWebElement btnLogin { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='header_wrapper']/div[6]/div[1]/p")]
        public IWebElement btnElectronicMenu { get; set; }


        [FindsBy(How = How.CssSelector, Using = "a[href = '//www.gittigidiyor.com/kulaklik']")]
        public IWebElement btnHeadPhone { get; set; }


        [FindsBy(How = How.Id, Using = "item-info-block-448656674")]
        public IWebElement btnFirstItem { get; set; }


        [FindsBy(How = How.Id, Using = "add-to-basket")]
        public IWebElement btnBasket { get; set; }

        public GittiGidiyorPage(IWebDriver _driver) : base(_driver) {
        }

        public void CloseSubscriptionPopUp() {
            if (btnCloseSubscription.Displayed)
                btnCloseSubscription.Click();
        }

        public void HoverLogin() {
            Hover(btnProfileIcon);
        }

        public void FillLoginEmailInfo(string email) {
            SetText(txtEmail, email);
        }

        public void FillLoginPasswordInfo(string password) {
            SetText(txtPassword, password);
        }

        public void ClickSignin() {
            btnSignin.Click();
        }

        public void ClickLoginEnter() {
            btnLogin.Click();
        }

        public void ElectronicHoverMenuItem() {
            btnElectronicMenu.Click();
        }

        public void ClickHeadPhoneItem() {
            btnHeadPhone.Click();
        }

        public void ClickFirstItem() {
            btnFirstItem.Click();
        }

        public void ClickAddToBasket() {
            btnBasket.Click();
        }
    }
}
