using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class ParticipantTimeline
    {
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }

        [JsonProperty("creepsPerMinDeltas")]
        public Dictionary<string, double> CreepScorePerMinuteDeltas { get; set; }

        [JsonProperty("csDiffPerMinDeltas")]
        public Dictionary<string, double> CreepScoreDifferencePerMinuteDeltas { get; set; }

        [JsonProperty("goldPerMinDeltas")]
        public Dictionary<string, double> GoldPerMinuteDeltas { get; set; }

        [JsonProperty("xpPerMinDeltas")]
        public Dictionary<string, double> ExperiencePerMinuteDeltas { get; set; }

        [JsonProperty("xpDiffPerMinDeltas")]
        public Dictionary<string, double> ExperienceDifferencePerMinuteDeltas { get; set; }

        [JsonProperty("damageTakenPerMinDeltas")]
        public Dictionary<string, double> DamageTakenPerMinuteDeltas { get; set; }

        [JsonProperty("damageTakenDiffPerMinDeltas")]
        public Dictionary<string, double> DamageTakenDifferencePerMinuteDeltas { get; set; }
    }
}
