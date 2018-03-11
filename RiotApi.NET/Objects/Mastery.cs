using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class Mastery
    {
        [JsonProperty("masteryId")]
        public int Id { get; set; }
        public int Rank { get; set; }
    }
}
