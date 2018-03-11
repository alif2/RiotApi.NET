using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class ParticipantStats
    {
        [JsonProperty("physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }

        [JsonProperty("neutralMinionsKilledTeamJungle")]
        public int NeutralMinionsKilledInTeamJungle { get; set; }

        [JsonProperty("magicDamageDealt")]
        public long MagicDamageDealt { get; set; }

        [JsonProperty("totalPlayerScore")]
        public int PlayerTotalScore { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("win")]
        public bool DidParticipantWin { get; set; }

        [JsonProperty("neutralMinionsKilledEnemyJungle")]
        public int NeutralMinionsKilledInEnemyJungle { get; set; }

        [JsonProperty("altarsCaptured")]
        public int AltarsCaptured { get; set; }

        [JsonProperty("largestCriticalStrike")]
        public int LargestCriticalStrike { get; set; }

        [JsonProperty("totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        [JsonProperty("visionWardsBoughtInGame")]
        public int VisionWardsBought { get; set; }

        [JsonProperty("damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }

        [JsonProperty("largestKillingSpree")]
        public int LargestKillingSpree { get; set; }

        [JsonProperty("item1")]
        public int Item1 { get; set; }

        [JsonProperty("quadraKills")]
        public int QuadraKills { get; set; }

        [JsonProperty("teamObjective")]
        public int TeamObjective { get; set; }

        [JsonProperty("totalTimeCrowdControlDealt")]
        public int TotalTimeCrowdControlDealt { get; set; }

        [JsonProperty("longestTimeSpentLiving")]
        public int LongestTimeSpentLiving { get; set; }

        [JsonProperty("wardsKilled")]
        public int WardsKilled { get; set; }

        [JsonProperty("firstTowerAssist")]
        public bool HasAssistForFirstTowerKill { get; set; }

        [JsonProperty("firstTowerKill")]
        public bool HasFirstTowerKill { get; set; }

        [JsonProperty("item2")]
        public int Item2 { get; set; }

        [JsonProperty("item3")]
        public int Item3 { get; set; }

        [JsonProperty("item0")]
        public int Item0 { get; set; }

        [JsonProperty("firstBloodAssist")]
        public bool HasAssistForFirstBlood { get; set; }

        [JsonProperty("visionScore")]
        public long VisionScore { get; set; }

        [JsonProperty("wardsPlaced")]
        public int WardsPlaced { get; set; }

        [JsonProperty("item4")]
        public int Item4 { get; set; }

        [JsonProperty("item5")]
        public int Item5 { get; set; }

        [JsonProperty("item6")]
        public int Item6 { get; set; }

        [JsonProperty("turretKills")]
        public int TurretKills { get; set; }

        [JsonProperty("tripleKills")]
        public int TripleKills { get; set; }

        [JsonProperty("damageSelfMitigated")]
        public long DamageMitigatedToSelf { get; set; }

        [JsonProperty("champLevel")]
        public int ChampionLevel { get; set; }

        [JsonProperty("nodeNeutralizeAssist")]
        public int NeutralizeNodeAssists { get; set; }

        [JsonProperty("firstInhibitorKill")]
        public bool HasFirstInhibitorKill { get; set; }

        [JsonProperty("goldEarned")]
        public int GoldEarned { get; set; }

        [JsonProperty("magicalDamageTaken")]
        public long MagicDamageTaken { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("doubleKills")]
        public int DoubleKills { get; set; }

        [JsonProperty("nodeCaptureAssist")]
        public int CaptureNodeAssists { get; set; }

        [JsonProperty("trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        [JsonProperty("nodeNeutralize")]
        public int NodesNeutralized { get; set; }

        [JsonProperty("firstInhibitorAssist")]
        public bool HasAssistForFirstInhibitorKill { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("unrealKills")]
        public int UnrealKills { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; set; }

        [JsonProperty("objectivePlayerScore ")]
        public int ObjectiveScore { get; set; }

        [JsonProperty("combatPlayerScore")]
        public int CombatScore { get; set; }

        [JsonProperty("damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }

        [JsonProperty("altarsNeutralized")]
        public int AltersNeutralized { get; set; }

        [JsonProperty("physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        [JsonProperty("goldSpent")]
        public int GoldSpent { get; set; }

        [JsonProperty("trueDamageDealt")]
        public long TrueDamageDealt { get; set; }

        [JsonProperty("trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("pentaKills")]
        public int PentaKills { get; set; }

        [JsonProperty("totalHeal")]
        public long TotalHealed { get; set; }

        [JsonProperty("totalMinionsKilled")]
        public int TotalMinionsKilled { get; set; }

        [JsonProperty("firstBloodKill")]
        public bool HasFirstBloodKill { get; set; }

        [JsonProperty("nodeCapture")]
        public int NodesCaptured { get; set; }

        [JsonProperty("largestMultiKill")]
        public int LargestMultiKill { get; set; }

        [JsonProperty("sightWardsBoughtInGame")]
        public int SightWardsBought { get; set; }

        [JsonProperty("totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        [JsonProperty("totalUnitsHealed ")]
        public int TotalUnitsHealed { get; set; }

        [JsonProperty("inhibitorKills ")]
        public int InhibitorsKilled { get; set; }

        [JsonProperty("totalScoreRank")]
        public int TotalScoreRank { get; set; }

        [JsonProperty("totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        [JsonProperty("killingSprees")]
        public int KillingSprees { get; set; }

        [JsonProperty("timeCCingOthers")]
        public long TimeCrowdControllingOthers { get; set; }

        [JsonProperty("physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }
    }
}
