using RiotApi.NET.Objects;

namespace RiotApi.NET
{
    public class SummonerApi : RiotApi
    {
        private static string _baseUrl = "/lol/summoner/v3/summoners";

        public static Summoner GetSummoner(long summonerId)
        {
            return GetObject<Summoner>(_baseUrl + $"/{summonerId}");
        }

        public static Summoner GetSummoner(string summonerName)
        {
            return GetObject<Summoner>(_baseUrl + $"/by-name/{summonerName}");
        }

        public static Summoner GetSummonerByAccountId(int accountId)
        {
            return GetObject<Summoner>(_baseUrl + $"/by-account/{accountId}");
        }
    }
}
