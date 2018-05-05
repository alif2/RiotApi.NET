using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.SummonerSpells
{
    public class StaticSummonerSpellList : StaticDataApiObject
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticSummonerSpell> Data { get; set; }
    }
}
