using System;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats.SkywarsStats.Prestigious
{
    public class Prestigious
    {
        [JsonProperty("uuid")]
        public string Uuid { get; private set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; private set; }

        [JsonProperty("sacrifice")]
        public string Sacrifice { get; private set; }
    }
}