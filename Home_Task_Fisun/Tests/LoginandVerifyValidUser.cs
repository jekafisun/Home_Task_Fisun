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
    class LoginandVerifyValidUser
    {
        IWebDriver driver;
        string baseUrl;
        string login;
        string pass;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseUrl = "http://i.ua";
            login = "jeka_test";
            pass = "qwert123";
        }
        
        
        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }
       
        [Test]
        public void LoginVerifyValid()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            HomePage home = new HomePage(driver);
            home.verifySite();
            //home.LoginToSite(login, pass);
            InboxPage inbox = home.LoginToSite(login,pass);
            inbox.VerifyUserLogged(login);
            //лишние строки после причесывания кода :)
            //Assert.AreEqual("", driver.Title);
            //home.typeUserName(login);
            //home.typePassword(password);
            //home.clickLoginButton();
            //Assert.AreEqual("Входящие - I.UA ", driver.Title);

        }


    }
}
