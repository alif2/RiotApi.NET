using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.LeagueApi
{
    public class LeagueList
    {
        [JsonProperty("leagueId")]
        public string LeagueId { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("entries")]
        public IEnumerable<LeagueItem> Entries { get; set; }

        [JsonProperty("queue")]
        public string Queue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
