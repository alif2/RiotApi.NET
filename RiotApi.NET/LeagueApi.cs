using RiotApi.NET.Objects;
using System.Collections.Generic;

namespace RiotApi.NET
{
    public class LeagueApi : RiotApi
    {
        private static string _baseUrl = "/lol/league/v3";

        public static League GetLeague(string leagueId)
        {
            return GetObject<League>(_baseUrl + $"/leagues/{leagueId}");
        }

        public static League GetMasterLeague(string queueName)
        {
            return GetObject<League>(_baseUrl + $"/masterleagues/by-queue/{queueName}");
        }

        public static League GetChallengerLeague(string queueName)
        {
            return GetObject<League>(_baseUrl + $"/challengerleagues/by-queue/{queueName}");
        }

        public static IEnumerable<LeaguePosition> GetLeaguePositions(long summonerId)
        {
            return GetObject<IEnumerable<LeaguePosition>>(_baseUrl + $"/positions/by-summoner/{summonerId}");
        }
    }
}
