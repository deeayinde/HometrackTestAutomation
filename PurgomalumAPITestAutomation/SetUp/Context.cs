using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace PurgomalumAPITestAutomation.SetUp
{
    public class Context
    {
        string baseUrl = "https://www.purgomalum.com/service/json?text=";
        public string content = string.Empty;
        public string statusCode = string.Empty;

        public void GetMethod(string resource)
        {
            string endpoint = (baseUrl + resource).Replace("%20", "");
            var client = new RestClient(endpoint);
            var request = new RestRequest(endpoint, Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            var result = client.Execute(request);
            content = result.Content;
            statusCode = result.StatusCode.ToString();
        }
    }
}
