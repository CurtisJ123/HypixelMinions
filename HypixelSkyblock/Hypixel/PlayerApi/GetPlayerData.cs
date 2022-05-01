using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi
{
    public class GetPlayerData
    {
        [JsonProperty("player")]
        public Player.Player Player { get; private set; }

        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        public bool FromCache { get; set; }
    }
}