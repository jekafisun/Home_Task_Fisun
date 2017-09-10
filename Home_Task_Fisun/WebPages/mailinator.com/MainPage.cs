using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace Home_Task_Fisun.WebPages.mailinator.com
{
    public class MainPage
    {
        IWebDriver driver;

        By loginTextField = By.Id("inboxfield");
        By loginBtn = By.XPath("//span/button");

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public InboxPage LoginMail(string login)
        {
            driver.FindElement(loginTextField).Clear();
            driver.FindElement(loginTextField).SendKeys(login);
            driver.FindElement(loginBtn).Click();
            return new InboxPage(driver);
        }
    }
}
