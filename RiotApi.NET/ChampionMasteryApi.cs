using RiotApi.NET.Objects.ChampionMasteryApi;
using System.Collections.Generic;

namespace RiotApi.NET
{
    public class ChampionMasteryApi : Api
    {
        public ChampionMasteryApi(RiotApi riotApi) : base(riotApi, "/lol/champion-mastery/v3") {}

        public IEnumerable<ChampionMastery> GetChampionMasteriesBySummonerId(long summonerId)
        {
            return RiotApi.GetObject<IEnumerable<ChampionMastery>>(BaseUrl + $"/champion-masteries/by-summoner/{summonerId}");
        }

        public ChampionMastery GetChampionMasteryBySummonerIdAndChampionId(long summonerId, long championId)
        {
            return RiotApi.GetObject<ChampionMastery>(BaseUrl + $"/champion-masteries/by-summoner/{summonerId}/by-champion/{championId}");
        }

        public int GetMasteryScoreBySummonerId(long summonerId)
        {
            return RiotApi.GetObject<int>(BaseUrl + $"/scores/by-summoner/{summonerId}");
        }
    }
}
