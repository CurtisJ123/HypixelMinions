using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Walls
    {
        [JsonProperty("adrenaline")]
        public int Adrenaline { get; private set; }

        [JsonProperty("bacon")]
        public int Bacon { get; private set; }

        [JsonProperty("berserk")]
        public int Berserk { get; private set; }

        [JsonProperty("blacksmith")]
        public int Blacksmith { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("fortune")]
        public int Fortune { get; private set; }

        [JsonProperty("gold_rush")]
        public int GoldRush { get; private set; }

        [JsonProperty("guitarist")]
        public int Guitarist { get; private set; }

        [JsonProperty("haste")]
        public int Haste { get; private set; }

        [JsonProperty("hunter")]
        public int Hunter { get; private set; }

        [JsonProperty("insane_farmer")]
        public int InsaneFarmer { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("lazyman")]
        public int Lazyman { get; private set; }

        [JsonProperty("leather_worker")]
        public int LeatherWorker { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("master_troll")]
        public int MasterTroll { get; private set; }

        [JsonProperty("opportunity")]
        public int Opportunity { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("pyromaniac")]
        public int Pyromaniac { get; private set; }

        [JsonProperty("ready")]
        public int Ready { get; private set; }

        [JsonProperty("redstone_expert")]
        public int RedstoneExpert { get; private set; }

        [JsonProperty("sage")]
        public int Sage { get; private set; }

        [JsonProperty("scotsman")]
        public int Scotsman { get; private set; }

        [JsonProperty("skybase_king")]
        public int SkybaseKing { get; private set; }

        [JsonProperty("smart_boy")]
        public int SmartBoy { get; private set; }

        [JsonProperty("snack_lover")]
        public int SnackLover { get; private set; }

        [JsonProperty("soup_drinker")]
        public int SoupDrinker { get; private set; }

        [JsonProperty("swift")]
        public int Swift { get; private set; }

        [JsonProperty("tenacity")]
        public int Tenacity { get; private set; }

        [JsonProperty("trap_engineer")]
        public int TrapEngineer { get; private set; }

        [JsonProperty("vampirism")]
        public int Vampirism { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("expert_miner")]
        public int ExpertMiner { get; private set; }

        [JsonProperty("chainkiller")]
        public int Chainkiller { get; private set; }

        [JsonProperty("fireproof")]
        public int Fireproof { get; private set; }

        [JsonProperty("burn_baby_burn")]
        public int BurnBabyBurn { get; private set; }

        [JsonProperty("final_form")]
        public int FinalForm { get; private set; }

        [JsonProperty("cats_eye")]
        public int CatsEye { get; private set; }

        [JsonProperty("artisan")]
        public int Artisan { get; private set; }

        [JsonProperty("fisherman")]
        public int Fisherman { get; private set; }

        [JsonProperty("vitality")]
        public int Vitality { get; private set; }

        [JsonProperty("thats_hot")]
        public int ThatsHot { get; private set; }

        [JsonProperty("really_shiny")]
        public int ReallyShiny { get; private set; }

        [JsonProperty("very_fortunate")]
        public int VeryFortunate { get; private set; }
    }
}