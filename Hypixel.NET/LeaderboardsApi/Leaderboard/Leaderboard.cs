using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.LeaderboardsApi.Leaderboard
{
    public class Leaderboard
    {
        [JsonProperty("TNTGAMES")]
        public List<LeaderboardData> TntGames;

        [JsonProperty("WALLS")]
        public List<LeaderboardData> Walls;

        [JsonProperty("QUAKECRAFT")]
        public List<LeaderboardData> Quake;

        [JsonProperty("SKYWARS")]
        public List<LeaderboardData> SkyWars;

        [JsonProperty("VAMPIREZ")]
        public List<LeaderboardData> VampireZ;

        [JsonProperty("WALLS3")]
        public List<LeaderboardData> Walls3;

        [JsonProperty("SKYCLASH")]
        public List<LeaderboardData> SkyClash;

        [JsonProperty("BEDWARS")]
        public List<LeaderboardData> BedWars;

        [JsonProperty("BUILD_BATTLE")]
        public List<LeaderboardData> BuildBattle;

        [JsonProperty("UHC")]
        public List<LeaderboardData> Uhc;

        [JsonProperty("PAINTBALL")]
        public List<LeaderboardData> PaintBall;

        [JsonProperty("SUPER_SMASH")]
        public List<LeaderboardData> Smash;

        [JsonProperty("TRUE_COMBAT")]
        public List<LeaderboardData> TrueCombat;

        [JsonProperty("MCGO")]
        public List<LeaderboardData> CopsAndCrims;

        [JsonProperty("SURVIVAL_GAMES")]
        public List<LeaderboardData> BlitzSg;

        [JsonProperty("BATTLEGROUND")]
        public List<LeaderboardData> Warlords;

        [JsonProperty("MURDER_MYSTERY")]
        public List<LeaderboardData> MurderMystery;

        [JsonProperty("ARENA")]
        public List<LeaderboardData> Arena;

        [JsonProperty("SPEED_UHC")]
        public List<LeaderboardData> SpeedUhc;

        [JsonProperty("ARCADE")]
        public List<LeaderboardData> Arcade;

        [JsonProperty("DUELS")]
        public List<LeaderboardData> Duels;

        [JsonProperty("GINGERBREAD")]
        public List<LeaderboardData> TurboKartRacers;
    }
}