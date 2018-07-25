using RiotApi.NET.Objects.ChampionApi;

namespace RiotApi.NET
{
    public class ChampionApi : Api
    {
        public ChampionApi(RiotApi riotApi) : base(riotApi, "/lol/platform/v3/champions") {}

        public ChampionList GetAllChampions()
        {
            return RiotApi.GetObject<ChampionList>(BaseUrl);
        }

        public Champion GetChampion(int championId)
        {
            return RiotApi.GetObject<Champion>(BaseUrl + $"/{championId}");
        }
    }
}
