using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class Rune
    {
        [JsonProperty("runeId")]
        public int Id { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
