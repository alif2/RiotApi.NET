using System;
using System.Net.Http;

namespace RiotApi.NET
{
    public class ThirdPartyCodeApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-9aeb4819-3ba4-4268-87b2-e0568333a4e6";
        private static string _baseUrl = "/lol/platform/v3";

        public static string GetThirdPartyCodeBySummonerId(long summonerId)
        {
            var httpResponseMessage = _httpClient.GetAsync(_baseUrl + $"/third-party-code/by-summoner/{summonerId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<string>().Result;
        }
    }
}
