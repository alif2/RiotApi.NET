using Newtonsoft.Json;
using RiotApi.NET.Objects;
using System;
using System.Collections.Generic;
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

        public static MatchList GetMatchesByAccountId(int accountId)
        {
            var httpResponseMessage = _httpClient.GetAsync($"/lol/match/v3/matchlists/by-account/{accountId}?api_key={_apiKey}").Result;
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
    }

    public class MatchTimeline
    {
        [JsonProperty("frames")]
        public IEnumerable<MatchFrame> Frames { get; set; }

        [JsonProperty("frameInterval")]
        public long FrameInterval { get; set; }
    }

    public class MatchFrame
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("participantFrames")]
        public Dictionary<int, MatchParticipantFrame> ParticipantFrames { get; set; }

        [JsonProperty("events")]
        public IEnumerable<MatchEvent> Events { get; set; }
    }

    public class MatchEvent
    {
        // (Legal values: CHAMPION_KILL, WARD_PLACED, WARD_KILL, BUILDING_KILL, ELITE_MONSTER_KILL, ITEM_PURCHASED, ITEM_SOLD, 
        // ITEM_DESTROYED, ITEM_UNDO, SKILL_LEVEL_UP, ASCENDED_EVENT, CAPTURE_POINT, PORO_KING_SUMMON)
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("creatorId")]
        public int CreatorId { get; set; }

        [JsonProperty("assistingParticipantIds")]
        public 

        [JsonProperty("towerType")]
        
        [JsonProperty("ascendedType")]
        [JsonProperty("killerId")]
        [JsonProperty("levelUpType")]
            [JsonProperty("pointCaptured")]
        
            [JsonProperty("wardType")]
        [JsonProperty("monsterType")]
            
            [JsonProperty("skillSlot")]
                [JsonProperty("victimId")]
            [JsonProperty("timestamp")]
                [JsonProperty("afterId")]
            [JsonProperty("monsterSubType")]
                [JsonProperty("laneType")]
            [JsonProperty("itemId")]
                [JsonProperty("participantId")]
            [JsonProperty("buildingType")]
                
            [JsonProperty("position")]
                [JsonProperty(" beforeId")]

    }
}
