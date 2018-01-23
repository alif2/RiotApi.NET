using System;
using System.Net.Http;

namespace RiotApi.NET
{
    public class SummonerApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-be3695ed-3c92-4d4f-9d87-3c7625d58e53";

        public static Summoner GetSummoner(int summonerId)
        {
            var httpResponseMessage = _httpClient.GetAsync("/lol/summoner/v3/summoners/" + summonerId + $"?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Summoner>().Result;
        }

        public static Summoner GetSummoner(string summonerName)
        {
            var httpResponseMessage = _httpClient.GetAsync("/lol/summoner/v3/summoners/by-name/" + summonerName + $"?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Summoner>().Result;
        }

        public static Summoner GetSummonerByAccountId(int accountId)
        {
            var httpResponseMessage = _httpClient.GetAsync("/lol/summoner/v3/summoners/by-account/" + accountId + $"?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Summoner>().Result;
        }
    }
}
