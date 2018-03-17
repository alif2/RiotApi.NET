namespace RiotApi.NET
{
    public class ThirdPartyCodeApi : RiotApi
    {
        private static string _baseUrl = "/lol/platform/v3/third-party-code";

        public static string GetThirdPartyCode(long summonerId)
        {
            return GetObject<string>(_baseUrl + $"/by-summoner/{summonerId}");
        }
    }
}
