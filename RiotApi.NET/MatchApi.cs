using RiotApi.NET.Objects;
using System.Collections.Generic;

namespace RiotApi.NET
{
    public class MatchApi : RiotApi
    {
        private static string _baseUrl = "/lol/match/v3";

        public static Match GetMatchById(long matchId)
        {
            return GetObject<Match>(_baseUrl + $"/matches/{matchId}");
        }

        public static MatchList GetMatchesByAccountId(int accountId, OptionalParameters optionalParameters)
        {
            return GetObjectWithOptionalParameters<MatchList>(_baseUrl + $"/matchlists/by-account/{accountId}", optionalParameters);
        }

        public static MatchList GetRecentMatchesByAccountId(int accountId)
        {
            return GetObject<MatchList>(_baseUrl + $"/matchlists/by-account/{accountId}/recent");
        }

        public static MatchTimeline GetMatchTimelineById(long matchId)
        {
            return GetObject<MatchTimeline>(_baseUrl + $"/timelines/by-match/{matchId}");
        }

        public static IEnumerable<long> GetMatchesByTournamentCode(string tournamentCode)
        {
            return GetObject<IEnumerable<long>>(_baseUrl + $"/matches/by-tournament-code/{tournamentCode}/ids");
        }

        public static Match GetMatchByTournamentCode(long matchId, string tournamentCode)
        {
            return GetObject<Match>(_baseUrl + $"/matches/{matchId}/by-tournament-code/{tournamentCode}");
        }
    }
}
