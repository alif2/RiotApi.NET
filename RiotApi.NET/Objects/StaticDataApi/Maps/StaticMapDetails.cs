using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Maps
{
    public class StaticMapDetails
    {
        [JsonProperty("mapName")]
        public string MapName { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("mapId")]
        public long MapId { get; set; }

        [JsonProperty("unpurchasableItemList")]
        public IEnumerable<long> UnpurchasableItemList { get; set; }
    }
}
