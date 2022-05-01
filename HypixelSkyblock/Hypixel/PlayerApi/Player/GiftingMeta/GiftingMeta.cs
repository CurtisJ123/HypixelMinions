using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.GiftingMeta
{
    public class GiftingMeta
    {
        [JsonProperty("giftsGiven")]
        public long GiftsGiven { get; private set; }

        [JsonProperty("bundlesGiven")]
        public long BundlesGiven { get; private set; }

        [JsonProperty("realBundlesGiven")]
        public long RealBundlesGiven { get; private set; }

        [JsonProperty("milestones")]
        public List<string> Milestones { get; private set; }

        [JsonProperty("realBundlesReceived")]
        public long RealBundlesReceived { get; private set; }

        [JsonProperty("bundlesReceived")]
        public long BundlesReceived { get; private set; }
    }
}
