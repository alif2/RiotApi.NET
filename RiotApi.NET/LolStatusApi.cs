using RiotApi.NET.Objects.LolStatusApi;

namespace RiotApi.NET
{
    public class LolStatusApi : Api
    {
        public LolStatusApi(RiotApi riotApi) : base(riotApi, "/lol/status/v3") {}

        public ShardStatus GetShardStatus()
        {
            return RiotApi.GetObject<ShardStatus>(BaseUrl + "/shard-data/");
        }
    }
}
