using RiotApi.NET.Objects.SpectatorApi;

namespace RiotApi.NET
{
    public class SpectatorApi : Api
    {
        public SpectatorApi(RiotApi riotApi) : base(riotApi, "/lol/spectator/v3") {}

        public CurrentGameInfo GetActiveGame(long summonerId)
        {
            return RiotApi.GetObject<CurrentGameInfo>(BaseUrl + $"/active-games/by-summoner/{summonerId}");
        }

        public FeaturedGames GetFeaturedGames()
        {
            return RiotApi.GetObject<FeaturedGames>(BaseUrl + "/featured-games");
        }
    }
}
