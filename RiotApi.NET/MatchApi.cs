using RiotApi.NET.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET
{
    public class MatchApi
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("https://na1.api.riotgames.com") };
        private static string _apiKey = "RGAPI-9aeb4819-3ba4-4268-87b2-e0568333a4e6";

        public static Match GetMatchById(long matchId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/match/v3/matches/{matchId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Match>().Result;
        }

        public static MatchList GetMatchesByAccountId(int accountId, IEnumerable<int> seasons = null, IEnumerable<int> queueIds = null, 
            IEnumerable<int> championIds = null, int beginIndex = -1, int endIndex = -1, long beginTime = -1, long endTime = -1)
        {
            var optionalParameters = string.Empty;

            if (seasons != null) optionalParameters += "&seasons=" + string.Join(",", seasons.ToArray());
            if (queueIds != null) optionalParameters += "&queueIds=" + string.Join(",", queueIds.ToArray());
            if (championIds != null) optionalParameters += "&championIds=" + string.Join(",", championIds.ToArray());
            if (beginIndex != -1) optionalParameters += "&beginIndex=" + beginIndex;
            if (endIndex != -1) optionalParameters += "&endIndex=" + endIndex;
            if (beginTime != -1) optionalParameters += "&beginTime=" + beginTime;
            if (endTime != -1) optionalParameters += "&endTime=" + endTime;

            var httpResponseMessage = _httpClient.GetAsync($"/lol/match/v3/matchlists/by-account/{accountId}?api_key={_apiKey}{optionalParameters}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<MatchList>().Result;
        }

        public static MatchList GetRecentMatchesByAccountId(int accountId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/match/v3/matchlists/by-account/{accountId}/recent?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<MatchList>().Result;
        }

        public static MatchTimeline GetMatchTimelineById(long matchId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/match/v3/timelines/by-match/{matchId}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<MatchTimeline>().Result;
        }

        public static IEnumerable<long> GetMatchesByTournamentCode(string tournamentCode)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/match/v3/matches/by-tournament-code/{tournamentCode}/ids?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<IEnumerable<long>>().Result;
        }

        public static Match GetMatchByTournamentCode(long matchId, string tournamentCode)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/match/v3/matches/{matchId}/by-tournament-code/{tournamentCode}?api_key={_apiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();

            return httpResponseMessage.Content.ReadAsAsync<Match>().Result;
        }
    }
}
