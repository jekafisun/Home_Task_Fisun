using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Home_Task_Fisun.WebPages.i.ua;

namespace Home_Task_Fisun.Tests
{
    class SendLetterToMailinator
    {
        IWebDriver driver;
        string baseUrl;
        string login, pass;
        string destination, subject, text;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseUrl = "http://i.ua";
            login = "jeka_test";
            pass = "qwert123";
            destination = "jeka_test@mailinator.com";
            subject = "Test";
            text = "Some text to verify";
            
        }


        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void SendMail()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            HomePage home = new HomePage(driver);
            //home.verifySite();
            //home.LoginToSite(login, pass);
            InboxPage inbox = home.LoginToSite(login, pass);
            //inbox.VerifyUserLogged(login);
            NewLetterPage newLetter = inbox.ClickWriteLetter();
            newLetter.editAndSendLetter(destination,subject,text);

            //лишние строки после причесывания кода :)
            //Assert.AreEqual("", driver.Title);
            //home.typeUserName(login);
            //home.typePassword(password);
            //home.clickLoginButton();
            //Assert.AreEqual("Входящие - I.UA ", driver.Title);

        }
    }
}
