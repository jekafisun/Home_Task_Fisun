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
    public class ErrorPage
    {
        private IWebDriver driver;

        By errorMessage = By.XPath("//div[@id='lform_errCtrl']/div[1]");

        public ErrorPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void VerifyInvalidUserNotLogged()
        {
            string message=driver.FindElement(errorMessage).Text;
            Assert.True(message == "Неверный логин или пароль");
        }
    }
}
