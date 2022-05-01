using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class GingerBread
    {
        [JsonProperty("engine_active")]
        public string EngineActive { get; private set; }

        [JsonProperty("booster_active")]
        public string BoosterActive { get; private set; }

        [JsonProperty("frame_active")]
        public string FrameActive { get; private set; }

        [JsonProperty("shoes_active")]
        public string ShoesActive { get; private set; }

        [JsonProperty("helmet_active")]
        public string HelmetActive { get; private set; }

        [JsonProperty("skin_active")]
        public string SkinActive { get; private set; }

        [JsonProperty("pants_active")]
        public string PantsActive { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("jacket_active")]
        public string JacketActive { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("horn")]
        public string Horn { get; private set; }

        [JsonProperty("olympus_plays")]
        public int OlympusPlays { get; private set; }

        [JsonProperty("banana_hits_received")]
        public int BananaHitsReceived { get; private set; }

        [JsonProperty("box_pickups")]
        public int BoxPickups { get; private set; }

        [JsonProperty("coins_picked_up")]
        public int CoinsPickedUp { get; private set; }

        [JsonProperty("laps_completed")]
        public int LapsCompleted { get; private set; }

        [JsonProperty("box_pickups_olympus")]
        public int BoxPickupsOlympus { get; private set; }

        [JsonProperty("banana_hits_sent")]
        public int BananaHitsSent { get; private set; }

        [JsonProperty("box_pickups_hypixelgp")]
        public int BoxPickupsHypixelgp { get; private set; }

        [JsonProperty("hypixelgp_plays")]
        public int HypixelgpPlays { get; private set; }

        [JsonProperty("silver_trophy")]
        public int TotalSilverTrophy { get; private set; }

        [JsonProperty("silver_trophy_hypixelgp")]
        public int SilverTrophyHypixelgp { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("parts")]
        public string Parts { get; private set; }

        [JsonProperty("particle_trail")]
        public string ParticleTrail { get; private set; }

        [JsonProperty("bronze_trophy_olympus")]
        public int BronzeTrophyOlympus { get; private set; }

        [JsonProperty("bronze_trophy")]
        public int TotalBronzeTrophy { get; private set; }

        [JsonProperty("bronze_trophy_monthly_b")]
        public int BronzeTrophyMonthlyB { get; private set; }

        [JsonProperty("silver_trophy_olympus")]
        public int SilverTrophyOlympus { get; private set; }

        [JsonProperty("retro_plays")]
        public int RetroPlays { get; private set; }

        [JsonProperty("box_pickups_retro")]
        public int BoxPickupsRetro { get; private set; }

        [JsonProperty("box_pickups_canyon")]
        public int BoxPickupsCanyon { get; private set; }

        [JsonProperty("canyon_plays")]
        public int CanyonPlays { get; private set; }

        [JsonProperty("bronze_trophy_canyon")]
        public int BronzeTrophyCanyon { get; private set; }

        [JsonProperty("gold_trophy")]
        public int TotalGoldTrophy { get; private set; }

        [JsonProperty("gold_trophy_olympus")]
        public long GoldTrophyOlympus { get; private set; }

        [JsonProperty("silver_trophy_canyon")]
        public long SilverTrophyCanyon { get; private set; }

        [JsonProperty("box_pickups_junglerush")]
        public long BoxPickupsJunglerush { get; private set; }

        [JsonProperty("junglerush_plays")]
        public long JunglerushPlays { get; private set; }

        [JsonProperty("bronze_trophy_junglerush")]
        public long BronzeTrophyJunglerush { get; private set; }

        [JsonProperty("gold_trophy_canyon")]
        public long GoldTrophyCanyon { get; private set; }

        [JsonProperty("silver_trophy_retro")]
        public long SilverTrophyRetro { get; private set; }

        [JsonProperty("gold_trophy_hypixelgp")]
        public long GoldTrophyHypixelgp { get; private set; }

        [JsonProperty("blue_torpedo_hit")]
        public long BlueTorpedoHit { get; private set; }

        [JsonProperty("silver_trophy_junglerush")]
        public long SilverTrophyJunglerush { get; private set; }
    }
}