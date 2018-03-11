using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class ChampionMastery
    {
        [JsonProperty("playerId")]
        public long SummonerId { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }

        [JsonProperty("championPoints")]
        public int ChampionPoints { get; set; }

        [JsonProperty("championPointsUntilNextLevel")]
        public long ChampionPointsUntilNextLevel { get; set; }

        [JsonProperty("tokensEarned")]
        public int TokensEarned { get; set; }

        [JsonProperty("championPointsSinceLastLevel")]
        public long ChampionPointsSinceLastLevel { get; set; }

        [JsonProperty("lastPlayTime")]
        public long LastPlayTime { get; set; }

        [JsonProperty("chestGranted")]
        public bool HasChestBeenGrantedThisSeason { get; set; }
    }
}
