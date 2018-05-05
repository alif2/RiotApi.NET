using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.MatchApi
{
    public class MatchList
    {
        [JsonProperty("matches")]
        public IEnumerable<MatchReference> Matches { get; set; }

        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }
}
