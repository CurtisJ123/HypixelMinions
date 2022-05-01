using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.BoosterApi
{
    public class GetBoosters
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("boosters")]
        public List<Booster.Booster> Boosters { get; private set; }
    }
}