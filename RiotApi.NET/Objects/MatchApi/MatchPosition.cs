using Newtonsoft.Json;

namespace RiotApi.NET.Objects.MatchApi
{
    public class MatchPosition
    {
        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }
    }
}
