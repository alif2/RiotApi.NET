﻿using Newtonsoft.Json;

namespace RiotApi.NET.Objects.MatchApi
{
    public class Player
    {
        [JsonProperty("currentPlatformId")]
        public string CurrentPlatformId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("currentAccountId")]
        public long CurrentAccountId { get; set; }

        [JsonProperty("profileIcon")]
        public int ProfileIcon { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }

        [JsonProperty("accountId")]
        public long AccountId { get; set; }
    }
}
