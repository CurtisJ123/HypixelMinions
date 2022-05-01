using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Uhc
    {
        #region general stats	
        [JsonProperty("kills")]
        public long Kills { get; private set; }

        [JsonProperty("score")]
        public long Score { get; private set; }

        [JsonProperty("coins")]
        public long Coins { get; private set; }

        [JsonProperty("deaths")]
        public long Deaths { get; private set; }

        [JsonProperty("heads_eaten")]
        public long HeadsEaten { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("equippedKit")]
        public string EquippedKit { get; private set; }

        [JsonProperty("wins")]
        public long Wins { get; private set; }
        #endregion

        #region solo	
        [JsonProperty("deaths_solo")]
        public long DeathsSolo { get; private set; }

        [JsonProperty("wins_solo")]
        public long WinsSolo { get; private set; }

        [JsonProperty("kills_solo")]
        public long KillsSolo { get; private set; }

        [JsonProperty("heads_eaten_solo")]
        public long HeadsEatenSolo { get; private set; }
        #endregion

        #region brawl	
        [JsonProperty("deaths_brawl")]
        public long DeathsBrawl { get; private set; }

        [JsonProperty("heads_eaten_brawl")]
        public long HeadsEatenBrawl { get; private set; }

        [JsonProperty("kills_brawl")]
        public long KillsBrawl { get; private set; }

        [JsonProperty("wins_brawl")]
        public long WinsBrawl { get; private set; }

        [JsonProperty("kills_solo brawl")]
        public long KillsSoloBrawl { get; private set; }

        [JsonProperty("deaths_solo brawl")]
        public long DeathsSoloBrawl { get; private set; }

        [JsonProperty("heads_eaten_solo brawl")]
        public long HeadsEatenSoloBrawl { get; private set; }

        [JsonProperty("wins_solo brawl")]
        public long WinsSoloBrawl { get; private set; }

        [JsonProperty("kills_duo brawl")]
        public long KillsDuoBrawl { get; private set; }

        [JsonProperty("deaths_duo brawl")]
        public long DeathsDuoBrawl { get; private set; }

        [JsonProperty("heads_eaten_duo brawl")]
        public long HeadsEatenDuoBrawl { get; private set; }

        [JsonProperty("wins_duo brawl")]
        public long WinsDuoBrawl { get; private set; }
        #endregion
    }
}