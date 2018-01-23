using Newtonsoft.Json;

namespace RiotApi.NET
{
    public class Summoner
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("accountId")]
        public long AccountId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("summonerLevel")]
        public long Level { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }
    }
}
