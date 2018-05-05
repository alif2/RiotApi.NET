using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.LolStatusApi
{
    public class Incident
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("updates")]
        public IEnumerable<Message> Updates { get; set; }
    }
}
