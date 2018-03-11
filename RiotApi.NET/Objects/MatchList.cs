using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class MatchList
    {
        [JsonProperty("matches")]
        public IEnumerable<MatchReference> Matches { get; set; }

        [JsonProperty("totalGames")]
        public int GameCount { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }
}