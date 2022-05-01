using Hypixel.NET.PlayerApi.Player.Stats.SmashHeros.Heros;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats.SmashHeros
{
    public class ClassStats
    {
        [JsonProperty("THE_BULK")]
        public TheBulk TheBulk { get; private set; }

        [JsonProperty("CAKE_MONSTER")]
        public CakeMonster CakeMonster { get; private set; }

        [JsonProperty("GENERAL_CLUCK")]
        public GeneralCluck GeneralCluck { get; private set; }

        [JsonProperty("BOTMUN")]
        public Botmun Botmun { get; private set; }

        [JsonProperty("FROSTY")]
        public Frosty Frosty { get; private set; }

        [JsonProperty("TINMAN")]
        public Tinman Tinman { get; private set; }

        [JsonProperty("MARAUDER")]
        public Marauder Marauder { get; private set; }

        [JsonProperty("GOKU")]
        public Goku Goku { get; private set; }

        [JsonProperty("SPODERMAN")]
        public Spoderman Spoderman { get; private set; }

        [JsonProperty("PUG")]
        public Pug Pug { get; private set; }

        [JsonProperty("SKULLFIRE")]
        public Skullfire Skullfire { get; private set; }

        [JsonProperty("SHOOP_DA_WHOOP")]
        public ShoopDaWhoop ShoopDaWhoop { get; private set; }

        [JsonProperty("DUSK_CRAWLER")]
        public DuskCrawler DuskCrawler { get; private set; }

        [JsonProperty("SERGEANT_SHIELD")]
        public SergeantShield SergeantShield { get; private set; }

        [JsonProperty("SANIC")]
        public Sanic Sanic { get; private set; }

        [JsonProperty("GREEN_HOOD")]
        public GreenHood GreenHood { get; private set; }
    }
}