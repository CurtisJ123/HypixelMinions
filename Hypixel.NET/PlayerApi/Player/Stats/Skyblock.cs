using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Skyblock
    {
        [JsonProperty("profiles")]
        public Dictionary<string, SkyblockProfile.SkyblockProfile> Profiles { get; private set; }
    }
}
