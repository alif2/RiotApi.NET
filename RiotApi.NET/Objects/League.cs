using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class League
    {
        [JsonProperty("leagueId")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("queue")]
        public string Queue { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("entries")]
        public IEnumerable<LeagueItem> Entries { get; set; }
    }
}
