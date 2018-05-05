using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi.ReforgedRunes
{
    public class StaticReforgedRune
    {
        [JsonProperty("runePathName")]
        public string RunePathName { get; set; }

        [JsonProperty("runePathId")]
        public int RunePathId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("shortDesc")]
        public string ShortDesc { get; set; }

        [JsonProperty("longDesc")]
        public string LongDesc { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
