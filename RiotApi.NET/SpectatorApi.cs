using RiotApi.NET.Objects;
using System;
using System.Net.Http;

namespace RiotApi.NET
{
    public class SpectatorApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-9aeb4819-3ba4-4268-87b2-e0568333a4e6";
        private static string _baseUrl = "/lol/spectator/v3";

        public static CurrentGameInfo GetActiveGame(long summonerId)
        {
            var httpResponseMessage = _httpClient.GetAsync(_baseUrl + $"/active-games/by-summoner/{summonerId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<CurrentGameInfo>().Result;
        }

        public static FeaturedGames GetFeaturedGames()
        {
            var httpResponseMessage = _httpClient.GetAsync(_baseUrl + $"/featured-games?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<FeaturedGames>().Result;
        }
    }
}
