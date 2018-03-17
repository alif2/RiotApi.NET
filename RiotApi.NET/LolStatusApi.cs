using RiotApi.NET.Objects;

namespace RiotApi.NET
{
    public class LolStatusApi : RiotApi
    {
        private static string _baseUrl = "/lol/status/v3";

        public static ShardStatus GetShardStatus()
        {
            return GetObject<ShardStatus>(_baseUrl + "/shard-data/");
        }
    }
}
