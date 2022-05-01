using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Paintball
    {
        #region general stats
        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("killstreaks")]
        public int Killstreaks { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("shots_fired")]
        public int ShotsFired { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("hat")]
        public string Hat { get; private set; }
        #endregion

        #region upgrades
        [JsonProperty("adrenaline")]
        public int AdrenalineLevel { get; private set; }

        [JsonProperty("endurance")]
        public int EnduranceLevel { get; private set; }

        [JsonProperty("forcefieldTime")]
        public int ForcefieldTime { get; private set; }

        [JsonProperty("fortune")]
        public int FortuneLevel { get; private set; }

        [JsonProperty("godfather")]
        public int GodfatherLevel { get; private set; }

        [JsonProperty("superluck")]
        public int SuperluckLevel { get; private set; }

        [JsonProperty("transfusion")]
        public int TransfusionLevel { get; private set; }
        #endregion
    }
}
