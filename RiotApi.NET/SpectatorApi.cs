using RiotApi.NET.Objects;

namespace RiotApi.NET
{
    public class SpectatorApi : RiotApi
    {
        private static string _baseUrl = "/lol/spectator/v3";

        public static CurrentGameInfo GetActiveGame(long summonerId)
        {
            return GetObject<CurrentGameInfo>(_baseUrl + $"/active-games/by-summoner/{summonerId}");
        }

        public static FeaturedGames GetFeaturedGames()
        {
            return GetObject<FeaturedGames>(_baseUrl + "/featured-games");
        }
    }
}
