using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class MatchParticipantFrame
    {
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("teamScore")]
        public int TeamScore { get; set; }

        [JsonProperty("dominionScore")]
        public int DominionScore { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("currentGold")]
        public int CurrentGold { get; set; }

        [JsonProperty("totalGold")]
        public int TotalGold { get; set; }

        [JsonProperty("minionsKilled")]
        public int MinionKillCount { get; set; }

        [JsonProperty("jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }

        [JsonProperty("xp")]
        public int ExperiencePoints { get; set; }

        [JsonProperty("position")]
        public MatchPosition Position { get; set; }
    }
}
