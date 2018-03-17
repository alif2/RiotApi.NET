using RiotApi.NET.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET
{
    public class ChampionApi : RiotApi
    {
        private static string _baseUrl = "/lol/platform/v3/champions";

        public static IEnumerable<Champion> GetAllChampions()
        {
            var httpResponseMessage = CallApi(_baseUrl);
            var champions = httpResponseMessage.Content.ReadAsAsync<Dictionary<string, IEnumerable<Champion>>>().Result;
            return champions.FirstOrDefault().Value;
        }

        public static Champion GetChampion(int championId)
        {
            return GetObject<Champion>(_baseUrl + $"/{championId}");
        }
    }
}
