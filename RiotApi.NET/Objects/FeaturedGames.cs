using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class FeaturedGames
    {
        [JsonProperty("clientRefreshInterval")]
        public long ClientRefreshInterval { get; set; }

        [JsonProperty("gameList")]
        public IEnumerable<CurrentGameInfo> Games { get; set; }
    }
}
