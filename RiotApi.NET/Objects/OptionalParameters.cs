using System.Collections.Generic;
using System.Linq;

namespace RiotApi.NET.Objects
{
    public class OptionalParameters
    {
        public IEnumerable<int> Seasons { get; set; }
        public IEnumerable<int> QueueIds { get; set; }
        public IEnumerable<int> ChampionIds { get; set; }

        public int BeginIndex { get; set; }
        public int EndIndex { get; set; }
        public long BeginTime { get; set; }
        public long EndTime { get; set; }

        public OptionalParameters(IEnumerable<int> seasons = null, IEnumerable<int> queueIds = null,
            IEnumerable<int> championIds = null, int beginIndex = -1, int endIndex = -1, long beginTime = -1, long endTime = -1)
        {
            Seasons = seasons;
            QueueIds = queueIds;
            ChampionIds = championIds;
            BeginIndex = beginIndex;
            EndIndex = endIndex;
            BeginTime = beginTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            var optionalParameters = string.Empty;

            if (Seasons != null) optionalParameters += "&season=" + string.Join(",", Seasons.ToArray());
            if (QueueIds != null) optionalParameters += "&queue=" + string.Join(",", QueueIds.ToArray());
            if (ChampionIds != null) optionalParameters += "&champion=" + string.Join(",", ChampionIds.ToArray());
            if (BeginIndex != -1) optionalParameters += "&beginIndex=" + BeginIndex;
            if (EndIndex != -1) optionalParameters += "&endIndex=" + EndIndex;
            if (BeginTime != -1) optionalParameters += "&beginTime=" + BeginTime;
            if (EndTime != -1) optionalParameters += "&endTime=" + EndTime;

            return optionalParameters;
        }
    }
}
