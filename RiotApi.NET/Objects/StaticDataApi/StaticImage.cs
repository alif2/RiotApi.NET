using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi
{
    public class StaticImage
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("sprite")]
        public string Sprite { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("w")]
        public string W { get; set; }

        [JsonProperty("y")]
        public string Y { get; set; }

        [JsonProperty("x")]
        public string X { get; set; }
    }
}
