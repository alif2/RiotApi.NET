using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.ReforgedRunes
{
    public class StaticReforgedRunePath
    {
        [JsonProperty("slots")]
        public IEnumerable<StaticReforgedRuneSlot> Slots { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
