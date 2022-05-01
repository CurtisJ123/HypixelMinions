using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.VanityMeta
{
    public class VanityMeta
    {
        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }
    }
}
