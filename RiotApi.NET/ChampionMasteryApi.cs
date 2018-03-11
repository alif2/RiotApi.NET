using RiotApi.NET.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RiotApi.NET
{
    public class ChampionMasteryApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-9aeb4819-3ba4-4268-87b2-e0568333a4e6";

        public static IEnumerable<ChampionMastery> GetChampionMasteriesBySummonerId(long summonerId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/champion-mastery/v3/champion-masteries/by-summoner/{summonerId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();
            return httpResponseMessage.Content.ReadAsAsync<IEnumerable<ChampionMastery>>().Result;
        }

        public static ChampionMastery GetChampionMasteryBySummonerIdAndChampionId(long summonerId, long championId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/champion-mastery/v3/champion-masteries/by-summoner/{summonerId}/by-champion/{championId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();
            return httpResponseMessage.Content.ReadAsAsync<ChampionMastery>().Result;
        }
        public static int GetMasteryScoreBySummonerId(long summonerId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/champion-mastery/v3/scores/by-summoner/{summonerId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();
            return httpResponseMessage.Content.ReadAsAsync<int>().Result;
        }
    }
}
