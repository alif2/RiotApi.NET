using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.SpectatorApi
{
    public class CurrentGameParticipant
    {
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("gameCustomizationObjects")]
        public IEnumerable<GameCustomizationObject> GameCustomizationObjects { get; set; }

        [JsonProperty("bot")]
        public bool Bot { get; set; }

        [JsonProperty("perks")]
        public Perks Perks { get; set; }

        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
