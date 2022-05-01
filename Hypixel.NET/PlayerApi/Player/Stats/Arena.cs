using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Arena
    {
        #region general
        [JsonProperty("active_rune")]
        public string ActiveRune { get; private set; }

        [JsonProperty("hat")]
        public string Hat { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("coins_spent")]
        public int CoinsSpent { get; private set; }

        [JsonProperty("keys")]
        public int Keys { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("magical_chest")]
        public int MagicalChest { get; private set; }

        [JsonProperty("offensive")]
        public string Offensive { get; private set; }

        [JsonProperty("rating")]
        public double Rating { get; private set; }

        [JsonProperty("support")]
        public string Support { get; private set; }

        [JsonProperty("ultimate")]
        public string Ultimate { get; private set; }

        [JsonProperty("utility")]
        public string Utility { get; private set; }
        #endregion

        #region 1v1
        [JsonProperty("1v1_cooldown")]
        public int Cooldown1V1UpgradeLevel { get; private set; }

        [JsonProperty("1v1_damage")]
        public int Damage1V1UpgradeLevel { get; private set; }

        [JsonProperty("lvl_health")]
        public int Health1V1UpgradeLevel { get; private set; }

        [JsonProperty("lvl_energy")]
        public int Energy1V1UpgradeLevel { get; private set; }

        [JsonProperty("deaths_1v1")]
        public int Deaths1V1 { get; private set; }

        [JsonProperty("losses_1v1")]
        public int Losses1V1 { get; private set; }

        [JsonProperty("damage_1v1")]
        public int Damage1V1 { get; private set; }

        [JsonProperty("games_1v1")]
        public int Games1V1 { get; private set; }

        [JsonProperty("healed_1v1")]
        public int Healed1V1 { get; private set; }

        [JsonProperty("kills_1v1")]
        public int Kills1V1 { get; private set; }
        #endregion

        #region 2v2
        [JsonProperty("win_streaks_2v2")]
        public int WinStreaks2V2 { get; private set; }

        [JsonProperty("deaths_2v2")]
        public int Deaths2V2 { get; private set; }

        [JsonProperty("losses_2v2")]
        public int Losses2V2 { get; private set; }

        [JsonProperty("damage_2v2")]
        public int Damage2V2 { get; private set; }

        [JsonProperty("games_2v2")]
        public int Games2V2 { get; private set; }

        [JsonProperty("healed_2v2")]
        public int Healed2V2 { get; private set; }

        [JsonProperty("kills_2v2")]
        public int Kills2V2 { get; private set; }

        #endregion

        #region 4v4
        [JsonProperty("damage_4v4")]
        public int Damage4V4 { get; private set; }

        [JsonProperty("games_4v4")]
        public int Games4V4 { get; private set; }

        [JsonProperty("healed_4v4")]
        public int Healed4V4 { get; private set; }

        [JsonProperty("win_streaks_4v4")]
        public int WinStreaks4V4 { get; private set; }

        [JsonProperty("wins_4v4")]
        public int Wins4V4 { get; private set; }

        #endregion
    }
}
