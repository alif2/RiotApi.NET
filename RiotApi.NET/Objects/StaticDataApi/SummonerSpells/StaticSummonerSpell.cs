using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.SummonerSpells
{
    public class StaticSummonerSpell
    {
        [JsonProperty("vars")]
        public IEnumerable<StaticSpellVars> Vars { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty("cooldown")]
        public IEnumerable<double> Cooldown { get; set; }

        [JsonProperty("effectBurn")]
        public IEnumerable<string> EffectBurn { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("maxrank")]
        public int MaxRank { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("effect")]
        public IEnumerable<double> Effect { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("leveltip")]
        public StaticLevelTip LevelTip { get; set; }

        [JsonProperty("modes")]
        public IEnumerable<string> Modes { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("sanitizedTooltip")]
        public string SantizedTooltip { get; set; }

        [JsonProperty("range")]
        public object Range { get; set; }

        [JsonProperty("cost")]
        public IEnumerable<int> Cost { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
