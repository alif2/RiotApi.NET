using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.SpectatorApi
{
    public class FeaturedGames
    {
        [JsonProperty("clientRefreshInterval")]
        public long ClientRefreshInterval { get; set; }

        [JsonProperty("gameList")]
        public IEnumerable<CurrentGameInfo> GameList { get; set; }
    }
}
