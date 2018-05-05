using Newtonsoft.Json;

namespace RiotApi.NET.Objects.SpectatorApi
{
    public class BannedChampion
    {
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }
    }
}
