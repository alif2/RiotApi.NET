using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class Observer
    {
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }
    }
}
