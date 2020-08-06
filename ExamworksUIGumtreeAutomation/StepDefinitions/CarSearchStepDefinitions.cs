using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using ExamworksUIGumtreeAutomation.Hooks;
using ExamworksUIGumtreeAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamworksUIGumtreeAutomation.StepDefinitions
{
    [Binding]
    public class CarSearchStepDefinitions
    {
        Context context;
        CarSearchPages carSearchPages;
        public CarSearchStepDefinitions(Context _context, CarSearchPages _carSearchPages)
        {
            context = _context;
            carSearchPages = _carSearchPages;
        }

        [Given(@"that gumtree is launched and fully loaded")]
        public void GivenThatGumtreeIsLaunchedAndFullyLoaded()
        {
            context.Initialize();
        }

        [When(@"a user types (.*) into the search field")]
        public void WhenAUserTypesCarsIntoTheSearchField(string searchFieldData)
        {
            carSearchPages.FillInSearchField(searchFieldData);
        }

        [When(@"a user types (.*) into the location field")]
        public void WhenAUserTypesLondonIntoTheLocationField(string locationData)
        {
            carSearchPages.FillInLocationField(locationData);
        }

        [When(@"a user clicks on the go button")]
        public void WhenAUserClicksOnTheGoButton()
        {
            carSearchPages.ClickOnGoButton();
        }

        [Then(@"the user should navigate to the Used Cars For Sale in London page")]
        public void ThenTheUserShouldNavigateToTheUsedCarsForSaleInLondonPage()
        {
            bool actualResult = carSearchPages.VerifySearchSuccessful();
            Assert.AreEqual(true, actualResult);
        }

        [When(@"a user clicks on a car link")]
        public void WhenAUserClicksOnACarLink()
        {
            carSearchPages.ClickOnCarLink();
        }

        [Then(@"the user should be navigated to the clicked car link successfully")]
        public void ThenTheUserShouldBeNavigatedToTheClickedCarLinkSuccessfully()
        {
            bool actualResult = carSearchPages.VerifyCarLinkSuccessful();
            Assert.AreEqual(true, actualResult);
        }

        [AfterScenario]
        public void CloseApplicationUnderTest()
        {
            context.CloseAUT();
        }

    }
}
