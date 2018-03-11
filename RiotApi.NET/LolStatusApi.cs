using RiotApi.NET.Objects;
using System;
using System.Net.Http;

namespace RiotApi.NET
{
    public class LolStatusApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-9aeb4819-3ba4-4268-87b2-e0568333a4e6";

        public static ShardStatus GetShardStatus()
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/status/v3/shard-data/?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<ShardStatus>().Result;
        }
    }
}
