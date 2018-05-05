using Newtonsoft.Json;

namespace RiotApi.NET.Objects.MatchApi
{
    public class TeamBans
    {
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }
    }
}
