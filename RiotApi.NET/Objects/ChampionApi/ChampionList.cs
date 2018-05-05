using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.ChampionApi
{
    public class ChampionList
    {
        [JsonProperty("champions")]
        public IEnumerable<Champion> Champions { get; set; }
    }
}
