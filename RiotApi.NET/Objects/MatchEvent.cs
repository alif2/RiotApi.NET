using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class MatchEvent
    {
        // (Legal values: CHAMPION_KILL, WARD_PLACED, WARD_KILL, BUILDING_KILL, ELITE_MONSTER_KILL, ITEM_PURCHASED, ITEM_SOLD, 
        // ITEM_DESTROYED, ITEM_UNDO, SKILL_LEVEL_UP, ASCENDED_EVENT, CAPTURE_POINT, PORO_KING_SUMMON)
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("creatorId")]
        public int CreatorId { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("assistingParticipantIds")]
        public IEnumerable<int> AssistingParticipantIds { get; set; }

        [JsonProperty("beforeId")]
        public int BeforeId { get; set; }

        [JsonProperty("afterId")]
        public int AfterId { get; set; }

        [JsonProperty("killerId")]
        public int KillerId { get; set; }

        [JsonProperty("victimId")]
        public int VictimId { get; set; }

        [JsonProperty("towerType")]
        public string TowerType { get; set; }

        [JsonProperty("ascendedType")]
        public string AscendedType { get; set; }

        [JsonProperty("levelUpType")]
        public string LevelUpType { get; set; }

        [JsonProperty("pointCaptured")]
        public string PointCaptured { get; set; }

        [JsonProperty("wardType")]
        public string WardType { get; set; }

        [JsonProperty("monsterType")]
        public string MonsterType { get; set; }

        [JsonProperty("monsterSubType")]
        public string MonsterSubType { get; set; }

        [JsonProperty("skillSlot")]
        public int SkillSlot { get; set; }

        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        [JsonProperty("laneType")]
        public string LaneType { get; set; }
        
        [JsonProperty("buildingType")]
        public string BuildingType { get; set; }

        [JsonProperty("position")]
        public MatchPosition Position { get; set; }
    }
}