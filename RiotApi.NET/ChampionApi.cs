using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET
{
    public class ChampionApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-be3695ed-3c92-4d4f-9d87-3c7625d58e53";

        public static Champion GetChampion(int championId)
        {
            var httpResponseMessage = _httpClient.GetAsync("/lol/platform/v3/champions/" + championId + $"?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Champion>().Result;
        }

        public static IEnumerable<Champion> GetAllChampions()
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/platform/v3/champions?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            var result = httpResponseMessage.Content.ReadAsAsync<Dictionary<string, IEnumerable<Champion>>>().Result;
            return result.FirstOrDefault().Value;
        }
    }
}
