using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class MatchTimeline
    {
        [JsonProperty("frames")]
        public IEnumerable<MatchFrame> Frames { get; set; }

        [JsonProperty("frameInterval")]
        public long FrameInterval { get; set; }
    }
}