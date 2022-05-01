using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class ClaimedLevels
    {
        [JsonProperty("level_1")]
        public bool Level1 { get; set; }

        [JsonProperty("level_2")]
        public bool Level2 { get; set; }

        [JsonProperty("level_3")]
        public bool Level3 { get; set; }

        [JsonProperty("level_4")]
        public bool Level4 { get; set; }

        [JsonProperty("level_5")]
        public bool Level5 { get; set; }

        [JsonProperty("level_6")]
        public bool Level6 { get; set; }

        [JsonProperty("level_7")]
        public bool Level7 { get; set; }

        [JsonProperty("level_8")]
        public bool Level8 { get; set; }

        [JsonProperty("level_9")]
        public bool Level9 { get; set; }
    }
}