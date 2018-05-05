using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi.Items
{
    public class StaticGold
    {
        [JsonProperty("sell")]
        public int Sell { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }
    }
}
