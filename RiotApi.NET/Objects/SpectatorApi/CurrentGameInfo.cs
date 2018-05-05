using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.SpectatorApi
{
    public class CurrentGameInfo
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("gameStartTime")]
        public long GameStartTime { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("bannedChampions")]
        public IEnumerable<BannedChampion> BannedChampions { get; set; }

        [JsonProperty("observers")]
        public Observer Observers { get; set; }

        [JsonProperty("participants")]
        public IEnumerable<CurrentGameParticipant> Participants { get; set; }

        [JsonProperty("gameLength")]
        public long GameLength { get; set; }

        [JsonProperty("gameQueueConfigId")]
        public long GameQueueConfigId { get; set; }
    }
}
