using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi.Masteries
{
    public class StaticMasteryTreeItem
    {
        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }

        [JsonProperty("prereq")]
        public string Prereq { get; set; }
    }
}
