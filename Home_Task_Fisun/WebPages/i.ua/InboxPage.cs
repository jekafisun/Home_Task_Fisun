using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace Home_Task_Fisun.WebPages.i.ua
{
    public class InboxPage
    {
        IWebDriver driver;
        string urlMail = "Входящие - I.UA ";

        By writeLetter = By.XPath("//div[5]/div[1]/div[1]/p/a");
        By verifyLogin = By.XPath("//a/span");

        public InboxPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public NewLetterPage ClickWriteLetter()
        {
            driver.FindElement(writeLetter).Click();
            return new NewLetterPage(driver);
        }
        public void VerifyUserLogged(string login)
        {
            Assert.AreEqual(urlMail, driver.Title);
            string nickname = driver.FindElement(verifyLogin).Text;
            Assert.True(nickname == login);
        }
    }
}
