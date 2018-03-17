using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class Perks
    {
        [JsonProperty("perkStyle")]
        public long PerkStyle { get; set; }

        [JsonProperty("perkSubStyle")]
        public long PerkSubStyle { get; set; }

        [JsonProperty("perkIds")]
        public IEnumerable<long> PerkIds { get; set; }
    }
}
