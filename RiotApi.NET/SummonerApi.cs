using RiotApi.NET.Objects;
using System;
using System.Net.Http;

namespace RiotApi.NET
{
    public class SummonerApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-9aeb4819-3ba4-4268-87b2-e0568333a4e6";

        public static Summoner GetSummoner(int summonerId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/summoner/v3/summoners/{summonerId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Summoner>().Result;
        }

        public static Summoner GetSummoner(string summonerName)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/summoner/v3/summoners/by-name/{summonerName}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Summoner>().Result;
        }

        public static Summoner GetSummonerByAccountId(int accountId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/summoner/v3/summoners/by-account/{accountId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Summoner>().Result;
        }
    }
}
