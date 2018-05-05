using Newtonsoft.Json;

namespace RiotApi.NET.Objects.MatchApi
{
    public class MatchParticipantFrame
    {
        [JsonProperty("totalGold")]
        public int TotalGold { get; set; }

        [JsonProperty("teamScore")]
        public int TeamScore { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("currentGold")]
        public int CurrentGold { get; set; }

        [JsonProperty("minionsKilled")]
        public int MinionsKilled { get; set; }

        [JsonProperty("dominionScore")]
        public int DominionScore { get; set; }

        [JsonProperty("position")]
        public MatchPosition Position { get; set; }

        [JsonProperty("xp")]
        public int Xp { get; set; }

        [JsonProperty("jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }
    }
}
