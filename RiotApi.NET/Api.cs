namespace RiotApi.NET
{
    public abstract class Api
    {
        public RiotApi RiotApi { get; set; }
        protected string BaseUrl { get; set; }

        protected Api(RiotApi riotApi, string baseUrl)
        {
            RiotApi = riotApi;
            BaseUrl = baseUrl;
        }
    }
}