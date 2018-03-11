using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class LeagueItem
    {
        [JsonProperty("playerOrTeamId")]
        public string Id { get; set; }

        [JsonProperty("playerOrTeamName")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }

        [JsonProperty("wins")]
        public int WinCount { get; set; }

        [JsonProperty("losses")]
        public int LossCount { get; set; }

        [JsonProperty("veteran")]
        public bool IsVeteran { get; set; }

        [JsonProperty("hotStreak")]
        public bool IsOnHotStreak { get; set; }

        [JsonProperty("freshBlood")]
        public bool HasRecentlyJoinedLeague { get; set; }

        [JsonProperty("inactive")]
        public bool IsInactive { get; set; }

        [JsonProperty("miniSeries")]
        public MiniSeries MiniSeries { get; set; }
    }
}
