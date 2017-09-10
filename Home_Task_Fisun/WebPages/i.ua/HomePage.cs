using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using Home_Task_Fisun.WebPages;
using Home_Task_Fisun.WebPages.i.ua;


namespace Home_Task_Fisun.WebPages.i.ua
{
    public class HomePage
    {
        IWebDriver driver;
        string urlHome= "I.UA - твоя почта ";
        
        //public string baseUrl;
        //public static IWebElement enterBtn = new ChromeDriver().FindElement(By.Name("login"));
        //public static IWebElement inputLogin = new ChromeDriver().FindElement(By.Name("pass"));
        //public static IWebElement inputPass = new ChromeDriver().FindElement(By.XPath("//form/p/input"));
        //= "http://i.ua";

        //[FindsBy(How = How.Name, Using = "login")]
        //public IWebElement userNameTextField;
        //[FindsBy(How = How.Name, Using = "pass")]
        //public IWebElement userPassTextField;
        //[FindsBy(How = How.XPath, Using = "//form/p/input")]
        //public IWebElement loginButton;

        By username = By.Name("login");
        By password = By.Name("pass");
        By loginButton = By.XPath("//form/p/input");
        
        

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void verifySite()
        {
            Assert.AreEqual(urlHome, driver.Title);
        }
        //public void typeUserName(string login)
        //{
        //   driver.FindElement(username).SendKeys(login);
        //}
        //public void typePassword(string password)
        //{
        //    driver.FindElement(pass).SendKeys(password);
        //}
        //public void clickLoginButton()
        //{
        //    driver.FindElement(loginButton).Click();
        //}

        public InboxPage LoginToSite(string login, string pass)
        {
            driver.FindElement(username).Clear();
            driver.FindElement(username).SendKeys(login);
            driver.FindElement(password).Clear();
            driver.FindElement(password).SendKeys(pass);
            driver.FindElement(loginButton).Click();
            return new InboxPage(driver);
        }
        
        public ErrorPage LoginToSiteError(string login,string pass)
        {
            driver.FindElement(username).Clear();
            driver.FindElement(username).SendKeys(login);
            driver.FindElement(password).Clear();
            driver.FindElement(password).SendKeys(pass);
            driver.FindElement(loginButton).Click();
            return new ErrorPage(driver);
        }
        
        
        
    }
}
