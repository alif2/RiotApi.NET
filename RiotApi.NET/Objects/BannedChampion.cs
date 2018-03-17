using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class BannedChampion
    {
        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
    }
}
