using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Champions
{
    public class StaticChampion
    {
        [JsonProperty("info")]
        public StaticInfo Info { get; set; }

        [JsonProperty("enemytips")]
        public IEnumerable<string> EnemyTips { get; set; }

        [JsonProperty("stats")]
        public StaticStats Stats { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }

        [JsonProperty("partype")]
        public string Partype { get; set; }

        [JsonProperty("skins")]
        public IEnumerable<StaticSkin> Skins { get; set; }

        [JsonProperty("passive")]
        public StaticPassive Passive { get; set; }

        [JsonProperty("recommended")]
        public IEnumerable<StaticRecommended> Recommended { get; set; }

        [JsonProperty("allytips")]
        public IEnumerable<string> AllyTips { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("lore")]
        public string Lore { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("spells")]
        public IEnumerable<StaticChampionSpell> Spells { get; set; }
    }
}
