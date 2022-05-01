using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class VampireZ
    {
        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("explosive_killer")]
        public int ExplosiveKiller { get; private set; }

        [JsonProperty("fireproofing")]
        public int Fireproofing { get; private set; }

        [JsonProperty("gold_booster")]
        public int GoldBooster { get; private set; }

        [JsonProperty("gold_starter")]
        public int GoldStarter { get; private set; }

        [JsonProperty("human_deaths")]
        public int HumanDeaths { get; private set; }

        [JsonProperty("human_kills")]
        public int HumanKills { get; private set; }

        [JsonProperty("human_wins")]
        public int HumanWins { get; private set; }

        [JsonProperty("most_vampire_kills")]
        public int MostVampireKills { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("vampire_deaths")]
        public int VampireDeaths { get; private set; }

        [JsonProperty("vampire_doubler")]
        public int VampireDoubler { get; private set; }

        [JsonProperty("vampire_kills")]
        public int VampireKills { get; private set; }

        [JsonProperty("vampiric_minion")]
        public int VampiricMinion { get; private set; }

        [JsonProperty("zombie_doubler")]
        public int ZombieDoubler { get; private set; }

        [JsonProperty("zombie_kills")]
        public int ZombieKills { get; private set; }

        [JsonProperty("transfusion")]
        public int Transfusion { get; private set; }

        [JsonProperty("renfield")]
        public int Renfield { get; private set; }

        [JsonProperty("frankensteins_monster")]
        public int FrankensteinsMonster { get; private set; }

        [JsonProperty("gold_bought")]
        public int GoldBought { get; private set; }

        [JsonProperty("vampire_wins")]
        public int VampireWins { get; private set; }
    }
}