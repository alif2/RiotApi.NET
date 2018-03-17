using RiotApi.NET.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET
{
    public class ChampionApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-9aeb4819-3ba4-4268-87b2-e0568333a4e6";
        private static string _baseUrl = "/lol/platform/v3/champions";

        public static IEnumerable<Champion> GetAllChampions()
        {
            var httpResponseMessage = _httpClient.GetAsync(_baseUrl + $"?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            var champions = httpResponseMessage.Content.ReadAsAsync<Dictionary<string, IEnumerable<Champion>>>().Result;
            return champions.FirstOrDefault().Value;
        }

        public static Champion GetChampion(int championId)
        {
            var httpResponseMessage = _httpClient.GetAsync(_baseUrl + $"/{championId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Champion>().Result;
        }
    }
}
