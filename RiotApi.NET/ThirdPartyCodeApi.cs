namespace RiotApi.NET
{
    public class ThirdPartyCodeApi : Api
    {
        public ThirdPartyCodeApi(RiotApi riotApi) : base(riotApi, "/lol/platform/v3/third-party-code") {}

        public string GetThirdPartyCode(long summonerId)
        {
            return RiotApi.GetString(BaseUrl + $"/by-summoner/{summonerId}");
        }
    }
}
