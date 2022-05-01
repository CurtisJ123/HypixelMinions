using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class SlayerBosses
    {
        [JsonProperty("zombie")]
        public Zombie Zombie { get; set; }

        [JsonProperty("spider")]
        public Spider Spider { get; set; }

        [JsonProperty("wolf")]
        public Wolf Wolf { get; set; }
    }
}
