using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ExamworksUIGumtreeAutomation.Hooks;
using NUnit.Framework;
using System.Threading;

namespace ExamworksUIGumtreeAutomation.Pages
{
    public class CarSearchPages
    {
        Context context;

        public CarSearchPages(Context _context)
        {
            context = _context;
        }

        By search = By.Id("q");
        By location = By.Id("header-search-location");
        By go = By.XPath("//*[@id='content']/header/div/form/div/div[2]/button");
        By carLink = By.XPath("//*[@id='srp - results']/div[1]/div/div[3]/ul[1]/li[2]/article/a/div[2]/h2");

        public void FillInSearchField(string searchFieldData)
        {
            //used system.threading owing to the limitation of time to carry out this task, in a
            //normal scenario and at work, implicit and explicit wait will be utilized and IObject Container will
            //be used to keep some variables in a class not visible to other classes as all the classes being public is
            //not reeally best practice
            Thread.Sleep(5000);
            IWebElement searchField = context.driver.FindElement(search);
            searchField.Clear();
            searchField.SendKeys(searchFieldData);
        }
        public void FillInLocationField(string locationFieldData)
        {
            Thread.Sleep(5000);
            IWebElement locationField = context.driver.FindElement(location);
            locationField.Clear();
            locationField.SendKeys(locationFieldData);
        }
        public void ClickOnGoButton()
        {
            Thread.Sleep(5000);
            context.driver.FindElement(go).Click();
        }
        public bool VerifySearchSuccessful()
        {
            Thread.Sleep(5000);
            return context.driver.PageSource.Contains("Used Cars For Sale in London");
        }
        public void ClickOnCarLink()
        {
            Thread.Sleep(5000);
            context.driver.FindElement(carLink).Click();
        }
        public bool VerifyCarLinkSuccessful()
        {
            Thread.Sleep(5000);
            return context.driver.PageSource.Contains("2011 Peugeot 207");
        }

    }
}
