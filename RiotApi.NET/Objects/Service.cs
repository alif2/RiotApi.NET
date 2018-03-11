using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class Service
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("incidents")]
        public IEnumerable<Incident> Incidents { get; set; }
    }
}
