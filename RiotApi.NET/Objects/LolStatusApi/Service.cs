using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.LolStatusApi
{
    public class Service
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("incidents")]
        public IEnumerable<Incident> Incidents { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
