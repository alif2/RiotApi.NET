using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi
{
    public class StaticMastery
    {
        [JsonProperty("prereq")]
        public string Prereq { get; set; }

        [JsonProperty("masteryTree")]
        public string MasteryTree { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ranks")]
        public int Ranks { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("sanitizedDescription")]
        public IEnumerable<string> SanitizedDescription { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public IEnumerable<string> Description { get; set; }
    }
}
