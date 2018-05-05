using Newtonsoft.Json;

namespace RiotApi.NET.Objects.SpectatorApi
{
    public class Observer
    {
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }
    }
}
