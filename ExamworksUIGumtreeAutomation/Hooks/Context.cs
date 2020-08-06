using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ExamworksUIGumtreeAutomation.Hooks
{
    public class Context
    {
        public IWebDriver driver;
        string baseUrl = "https://www.gumtree.com/";

        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void CloseAUT()
        {
            driver.Quit();
            driver.Dispose();   
        }
    }
}
