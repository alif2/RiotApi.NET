using RiotApi.NET.Objects.SummonerApi;

namespace RiotApi.NET
{
    public class SummonerApi : Api
    {
        public SummonerApi(RiotApi riotApi) : base(riotApi, "/lol/summoner/v3/summoners") {}

        public Summoner GetSummoner(long summonerId)
        {
            return RiotApi.GetObject<Summoner>(BaseUrl + $"/{summonerId}");
        }

        public Summoner GetSummoner(string summonerName)
        {
            return RiotApi.GetObject<Summoner>(BaseUrl + $"/by-name/{summonerName}");
        }

        public Summoner GetSummonerByAccountId(int accountId)
        {
            return RiotApi.GetObject<Summoner>(BaseUrl + $"/by-account/{accountId}");
        }
    }
}
