using System.Collections.Generic;
using Hypixel.NET.PlayerApi.Player.GameCounts.Games;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Stats
    {
        [JsonProperty("Arena")]
        public Arena Arena { get; private set; }

        [JsonProperty("HungerGames")]
        public HungerGames HungerGames { get; private set; }

        [JsonProperty("Paintball")]
        public Paintball Paintball { get; private set; }

        [JsonProperty("Quake")]
        public Quake Quake { get; private set; }

        [JsonProperty("TNTGames")]
        public TntGames TntGames { get; private set; }

        [JsonProperty("UHC")]
        public Uhc Uhc { get; private set; }

        [JsonProperty("VampireZ")]
        public VampireZ VampireZ { get; private set; }

        [JsonProperty("Walls")]
        public Walls Walls { get; private set; }

        [JsonProperty("Walls3")]
        public Walls3 Walls3 { get; private set; }

        [JsonProperty("GingerBread")]
        public GingerBread GingerBread { get; private set; }

        [JsonProperty("Arcade")]
        public Arcade Arcade { get; private set; }

        [JsonProperty("SkyWars")]
        public SkyWars SkyWars { get; private set; }

        [JsonProperty("TrueCombat")]
        public TrueCombat TrueCombat { get; private set; }

        [JsonProperty("Battleground")]
        public Battleground Battleground { get; private set; }

        [JsonProperty("MCGO")]
        public Mcgo Mcgo { get; private set; }

        [JsonProperty("SuperSmash")]
        public SuperSmash SuperSmash { get; private set; }

        [JsonProperty("SpeedUHC")]
        public SpeedUhc SpeedUhc { get; private set; }

        [JsonProperty("SkyClash")]
        public SkyClash SkyClash { get; private set; }

        [JsonProperty("Legacy")]
        public Legacy Legacy { get; private set; }

        [JsonProperty("Bedwars")]
        public Bedwars Bedwars { get; private set; }

        [JsonProperty("MurderMystery")]
        public MurderMystery MurderMystery { get; private set; }

        [JsonProperty("Duels")]
        public Duels Duels { get; private set; }

        [JsonProperty("BuildBattle")]
        public BuildBattle BuildBattle { get; private set; }

        [JsonProperty("Pit")]
        public Pit Pit { get; private set; }

        [JsonProperty("SkyBlock")]
        public Skyblock SkyBlock { get; private set; }
    }
}