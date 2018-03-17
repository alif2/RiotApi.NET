using RiotApi.NET.Objects;
using System.Collections.Generic;

namespace RiotApi.NET
{
    public class ChampionMasteryApi : RiotApi
    {
        private static string _baseUrl = "/lol/champion-mastery/v3";

        public static IEnumerable<ChampionMastery> GetChampionMasteriesBySummonerId(long summonerId)
        {
            return GetObject<IEnumerable<ChampionMastery>>(_baseUrl + $"/champion-masteries/by-summoner/{summonerId}");
        }

        public static ChampionMastery GetChampionMasteryBySummonerIdAndChampionId(long summonerId, long championId)
        {
            return GetObject<ChampionMastery>(_baseUrl + $"/champion-masteries/by-summoner/{summonerId}/by-champion/{championId}");
        }
        public static int GetMasteryScoreBySummonerId(long summonerId)
        {
            return GetObject<int>(_baseUrl + $"/scores/by-summoner/{summonerId}");
        }
    }
}
