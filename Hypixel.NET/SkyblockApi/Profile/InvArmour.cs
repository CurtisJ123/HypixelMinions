using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class InvArmour
    {
        [JsonProperty("type")]
        public long Type { get; private set; }

        [JsonProperty("data")]
        public string Data { get; private set; }
    }
}
