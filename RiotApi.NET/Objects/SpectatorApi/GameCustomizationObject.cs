using Newtonsoft.Json;

namespace RiotApi.NET.Objects.SpectatorApi
{
    public class GameCustomizationObject
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
