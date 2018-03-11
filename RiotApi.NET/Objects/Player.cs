using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class Player
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }

        [JsonProperty("accountId")]
        public long AccountId { get; set; }

        [JsonProperty("currentAccountId")]
        public long CurrentAccountId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("currentPlatformId")]
        public string CurrentPlatformId { get; set; }

        [JsonProperty("profileIcon")]
        public int ProfileIconId { get; set; }

        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }
    }
}
