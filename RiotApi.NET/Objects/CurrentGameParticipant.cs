using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class CurrentGameParticipant
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("bot")]
        public Boolean IsBot { get; set; }
        
        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }

        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }

        [JsonProperty("gameCustomizationObjects")]
        public IEnumerable<GameCustomizationObject> GameCustomizationObjects { get; set; }

        [JsonProperty("perks")]
        public Perks Perks { get; set; }
    }
}
