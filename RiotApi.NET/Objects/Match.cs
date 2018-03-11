using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class Match
    {
        [JsonProperty("gameId")]
        public long Id { get; set; }

        [JsonProperty("queueId")]
        public int QueueId { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }
        
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        
        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }

        [JsonProperty("gameDuration")]
        public long GameDuration { get; set; }

        [JsonProperty("teams")]
        public IEnumerable<TeamStats> Teams { get; set; }

        [JsonProperty("participantIdentities")]
        public IEnumerable<ParticipantIdentity> ParticipantIdentities { get; set; }

        [JsonProperty("participants")]
        public IEnumerable<Participant> Participants { get; set; }
    }
}
