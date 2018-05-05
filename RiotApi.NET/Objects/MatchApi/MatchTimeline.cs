using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.MatchApi
{
    public class MatchTimeline
    {
        [JsonProperty("frames")]
        public IEnumerable<MatchFrame> Frames { get; set; }

        [JsonProperty("frameInterval")]
        public long FrameInterval { get; set; }
    }
}
