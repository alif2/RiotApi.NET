using RiotApi.NET.Objects;
using System;
using System.IO;
using System.Net.Http;

namespace RiotApi.NET
{
    public class RiotApi
    {
        private static string _apiKey;
        protected static string ApiKey
        {
            get
            {
                if (_apiKey != null) return _apiKey;
                return _apiKey = File.ReadAllText("api-key.txt");
            }
            set => _apiKey = value;
        }

        protected static HttpClient HttpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        
        protected static T GetObject<T>(string apiUrl)
        {
            var httpResponseMessage = CallApi(apiUrl);
            return httpResponseMessage.Content.ReadAsAsync<T>().Result;
        }

        protected static T GetObjectWithOptionalParameters<T>(string apiUrl, OptionalParameters optionalParameters)
        {
            var httpResponseMessage = CallApiWithOptionalParameters(apiUrl, optionalParameters);
            return httpResponseMessage.Content.ReadAsAsync<T>().Result;
        }

        protected static HttpResponseMessage CallApi(string apiUrl)
        {
            var httpResponseMessage = HttpClient.GetAsync(apiUrl + $"?api_key={ApiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();
            return httpResponseMessage;
        }

        protected static HttpResponseMessage CallApiWithOptionalParameters(string apiUrl, OptionalParameters optionalParameters)
        {
            var httpResponseMessage = HttpClient.GetAsync(apiUrl + $"?api_key={ApiKey}{optionalParameters}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();
            return httpResponseMessage;
        }
    }
}
