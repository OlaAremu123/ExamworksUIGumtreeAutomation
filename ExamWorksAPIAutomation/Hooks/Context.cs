using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWorksAPIAutomation.Hooks
{
    public class Context
    {
        string baseUrl = "https://jsonplaceholder.typicode.com/";
        public string content = string.Empty;
        public string statusCode = string.Empty;
        public string responseDescription = string.Empty;

        public void GetHttpMethod(string resource)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.GET);
            var result = client.Execute(request);

            content = result.Content;
            statusCode = result.StatusCode.ToString();
            responseDescription = result.StatusDescription;
        }
    }
}
