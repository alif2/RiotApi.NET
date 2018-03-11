using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class Incident
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("active")]
        public bool IsActive { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updates")]
        public IEnumerable<Message> Updates { get; set; }
    }
}
