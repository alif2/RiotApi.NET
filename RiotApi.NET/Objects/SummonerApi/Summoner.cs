using Newtonsoft.Json;

namespace RiotApi.NET.Objects.SummonerApi
{
    public class Summoner
    {
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("accountId")]
        public long AccountId { get; set; }
    }
}
