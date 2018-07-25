using RiotApi.NET.Objects;
using RiotApi.NET.Objects.MatchApi;
using System.Collections.Generic;

namespace RiotApi.NET
{
    public class MatchApi : Api
    {
        public MatchApi(RiotApi riotApi) : base(riotApi, "/lol/match/v3") {}

        public Match GetMatchById(long matchId)
        {
            return RiotApi.GetObject<Match>(BaseUrl + $"/matches/{matchId}");
        }

        public MatchList GetMatchesByAccountId(int accountId, OptionalParameters optionalParameters)
        {
            return RiotApi.GetObjectWithOptionalParameters<MatchList>(BaseUrl + $"/matchlists/by-account/{accountId}", optionalParameters);
        }

        public MatchTimeline GetMatchTimelineById(long matchId)
        {
            return RiotApi.GetObject<MatchTimeline>(BaseUrl + $"/timelines/by-match/{matchId}");
        }

        public IEnumerable<long> GetMatchesByTournamentCode(string tournamentCode)
        {
            return RiotApi.GetObject<IEnumerable<long>>(BaseUrl + $"/matches/by-tournament-code/{tournamentCode}/ids");
        }

        public Match GetMatchByTournamentCode(long matchId, string tournamentCode)
        {
            return RiotApi.GetObject<Match>(BaseUrl + $"/matches/{matchId}/by-tournament-code/{tournamentCode}");
        }
    }
}
