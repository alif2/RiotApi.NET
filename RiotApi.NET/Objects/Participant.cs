using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class Participant
    {
        [JsonProperty("participantId")]
        public int Id { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("spell1Id")]
        public int SummonerSpellOneId { get; set; }

        [JsonProperty("spell2Id")]
        public int SummonerSpellTwoId { get; set; }

        [JsonProperty("highestAchievedSeasonTier")]
        public string HighestAchievedTierInCurrentSeason { get; set; }

        [JsonProperty("runes")]
        public IEnumerable<Rune> Runes { get; set; }

        [JsonProperty("masteries")]
        public IEnumerable<Mastery> Masteries { get; set; }

        [JsonProperty("timeline")]
        public ParticipantTimeline Timeline { get; set; }
        
        [JsonProperty("stats")]
        public ParticipantStats Stats { get; set; }
    }
}
