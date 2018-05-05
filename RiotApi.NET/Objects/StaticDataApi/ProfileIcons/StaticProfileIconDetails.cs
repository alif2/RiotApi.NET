using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi.ProfileIcons
{
    public class StaticProfileIconDetails
    {
        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
