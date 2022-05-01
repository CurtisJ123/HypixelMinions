using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class Pets
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("exp")]
        public double Exp { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("candyUsed")]
        public int CandyUsed { get; set; }
    }
}
