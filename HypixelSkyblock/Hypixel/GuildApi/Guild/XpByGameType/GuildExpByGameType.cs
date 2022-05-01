using Newtonsoft.Json;

namespace Hypixel.NET.GuildApi.Guild.XpByGameType
{
    public class GuildExpByGameType
    {
        [JsonProperty("QUAKECRAFT")]
        public int Quake { get; private set; }

        [JsonProperty("WALLS")]
        public int Walls { get; private set; }

        [JsonProperty("PAINTBALL")]
        public int PaintBall { get; private set; }

        [JsonProperty("SURVIVAL_GAMES")]
        public int SurvivalGames { get; private set; }

        [JsonProperty("TNTGAMES")]
        public int TNTGames { get; private set; }

        [JsonProperty("VAMPIREZ")]
        public int VampireZ { get; private set; }

        [JsonProperty("ARCADE")]
        public int Arcade { get; private set; }

        [JsonProperty("ARENA")]
        public int Arena { get; private set; }

        [JsonProperty("MCGO")]
        public int McGo { get; private set; }

        [JsonProperty("UHC")]
        public int Uhc { get; private set; }

        [JsonProperty("BATTLEGROUND")]
        public int Warlords { get; private set; }

        [JsonProperty("SUPER_SMASH")]
        public int Smash { get; private set; }

        [JsonProperty("GINGERBREAD")]
        public int TurboKartRacers { get; private set; }

        [JsonProperty("SKYWARS")]
        public int SkyWars { get; private set; }

        [JsonProperty("TRUE_COMBAT")]
        public int CrazyWalls { get; private set; }

        [JsonProperty("SPEED_UHC")]
        public int SpeedUhc { get; private set; }

        [JsonProperty("SKYCLASH")]
        public int Skyclash { get; private set; }

        [JsonProperty("PROTOTYPE")]
        public int Prototype { get; private set; }

        [JsonProperty("BEDWARS")]
        public int Bedwars { get; private set; }

        [JsonProperty("MURDER_MYSTERY")]
        public int MurderMystery { get; private set; }

        [JsonProperty("BUILD_BATTLE")]
        public int BuildBattle { get; private set; }

        [JsonProperty("DUELS")]
        public int Duels { get; private set; }
    }
}