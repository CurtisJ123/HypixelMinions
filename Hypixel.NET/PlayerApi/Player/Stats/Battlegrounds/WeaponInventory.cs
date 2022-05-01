using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats.Battlegrounds
{
    public class WeaponInventory
    {
        [JsonProperty("ability")]
        public int Ability { get; private set; }

        [JsonProperty("abilityBoost")]
        public int AbilityBoost { get; private set; }

        [JsonProperty("damage")]
        public int Damage { get; private set; }

        [JsonProperty("energy")]
        public int Energy { get; private set; }

        [JsonProperty("chance")]
        public int Chance { get; private set; }

        [JsonProperty("multiplier")]
        public int Multiplier { get; private set; }

        [JsonProperty("health")]
        public int Health { get; private set; }

        [JsonProperty("cooldown")]
        public int Cooldown { get; private set; }

        [JsonProperty("movement")]
        public int Movement { get; private set; }

        [JsonProperty("material")]
        public string Material { get; private set; }

        [JsonProperty("crafted")]
        public bool Crafted { get; private set; }

        [JsonProperty("upgradeMax")]
        public int UpgradeMax { get; private set; }

        [JsonProperty("upgradeTimes")]
        public int UpgradeTimes { get; private set; }
    }
}