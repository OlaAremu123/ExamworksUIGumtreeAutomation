using ExamWorksAPIAutomation.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ExamWorksAPIAutomation.StepDefinitions
{
    [Binding]
    public class JsonPlaceHolderStepDefinitions
    {
        Context context;

        public JsonPlaceHolderStepDefinitions(Context _context)
        {
            context = _context;
        }

        [Given(@"that JsonPlaceHolder web services with GET endpoint /posts is running")]
        public void GivenThatJsonPlaceHolderWebServicesWithGETEndpointPostsIsRunning(string resource)
        {
            context.GetHttpMethod(resource);
        }

        [Then(@"the status code for GET endpoint is equal to (.*)")]
        public void ThenTheStatusCodeForGETEndpointIsEqualToOK(string expectedResult)
        {
            Assert.AreEqual(expectedResult, context.statusCode, $"{expectedResult} result is not equal to an actual result of {context.statusCode}");
        }

        [Then(@"the following records should be retrieved from posts")]
        public void ThenTheFollowingRecordsShouldBeRetrievedFromPosts()
        {
            // the requirement was kind of vague and not meaningful result were coming out
            // from the GET, POST, PUT, PATCH & DELETE for /posts resource. Hence, test is incomplete
            // and only a simple GET request tests could be written
            ScenarioContext.Current.Pending();
        }

    }
}
