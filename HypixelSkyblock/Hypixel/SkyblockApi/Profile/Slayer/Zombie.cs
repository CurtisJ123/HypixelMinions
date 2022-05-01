using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class Zombie
    {
        [JsonProperty("claimed_levels")]
        public ClaimedLevels ClaimedLevels { get; set; }

        [JsonProperty("boss_kills_tier_0")]
        public long BossKillsTier0 { get; set; }

        [JsonProperty("xp")]
        public long Xp { get; set; }

        [JsonProperty("boss_kills_tier_1")]
        public long BossKillsTier1 { get; set; }

        [JsonProperty("boss_kills_tier_2")]
        public long BossKillsTier2 { get; set; }

        [JsonProperty("boss_kills_tier_3")]
        public long BossKillsTier3 { get; set; }
    }
}