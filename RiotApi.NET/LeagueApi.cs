using System;
using System.Net.Http;

namespace RiotApi.NET
{
    public class LeagueApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-be3695ed-3c92-4d4f-9d87-3c7625d58e53";

        public static League GetLeague(string leagueId)
        {
            var httpResponseMessage = _httpClient.GetAsync("/lol/league/v3/leagues/" + leagueId + $"?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<League>().Result;
        }

        public static League GetMasterLeague(string queueName)
        {
            var httpResponseMessage = _httpClient.GetAsync("/lol/league/v3/masterleagues/by-queue/" + queueName + $"?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<League>().Result;
        }

        public static League GetChallengerLeague(string queueName)
        {
            var httpResponseMessage = _httpClient.GetAsync("/lol/league/v3/challengerleagues/by-queue/" + queueName + $"?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<League>().Result;
        }
    }
}
