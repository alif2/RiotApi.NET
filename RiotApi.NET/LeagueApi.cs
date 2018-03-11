using RiotApi.NET.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RiotApi.NET
{
    public class LeagueApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-9aeb4819-3ba4-4268-87b2-e0568333a4e6";

        public static League GetLeague(string leagueId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/league/v3/leagues/{leagueId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<League>().Result;
        }

        public static League GetMasterLeague(string queueName)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/league/v3/masterleagues/by-queue/{queueName}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<League>().Result;
        }

        public static League GetChallengerLeague(string queueName)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/league/v3/challengerleagues/by-queue/{queueName}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<League>().Result;
        }

        public static IEnumerable<LeaguePosition> GetLeaguePositions(long summonerId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/league/v3/positions/by-summoner/{summonerId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<IEnumerable<LeaguePosition>>().Result;
        }
    }
}
