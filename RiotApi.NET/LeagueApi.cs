using RiotApi.NET.Objects.LeagueApi;
using System.Collections.Generic;

namespace RiotApi.NET
{
    public class LeagueApi : Api
    {
        public LeagueApi(RiotApi riotApi) : base(riotApi, "/lol/league/v3") {}

        public LeagueList GetLeague(string leagueId)
        {
            return RiotApi.GetObject<LeagueList>(BaseUrl + $"/leagues/{leagueId}");
        }

        public LeagueList GetMasterLeague(string queueName)
        {
            return RiotApi.GetObject<LeagueList>(BaseUrl + $"/masterleagues/by-queue/{queueName}");
        }

        public LeagueList GetChallengerLeague(string queueName)
        {
            return RiotApi.GetObject<LeagueList>(BaseUrl + $"/challengerleagues/by-queue/{queueName}");
        }

        public IEnumerable<LeaguePosition> GetLeaguePositions(long summonerId)
        {
            return RiotApi.GetObject<IEnumerable<LeaguePosition>>(BaseUrl + $"/positions/by-summoner/{summonerId}");
        }
    }
}
