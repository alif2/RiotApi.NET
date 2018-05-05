using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.SpectatorApi
{
    public class Perks
    {
        [JsonProperty("perkStyle")]
        public long PerkStyle { get; set; }

        [JsonProperty("perkIds")]
        public IEnumerable<long> PerkIds { get; set; }

        [JsonProperty("perkSubStyle")]
        public long PerkSubStyle { get; set; }
    }
}
