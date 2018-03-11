using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class ParticipantIdentity
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
    }
}
