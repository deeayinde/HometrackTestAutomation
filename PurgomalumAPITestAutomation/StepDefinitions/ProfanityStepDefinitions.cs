using System;
using TechTalk.SpecFlow;
using PurgomalumAPITestAutomation.SetUp;
using NUnit.Framework;
using PurgomalumAPITestAutomation.Model;
using TechTalk.SpecFlow.Assist;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PurgomalumAPITestAutomation.StepDefinitions
{
    [Binding]
    public class ProfanityStepDefinitions
    {
        Context context;

        public ProfanityStepDefinitions(Context _context)
        {
            context = _context;
        }

        
        [Given(@"that PurgoMalum web service with resource (.*) is loaded for a GET call")]
        public void GivenThatPurgoMalumWebServiceIsLoadedForAGETCall(string resource)
        {
            context.GetMethod(resource);
        }

        [Then(@"the status code must be equal to (.*)")]
        public void ThenTheStatusCodeMustBe200Ok(string expectedstatusCode)
        {
               Assert.IsTrue(expectedstatusCode.Equals(context.statusCode), $"Expected {expectedstatusCode} is not equal to Actual {context.statusCode}");
        }

        [Then(@"the following response must be retrieved from the profanity list")]
        public void ThenTheFollowingResponseMustBeRetrieved(Table table)
        {
            var expectedResult = table.CreateInstance<ProfanityModel>();
            var actualResult = JsonConvert.DeserializeObject<ProfanityModel>(context.content);
            Assert.IsTrue(ObjectComparer(expectedResult, actualResult));
        }


        public bool ObjectComparer(object expectedObject, object actualObject)
        {
            var objectOne = JsonConvert.SerializeObject(expectedObject);
            var objectTwo = JsonConvert.SerializeObject(actualObject);
            return objectOne == objectTwo;
        }
    }
}
