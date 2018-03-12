using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class MatchFrame
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("participantFrames")]
        public Dictionary<int, MatchParticipantFrame> ParticipantFrames { get; set; }

        [JsonProperty("events")]
        public IEnumerable<MatchEvent> Events { get; set; }
    }
}