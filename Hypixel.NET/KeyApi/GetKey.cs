using Newtonsoft.Json;

namespace Hypixel.NET.KeyApi
{
    public class GetKey
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("record")]
        public Record.Record Record { get; private set; }
    }
}