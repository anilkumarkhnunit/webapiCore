using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ScoreService.AcceptanceTest.Steps
{
    [Binding]
    public sealed class StepDefinition
    {
        private dynamic result;

        [When(@"a get request to /api/ScoreApi")]
        public async Task WhenAGetRequestToApiScoreApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/score/");
            var _apiResponse = await client.GetAsync("GetAll");
            result = _apiResponse.Content.ReadAsStringAsync().Result;
        }

        [Then(@"response should be recieved")]
        public void ThenResponseShouldBeRecieved()
        {
            Console.WriteLine($"Response recieved: {result} ");
        }

    }
}
