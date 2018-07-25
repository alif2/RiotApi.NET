using RiotApi.NET.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace RiotApi.NET
{
    public class RiotApi
    {
        public string ApiKey { get; set; }
        
        private HttpClient HttpClient { get; }

        public RiotApi(string apiKey, Regions regions)
        {
            ApiKey = apiKey;

            HttpClient = new HttpClient();
            SetRegion(regions);
        }

        public Regions GetRegion()
        {
            var httpClientBaseAddress = HttpClient.BaseAddress.ToString();
            var foundEndpoint = _serverEndpoints.First(endpoint => endpoint.Value.Equals(httpClientBaseAddress));
            return foundEndpoint.Key;
        }

        public void SetRegion(Regions regions)
        {
            HttpClient.BaseAddress = new Uri(_serverEndpoints[regions]);
        }

        public enum Regions
        {
            BR, EUNE, EUW, JP, KR, LAN, LAS, NA, OCE, TR, RU, PBE
        }

        private readonly Dictionary<Regions, string> _serverEndpoints = new Dictionary<Regions, string>
        {
            { Regions.BR, "https://br1.api.riotgames.com"},
            { Regions.EUNE, "https://eun1.api.riotgames.com" },
            { Regions.EUW, "https://euw1.api.riotgames.com" },
            { Regions.JP, "https://jp1.api.riotgames.com" },
            { Regions.KR, "https://kr.api.riotgames.com" },
            { Regions.LAN, "https://la1.api.riotgames.com" },
            { Regions.LAS, "https://la2.api.riotgames.com" },
            { Regions.NA, "https://na1.api.riotgames.com" },
            { Regions.OCE, "https://oc1.api.riotgames.com" },
            { Regions.TR, "https://tr1.api.riotgames.com" },
            { Regions.RU, "https://ru.api.riotgames.com" },
            { Regions.PBE, "https://pbe1.api.riotgames.com" }
        };
        
        public T GetObject<T>(string apiUrl)
        {
            var httpResponseMessage = CallApi(apiUrl);
            return httpResponseMessage.Content.ReadAsAsync<T>().Result;
        }

        public T GetObjectWithOptionalParameters<T>(string apiUrl, OptionalParameters optionalParameters)
        {
            var httpResponseMessage = CallApiWithOptionalParameters(apiUrl, optionalParameters);
            return httpResponseMessage.Content.ReadAsAsync<T>().Result;
        }

        public string GetString(string apiUrl)
        {
            var httpResponseMessage = CallApi(apiUrl);
            return httpResponseMessage.Content.ReadAsStringAsync().Result;
        }

        public HttpResponseMessage CallApi(string apiUrl)
        {
            var httpResponseMessage = HttpClient.GetAsync(apiUrl + $"?api_key={ApiKey}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();
            return httpResponseMessage;
        }

        public HttpResponseMessage CallApiWithOptionalParameters(string apiUrl, OptionalParameters optionalParameters)
        {
            var httpResponseMessage = HttpClient.GetAsync(apiUrl + $"?api_key={ApiKey}{optionalParameters}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();
            return httpResponseMessage;
        }
    }
}
