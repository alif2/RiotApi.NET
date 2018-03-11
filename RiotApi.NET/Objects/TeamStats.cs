using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class TeamStats
    {
        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("win")]
        public string Win { get; set; }

        [JsonProperty("firstBlood")]
        public bool HasFirstBloodKill { get; set; }

        [JsonProperty("firstTower")]
        public bool HasFirstTowerKill { get; set; }

        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }

        [JsonProperty("firstDragon")]
        public bool HasFirstDragonKill { get; set; }

        [JsonProperty("dragonKills")]
        public int DragonKills { get; set; }

        [JsonProperty("firstRiftHerald")]
        public bool HasFirstRiftHeraldKill { get; set; }

        [JsonProperty("riftHeraldKills")]
        public int RiftHeraldKills { get; set; }

        [JsonProperty("firstBaron")]
        public bool HasFirstBaronKill { get; set; }

        [JsonProperty("baronKills")]
        public int BaronKills { get; set; }

        [JsonProperty("firstInhibitor")]
        public bool HasFirstInhibitorKill { get; set; }

        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }

        [JsonProperty("vilemawKills")]
        public int VilemawKills { get; set; }

        [JsonProperty("dominionVictoryScore")]
        public int DominionVictoryScore { get; set; }

        [JsonProperty("bans")]
        public IEnumerable<TeamBans> Bans { get; set; }
    }
}
