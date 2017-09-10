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

namespace Home_Task_Fisun.WebPages.mailinator.com
{
    public class InboxPage
    {
        IWebDriver driver;
        By topLetter = By.XPath("//*[@id='inboxpane']/li[1]");
        By topLetterSender = By.XPath("//*[@id='inboxpane']/li[1]/div/div[3]");
        By topLetterSubject = By.XPath("//*[@id='inboxpane']/li[1]/div/div[4]");

        public InboxPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void checkSenderSubject(string login,string subj)
        {
            string sender = driver.FindElement(topLetterSender).Text;
            Assert.True(sender == login);
            string subject = driver.FindElement(topLetterSubject).Text;
            Assert.True(subject == subj);
            //driver.SwitchTo().Frame("msg_body");
        }
        public void selectLetter()
        {
            driver.FindElement(topLetter).Click();

        }
        public void checkBodyLetter(string text)
        {
            //driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='msg_body']")));
            ////delay(2000);
            //IWebElement msg = driver.FindElement(By.XPath(".//body"));
            
            //String letterText = msg.gette
            //Assert.
        }
    }
}