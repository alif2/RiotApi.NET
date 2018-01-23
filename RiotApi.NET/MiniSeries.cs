using Newtonsoft.Json;

namespace RiotApi.NET
{
    public class MiniSeries
    {
        [JsonProperty("wins")]
        public int WinCount { get; set; }

        [JsonProperty("losses")]
        public int LossCount { get; set; }

        [JsonProperty("target")]
        public int TargetWinCount { get; set; }

        [JsonProperty("progress")]
        public string VisualWinsAndLosses { get; set; }
    }
}
