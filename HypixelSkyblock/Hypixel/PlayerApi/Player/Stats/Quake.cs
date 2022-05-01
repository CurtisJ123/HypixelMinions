using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Quake
    {
        #region general stats
        [JsonProperty("coins")]
        public long Coins { get; private set; }

        [JsonProperty("deaths")]
        public long Deaths { get; private set; }

        [JsonProperty("kills")]
        public long Kills { get; private set; }

        [JsonProperty("killstreaks")]
        public long Killstreaks { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("wins")]
        public long Wins { get; private set; }

        [JsonProperty("instantRespawn")]
        public bool InstantRespawn { get; private set; }

        [JsonProperty("highest_killstreak")]
        public long HighestKillstreak { get; private set; }

        [JsonProperty("headshots")]
        public long Headshots { get; private set; }

        [JsonProperty("distance_travelled")]
        public long DistanceTravelled { get; private set; }

        [JsonProperty("shots_fired")]
        public long ShotsFired { get; private set; }

        [JsonProperty("kills_timeattack")]
        public long KillsTimeattack { get; private set; }

        [JsonProperty("kills_dm")]
        public long KillsDm { get; private set; }

        [JsonProperty("hat")]
        public string Hat { get; private set; }
        #endregion

        #region teams
        [JsonProperty("wins_teams")]
        public long WinsTeams { get; private set; }

        [JsonProperty("kills_teams")]
        public long KillsTeams { get; private set; }

        [JsonProperty("deaths_teams")]
        public long DeathsTeams { get; private set; }

        [JsonProperty("killstreaks_teams")]
        public long KillstreaksTeams { get; private set; }

        [JsonProperty("distance_travelled_teams")]
        public long DistanceTravelledTeams { get; private set; }

        [JsonProperty("shots_fired_teams")]
        public long ShotsFiredTeams { get; private set; }

        [JsonProperty("headshots_teams")]
        public long HeadshotsTeams { get; private set; }

        [JsonProperty("kills_dm_teams")]
        public long KillsDmTeams { get; private set; }
        #endregion

        #region weapon
        [JsonProperty("barrel")]
        public string Barrel { get; private set; }

        [JsonProperty("case")]
        public string Case { get; private set; }

        [JsonProperty("killsound")]
        public string Killsound { get; private set; }

        [JsonProperty("muzzle")]
        public string Muzzle { get; private set; }

        [JsonProperty("sight")]
        public string Sight { get; private set; }

        [JsonProperty("trigger")]
        public string Trigger { get; private set; }

        [JsonProperty("beam")]
        public string Beam { get; private set; }
        #endregion
    }
}
