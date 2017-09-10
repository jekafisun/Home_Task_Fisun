using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
//using Home_Task_Fisun.WebPages.i.ua;
using Home_Task_Fisun.WebPages.mailinator.com;

namespace Home_Task_Fisun.Tests
{
    class CheckSenderSubjectCorrect
    {
        IWebDriver driver;
        string baseUrl;
        string login, subj;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseUrl = "http://mailinator.com";
            login = "jeka_test";
            subj = "Test";
        }


        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void CheckSenderAndSubject()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            MainPage main = new MainPage(driver);
            InboxPage inbox = main.LoginMail(login);
            inbox.checkSenderSubject(login,subj);
        }
    }
}
