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
    public class NewLetterPage
    {
        IWebDriver driver;

        By toWhom = By.Id("to");
        By subj = By.Name("subject");
        By msg = By.Id("text");
        By sendBtn = By.Name("send");

        public NewLetterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void editAndSendLetter(string destination,string subject,string text)
        {
            driver.FindElement(toWhom).Clear();
            driver.FindElement(toWhom).SendKeys(destination);
            driver.FindElement(subj).Clear();
            driver.FindElement(subj).SendKeys(subject);
            driver.FindElement(msg).Clear();
            driver.FindElement(msg).SendKeys(text);
            driver.FindElement(sendBtn).Click();
        }
    }
}
