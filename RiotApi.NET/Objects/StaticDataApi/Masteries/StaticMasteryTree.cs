using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Masteries
{
    public class StaticMasteryTree
    {
        [JsonProperty("Resolve")]
        public IEnumerable<StaticMasteryTreeList> Resolve { get; set; }

        [JsonProperty("Defense")]
        public IEnumerable<StaticMasteryTreeList> Defense { get; set; }

        [JsonProperty("Utility")]
        public IEnumerable<StaticMasteryTreeList> Utility { get; set; }

        [JsonProperty("Offense")]
        public IEnumerable<StaticMasteryTreeList> Offense { get; set; }

        [JsonProperty("Ferocity")]
        public IEnumerable<StaticMasteryTreeList> Ferocity { get; set; }

        [JsonProperty("Cunning")]
        public IEnumerable<StaticMasteryTreeList> Cunning { get; set; }
    }
}
