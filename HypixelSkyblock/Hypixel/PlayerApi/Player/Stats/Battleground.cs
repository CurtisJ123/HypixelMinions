using System.Collections.Generic;
using Hypixel.NET.PlayerApi.Player.Stats.Battlegrounds;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Battleground
    {

        #region general
        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("chosen_class")]
        public string ChosenClass { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("selected_mount")]
        public string SelectedMount { get; private set; }

        [JsonProperty("void_shards")]
        public int VoidShards { get; private set; }

        [JsonProperty("weapon_inventory")]
        public List<WeaponInventory> WeaponInventory { get; private set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("play_streak")]
        public int PlayStreak { get; private set; }

        [JsonProperty("hotkeymode")]
        public bool Hotkeymode { get; private set; }

        [JsonProperty("prestiged")]
        public List<string> PrestigedClasses { get; private set; }
        #endregion

        #region general stats
        [JsonProperty("broken_inventory")]
        public int BrokenInventory { get; private set; }

        [JsonProperty("damage")]
        public long Damage { get; private set; }

        [JsonProperty("crafted")]
        public int Crafted { get; private set; }

        [JsonProperty("crafted_epic")]
        public int CraftedEpic { get; private set; }

        [JsonProperty("damage_prevented")]
        public long DamagePrevented { get; private set; }

        [JsonProperty("damage_taken")]
        public long DamageTaken { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("assists")]
        public int Assists { get; private set; }

        [JsonProperty("life_leeched")]
        public long LifeLeeched { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("magic_dust")]
        public int MagicDust { get; private set; }

        [JsonProperty("repaired")]
        public int Repaired { get; private set; }

        [JsonProperty("repaired_common")]
        public int RepairedCommon { get; private set; }

        [JsonProperty("repaired_epic")]
        public int RepairedEpic { get; private set; }

        [JsonProperty("repaired_rare")]
        public int RepairedRare { get; private set; }

        [JsonProperty("salvaged_dust_reward")]
        public int SalvagedDustReward { get; private set; }

        [JsonProperty("salvaged_shards_reward")]
        public int SalvagedShardsReward { get; private set; }

        [JsonProperty("salvaged_weapons")]
        public int SalvagedWeapons { get; private set; }

        [JsonProperty("salvaged_weapons_common")]
        public int SalvagedWeaponsCommon { get; private set; }

        [JsonProperty("salvaged_weapons_rare")]
        public int SalvagedWeaponsRare { get; private set; }

        [JsonProperty("upgrade_random")]
        public int UpgradeRandom { get; private set; }

        [JsonProperty("upgrade_random_epic")]
        public int UpgradeRandomEpic { get; private set; }

        [JsonProperty("wins_blu")]
        public int WinsBlue { get; private set; }

        [JsonProperty("wins_capturetheflag")]
        public int WinsCapturetheflag { get; private set; }

        [JsonProperty("wins_capturetheflag_blu")]
        public int WinsCapturetheflagBlue { get; private set; }

        [JsonProperty("wins_capturetheflag_red")]
        public int WinsCapturetheflagRed { get; private set; }

        [JsonProperty("wins_domination")]
        public int WinsDomination { get; private set; }

        [JsonProperty("wins_domination_blu")]
        public int WinsDominationBlue { get; private set; }

        [JsonProperty("wins_domination_red")]
        public int WinsDominationRed { get; private set; }

        [JsonProperty("wins_red")]
        public int WinsRed { get; private set; }

        [JsonProperty("salvaged_weapons_epic")]
        public int SalvagedWeaponsEpic { get; private set; }

        [JsonProperty("upgrade_crafted")]
        public int UpgradeCrafted { get; private set; }

        [JsonProperty("upgrade_crafted_epic")]
        public int UpgradeCraftedEpic { get; private set; }

        [JsonProperty("reroll_epic")]
        public int RerollEpic { get; private set; }

        [JsonProperty("reroll")]
        public int Reroll { get; private set; }

        [JsonProperty("repaired_legendary")]
        public int RepairedLegendary { get; private set; }

        [JsonProperty("salvaged_weapons_legendary")]
        public int SalvagedWeaponsLegendary { get; private set; }

        [JsonProperty("crafted_legendary")]
        public int CraftedLegendary { get; private set; }

        [JsonProperty("reroll_legendary")]
        public int RerollLegendary { get; private set; }

        [JsonProperty("afk_warned")]
        public int AfkWarned { get; private set; }

        [JsonProperty("penalty")]
        public int Penalty { get; private set; }

        [JsonProperty("upgrade_crafted_legendary")]
        public int UpgradeCraftedLegendary { get; private set; }

        [JsonProperty("wins_teamdeathmatch")]
        public int WinsTeamdeathmatch { get; private set; }

        [JsonProperty("wins_teamdeathmatch_blu")]
        public int WinsTeamdeathmatchBlue { get; private set; }

        [JsonProperty("wins_teamdeathmatch_red")]
        public int WinsTeamdeathmatchRed { get; private set; }

        [JsonProperty("crafted_rare")]
        public int CraftedRare { get; private set; }

        [JsonProperty("reroll_common")]
        public int RerollCommon { get; private set; }

        [JsonProperty("upgrade_random_legendary")]
        public int UpgradeRandomLegendary { get; private set; }

        [JsonProperty("reward_inventory")]
        public int RewardInventory { get; private set; }

        [JsonProperty("kills_capturetheflag")]
        public int CapturetheflagKills { get; private set; }

        [JsonProperty("kills_teamdeathmatch")]
        public int TeamdeathmatchKills { get; private set; }

        [JsonProperty("kills_domination")]
        public int DominationKills { get; private set; }

        [JsonProperty("total_domination_score")]
        public int TotalDominationScore { get; private set; }

        [JsonProperty("flag_returns")]
        public int FlagReturns { get; private set; }

        [JsonProperty("mvp_count")]
        public int MvpCount { get; private set; }

        [JsonProperty("dom_point_captures")]
        public int DomPointCaptures { get; private set; }

        [JsonProperty("dom_point_defends")]
        public int DomPointDefends { get; private set; }

        [JsonProperty("powerups_collected")]
        public int PowerupsCollected { get; private set; }
        #endregion

        #region berserker
        [JsonProperty("berserker_plays")]
        public int BerserkerPlays { get; private set; }

        [JsonProperty("damage_berserker")]
        public long BerserkerDamage { get; private set; }

        [JsonProperty("damage_prevented_berserker")]
        public long BerserkerDamagePrevented { get; private set; }

        [JsonProperty("heal_berserker")]
        public long BerserkerHealing { get; private set; }

        [JsonProperty("life_leeched_berserker")]
        public long BerserkerLifeLeeched { get; private set; }

        [JsonProperty("losses_berserker")]
        public int BerserkerLosses { get; private set; }

        [JsonProperty("wins_berserker")]
        public int BerserkerWins { get; private set; }
        #endregion

        #region defender
        [JsonProperty("damage_defender")]
        public long DefenderDamage { get; private set; }

        [JsonProperty("damage_prevented_defender")]
        public long DefenderDamagePrevented { get; private set; }

        [JsonProperty("defender_plays")]
        public int DefenderPlays { get; private set; }

        [JsonProperty("heal_defender")]
        public long DefenderHealing { get; private set; }

        [JsonProperty("losses_defender")]
        public int DefenderLosses { get; private set; }

        [JsonProperty("wins_defender")]
        public int DefenderWins { get; private set; }
        #endregion

        #region warrior
        [JsonProperty("damage_prevented_warrior")]
        public long WarriorDamagePrevented { get; private set; }

        [JsonProperty("damage_warrior")]
        public long WarriorDamage { get; private set; }

        [JsonProperty("heal_warrior")]
        public long WarriorHeal { get; private set; }

        [JsonProperty("life_leeched_warrior")]
        public long WarriorLifeLeeched { get; private set; }

        [JsonProperty("losses_warrior")]
        public int WarriorLosses { get; private set; }

        [JsonProperty("warrior_cooldown")]
        public int WarriorCooldown { get; private set; }

        [JsonProperty("warrior_critchance")]
        public int WarriorCritchance { get; private set; }

        [JsonProperty("warrior_critmultiplier")]
        public int WarriorCritmultiplier { get; private set; }

        [JsonProperty("warrior_energy")]
        public int WarriorEnergyLevel { get; private set; }

        [JsonProperty("warrior_health")]
        public int WarriorHealthLevel { get; private set; }

        [JsonProperty("warrior_plays")]
        public int WarriorPlays { get; private set; }

        [JsonProperty("warrior_skill1")]
        public int WarriorSkill1Level { get; private set; }

        [JsonProperty("warrior_skill2")]
        public int WarriorSkill2Level { get; private set; }

        [JsonProperty("warrior_skill3")]
        public int WarriorSkill3Level { get; private set; }

        [JsonProperty("warrior_skill4")]
        public int WarriorSkill4Level { get; private set; }

        [JsonProperty("warrior_skill5")]
        public int WarriorSkill5Level { get; private set; }

        [JsonProperty("warrior_spec")]
        public string WarriorSpec { get; private set; }

        [JsonProperty("wins_warrior")]
        public int WarriorWins { get; private set; }
        #endregion

        #region mage
        [JsonProperty("mage_spec")]
        public string MageSpec { get; private set; }

        [JsonProperty("heal_mage")]
        public long MageHeal { get; private set; }

        [JsonProperty("damage_prevented_mage")]
        public long MageDamagePrevented { get; private set; }

        [JsonProperty("wins_mage")]
        public int MageWins { get; private set; }

        [JsonProperty("damage_mage")]
        public int MageDamage { get; private set; }

        [JsonProperty("mage_plays")]
        public int MagePlays { get; private set; }

        [JsonProperty("losses_mage")]
        public int MageLosses { get; private set; }

        [JsonProperty("mage_skill1")]
        public int MageSkill1Level { get; private set; }

        [JsonProperty("mage_skill3")]
        public int MageSkill3Level { get; private set; }

        [JsonProperty("mage_skill4")]
        public int MageSkill4Level { get; private set; }

        [JsonProperty("mage_skill5")]
        public int MageSkill5Level { get; private set; }

        [JsonProperty("mage_skill2")]
        public int MageSkill2Level { get; private set; }

        [JsonProperty("mage_health")]
        public int MageHealthLevel { get; private set; }

        [JsonProperty("mage_energy")]
        public int MageEnergyLevel { get; private set; }

        [JsonProperty("mage_cooldown")]
        public int MageCooldownLevel { get; private set; }

        [JsonProperty("mage_critchance")]
        public int MageCritchanceLevel { get; private set; }

        [JsonProperty("mage_critmultiplier")]
        public int MageCritmultiplierLevel { get; private set; }
        #endregion

        #region paladin
        [JsonProperty("paladin_spec")]
        public string PaladinSpec { get; private set; }

        [JsonProperty("damage_paladin")]
        public long PaladinDamage { get; private set; }

        [JsonProperty("paladin_plays")]
        public int PaladinPlays { get; private set; }

        [JsonProperty("losses_paladin")]
        public int PaladinLosses { get; private set; }

        [JsonProperty("heal_paladin")]
        public long PaladinHeals { get; private set; }

        [JsonProperty("damage_prevented_paladin")]
        public int PaladinDamagePrevented { get; private set; }

        [JsonProperty("wins_paladin")]
        public int PaladinWins { get; private set; }

        [JsonProperty("paladin_skill5")]
        public int PaladinSkill5Level { get; private set; }

        [JsonProperty("paladin_skill4")]
        public int PaladinSkill4Level { get; private set; }

        [JsonProperty("paladin_skill3")]
        public int PaladinSkill3Level { get; private set; }

        [JsonProperty("paladin_skill1")]
        public int PaladinSkill1Level { get; private set; }

        [JsonProperty("paladin_skill2")]
        public int PaladinSkill2Level { get; private set; }

        [JsonProperty("paladin_energy")]
        public int PaladinEnergyLevel { get; private set; }

        [JsonProperty("paladin_critmultiplier")]
        public int PaladinCritmultiplierLevel { get; private set; }

        [JsonProperty("paladin_health")]
        public int PaladinHealthLevel { get; private set; }

        [JsonProperty("paladin_cooldown")]
        public int PaladinCooldownLevel { get; private set; }

        [JsonProperty("paladin_critchance")]
        public int PaladinCritchanceLevel { get; private set; }
        #endregion

        #region pyromancer
        [JsonProperty("damage_pyromancer")]
        public long PyromancerDamage { get; private set; }

        [JsonProperty("heal_pyromancer")]
        public long PyromancerHeals { get; private set; }

        [JsonProperty("damage_prevented_pyromancer")]
        public long PyromancerDamagePrevented { get; private set; }

        [JsonProperty("pyromancer_plays")]
        public int PyromancerPlays { get; private set; }

        [JsonProperty("wins_pyromancer")]
        public int PyromancerWins { get; private set; }

        [JsonProperty("losses_pyromancer")]
        public int PyromancerLosses { get; private set; }
        #endregion

        #region avenger
        [JsonProperty("losses_avenger")]
        public int AvengerLosses { get; private set; }

        [JsonProperty("damage_avenger")]
        public int AvengerDamage { get; private set; }

        [JsonProperty("avenger_plays")]
        public int PlaysAvenger { get; private set; }

        [JsonProperty("heal_avenger")]
        public long AvengerHeals { get; private set; }

        [JsonProperty("damage_prevented_avenger")]
        public long AvengerDamagePrevented { get; private set; }

        [JsonProperty("wins_avenger")]
        public int AvengerWins { get; private set; }
        #endregion

        #region cryomancer
        [JsonProperty("cryomancer_plays")]
        public int CryomancerPlays { get; private set; }

        [JsonProperty("wins_cryomancer")]
        public int CryomancerWins { get; private set; }

        [JsonProperty("heal_cryomancer")]
        public long CryomancerHeals { get; private set; }

        [JsonProperty("damage_prevented_cryomancer")]
        public long CryomancerDamagePrevented { get; private set; }

        [JsonProperty("damage_cryomancer")]
        public long CryomancerDamage { get; private set; }

        [JsonProperty("losses_cryomancer")]
        public int CryomancerLosses { get; private set; }
        #endregion

        #region aquamancer
        [JsonProperty("damage_prevented_aquamancer")]
        public long AquamancerDamagePrevented { get; private set; }

        [JsonProperty("wins_aquamancer")]
        public int AquamancerWins { get; private set; }

        [JsonProperty("damage_aquamancer")]
        public long AquamancerDamage { get; private set; }

        [JsonProperty("aquamancer_plays")]
        public int AquamancerPlays { get; private set; }

        [JsonProperty("heal_aquamancer")]
        public long AquamancerHeals { get; private set; }

        [JsonProperty("losses_aquamancer")]
        public int AquamancerLosses { get; private set; }
        #endregion

        #region shaman
        [JsonProperty("shaman_spec")]
        public string ShamanSpec { get; private set; }

        [JsonProperty("damage_shaman")]
        public long ShamanDamage { get; private set; }

        [JsonProperty("shaman_plays")]
        public int ShamanPlays { get; private set; }

        [JsonProperty("damage_prevented_shaman")]
        public long ShamanDamagePrevented { get; private set; }

        [JsonProperty("heal_shaman")]
        public long ShamanHeals { get; private set; }

        [JsonProperty("wins_shaman")]
        public int ShamanWins { get; private set; }

        [JsonProperty("losses_shaman")]
        public int ShamanLosses { get; private set; }

        [JsonProperty("shaman_skill1")]
        public int ShamanSkill1Level { get; private set; }

        [JsonProperty("shaman_skill3")]
        public int ShamanSkill3Level { get; private set; }

        [JsonProperty("shaman_skill2")]
        public int ShamanSkill2Level { get; private set; }

        [JsonProperty("shaman_skill4")]
        public int ShamanSkill4Level { get; private set; }

        [JsonProperty("shaman_skill5")]
        public int ShamanSkill5Level { get; private set; }

        [JsonProperty("shaman_critmultiplier")]
        public int ShamanCritmultiplierLevel { get; private set; }

        [JsonProperty("shaman_energy")]
        public int ShamanEnergyLevel { get; private set; }

        [JsonProperty("shaman_critchance")]
        public int ShamanCritchanceLevel { get; private set; }

        [JsonProperty("shaman_cooldown")]
        public int ShamanCooldownLevel { get; private set; }

        [JsonProperty("shaman_health")]
        public int ShamanHealthLevel { get; private set; }
        #endregion

        #region earthwarden
        [JsonProperty("damage_prevented_earthwarden")]
        public long EarthwardenDamagePrevented { get; private set; }

        [JsonProperty("damage_earthwarden")]
        public long EarthwardenDamage { get; private set; }

        [JsonProperty("earthwarden_plays")]
        public int EarthwardenPlays { get; private set; }

        [JsonProperty("heal_earthwarden")]
        public long EarthwardenHeals { get; private set; }

        [JsonProperty("wins_earthwarden")]
        public int EarthwardenWins { get; private set; }

        [JsonProperty("losses_earthwarden")]
        public int EarthwardenLosses { get; private set; }
        #endregion

        #region thunderlord
        [JsonProperty("heal_thunderlord")]
        public long ThunderlordHeals { get; private set; }

        [JsonProperty("thunderlord_plays")]
        public int ThunderlordPlays { get; private set; }

        [JsonProperty("damage_thunderlord")]
        public long ThunderlordDamage { get; private set; }

        [JsonProperty("losses_thunderlord")]
        public int ThunderlordLosses { get; private set; }

        [JsonProperty("damage_prevented_thunderlord")]
        public long ThunderlordDamagePrevented { get; private set; }

        [JsonProperty("wins_thunderlord")]
        public int ThunderlordWins { get; private set; }
        #endregion

        #region crusader
        [JsonProperty("crusader_plays")]
        public int CrusaderPlays { get; private set; }

        [JsonProperty("heal_crusader")]
        public long CrusaderHeals { get; private set; }

        [JsonProperty("wins_crusader")]
        public int CrusaderWins { get; private set; }

        [JsonProperty("damage_crusader")]
        public long CrusaderDamage { get; private set; }

        [JsonProperty("damage_prevented_crusader")]
        public long CrusaderDamagePrevented { get; private set; }

        [JsonProperty("losses_crusader")]
        public int CrusaderLosses { get; private set; }
        #endregion

        #region protector
        [JsonProperty("wins_protector")]
        public int ProtectorWins { get; private set; }

        [JsonProperty("heal_protector")]
        public long ProtectorHeals { get; private set; }

        [JsonProperty("protector_plays")]
        public int ProtectorPlays { get; private set; }

        [JsonProperty("damage_prevented_protector")]
        public long ProtectorDamagePrevented { get; private set; }

        [JsonProperty("damage_protector")]
        public long ProtectorDamage { get; private set; }

        [JsonProperty("losses_protector")]
        public int ProtectorLosses { get; private set; }
        #endregion
    }
}