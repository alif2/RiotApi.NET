using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Masteries
{
    public class StaticMasteryTreeList
    {
        [JsonProperty("masteryTreeItems")]
        public IEnumerable<StaticMasteryTreeItem> MasteryTreeItems { get; set; }
    }
}
