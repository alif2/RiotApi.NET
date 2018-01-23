using Newtonsoft.Json;

namespace RiotApi.NET
{
    public class Champion
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("freeToPlay")]
        public bool IsFreeToPlay { get; set; }

        [JsonProperty("active")]
        public bool IsActive { get; set; }

        [JsonProperty("rankedPlayEnabled")]
        public bool IsEnabledInRanked { get; set; }

        [JsonProperty("botMmEnabled")]
        public bool IsEnabledAsBotInCoopVersusAi { get; set; }

        [JsonProperty("botEnabled")]
        public bool IsEnabledAsBotInCustom { get; set; }
    }
}
