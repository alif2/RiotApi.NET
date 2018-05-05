using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.ReforgedRunes
{
    public class StaticReforgedRuneSlot
    {
        [JsonProperty("runes")]
        public IEnumerable<StaticReforgedRune> Runes { get; set; }
    }
}
