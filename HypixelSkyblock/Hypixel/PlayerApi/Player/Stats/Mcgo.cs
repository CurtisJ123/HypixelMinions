using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Mcgo
    {
        #region general stats
        [JsonProperty("bombs_defused")]
        public int BombsDefused { get; private set; }

        [JsonProperty("bombs_planted")]
        public int BombsPlanted { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("cop_kills")]
        public int CopKills { get; private set; }

        [JsonProperty("criminal_kills")]
        public int CriminalKills { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("game_wins")]
        public int GameWins { get; private set; }

        [JsonProperty("headshot_kills")]
        public int HeadshotKills { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("round_wins")]
        public int RoundWins { get; private set; }

        [JsonProperty("shots_fired")]
        public int ShotsFired { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("criminal_kills_deathmatch")]
        public int CriminalKillsDeathmatch { get; private set; }

        [JsonProperty("kills_deathmatch")]
        public int KillsDeathmatch { get; private set; }

        [JsonProperty("cop_kills_deathmatch")]
        public int CopKillsDeathmatch { get; private set; }

        [JsonProperty("game_wins_deathmatch")]
        public int GameWinsDeathmatch { get; private set; }

        [JsonProperty("deaths_deathmatch")]
        public int DeathsDeathmatch { get; private set; }

        [JsonProperty("grenade_kills")]
        public int McgoGrenadeKills { get; private set; }

        [JsonProperty("grenadeKills")]
        public int GrenadeKills { get; private set; }
        #endregion

        #region weapons
        [JsonProperty("carbine_cost_reduction")]
        public int CarbineCostReductionLevel { get; private set; }

        [JsonProperty("carbine_damage_increase")]
        public int CarbineDamageIncreaseLevel { get; private set; }

        [JsonProperty("carbine_recoil_reduction")]
        public int CarbineRecoilReductionLevel { get; private set; }

        [JsonProperty("carbine_reload_speed_reduction")]
        public int CarbineReloadSpeedReductionLevel { get; private set; }

        [JsonProperty("knife_attack_delay")]
        public int KnifeAttackDelayLevel { get; private set; }

        [JsonProperty("knife_damage_increase")]
        public int KnifeDamageIncreaseLevel { get; private set; }

        [JsonProperty("magnum_cost_reduction")]
        public int MagnumCostReductionLevel { get; private set; }

        [JsonProperty("magnum_damage_increase")]
        public int MagnumDamageIncreaseLevel { get; private set; }

        [JsonProperty("magnum_recoil_reduction")]
        public int MagnumRecoilReductionLevel { get; private set; }

        [JsonProperty("magnum_reload_speed_reduction")]
        public int MagnumReloadSpeedReductionLevel { get; private set; }

        [JsonProperty("pistol_damage_increase")]
        public int PistolDamageIncreaseLevel { get; private set; }

        [JsonProperty("pistol_recoil_reduction")]
        public int PistolRecoilReductionLevel { get; private set; }

        [JsonProperty("pistol_reload_speed_reduction")]
        public int PistolReloadSpeedReductionLevel { get; private set; }

        [JsonProperty("rifle_cost_reduction")]
        public int RifleCostReductionLevel { get; private set; }

        [JsonProperty("rifle_damage_increase")]
        public int RifleDamageIncreaseLevel { get; private set; }

        [JsonProperty("rifle_recoil_reduction")]
        public int RifleRecoilReductionLevel { get; private set; }

        [JsonProperty("rifle_reload_speed_reduction")]
        public int RifleReloadSpeedReductionLevel { get; private set; }

        [JsonProperty("shotgun_cost_reduction")]
        public int ShotgunCostReductionLevel { get; private set; }

        [JsonProperty("shotgun_damage_increase")]
        public int ShotgunDamageIncreaseLevel { get; private set; }

        [JsonProperty("shotgun_recoil_reduction")]
        public int ShotgunRecoilReductionLevel { get; private set; }

        [JsonProperty("shotgun_reload_speed_reduction")]
        public int ShotgunReloadSpeedReductionLevel { get; private set; }

        [JsonProperty("smg_cost_reduction")]
        public int SmgCostReductionLevel { get; private set; }

        [JsonProperty("smg_damage_increase")]
        public int SmgDamageIncreaseLevel { get; private set; }

        [JsonProperty("smg_recoil_reduction")]
        public int SmgRecoilReductionLevel { get; private set; }

        [JsonProperty("smg_reload_speed_reduction")]
        public int SmgReloadSpeedReductionLevel { get; private set; }

        [JsonProperty("sniper_charge_bonus")]
        public int SniperChargeBonusLevel { get; private set; }

        [JsonProperty("sniper_cost_reduction")]
        public int SniperCostReductionLevel { get; private set; }

        [JsonProperty("sniper_damage_increase")]
        public int SniperDamageIncreaseLevel { get; private set; }

        [JsonProperty("sniper_reload_speed_reduction")]
        public int SniperReloadSpeedReductionLevel { get; private set; }
        #endregion

        #region game wins
        [JsonProperty("game_wins_overgrown")]
        public int GameWinsOvergrown { get; private set; }

        [JsonProperty("game_wins_temple")]
        public int GameWinsTemple { get; private set; }

        [JsonProperty("game_wins_carrier")]
        public int GameWinsCarrier { get; private set; }

        [JsonProperty("game_wins_atomic")]
        public int GameWinsAtomic { get; private set; }

        [JsonProperty("game_wins_alleyway")]
        public int GameWinsAlleyway { get; private set; }

        [JsonProperty("game_wins_sandstorm")]
        public int GameWinsSandstorm { get; private set; }

        [JsonProperty("game_wins_reserve")]
        public int GameWinsReserve { get; private set; }

        [JsonProperty("game_wins_melon factory")]
        public int GameWinsMelonFactory { get; private set; }
        #endregion

        #region cosmetic items
        [JsonProperty("selectedCreeperHelmetDev")]
        public string SelectedCreeperHelmet { get; private set; }

        [JsonProperty("selectedOcelotChestplateDev")]
        public string SelectedOcelotChestplate { get; private set; }

        [JsonProperty("selectedCreeperChestplateDev")]
        public string SelectedCreeperChestplate { get; private set; }

        [JsonProperty("selectedCarbineDev")]
        public string SelectedCarbine { get; private set; }

        [JsonProperty("selectedKnifeDev")]
        public string SelectedKnife { get; private set; }

        [JsonProperty("selectedPistolDev")]
        public string SelectedPistol { get; private set; }

        [JsonProperty("selectedSmgDev")]
        public string SelectedSmg { get; private set; }

        [JsonProperty("selectedOcelotHelmetDev")]
        public string SelectedOcelotHelmet { get; private set; }

        [JsonProperty("selectedRifleDev")]
        public string SelectedRifle { get; private set; }

        [JsonProperty("selectedMagnumDev")]
        public string SelectedMagnum { get; private set; }

        [JsonProperty("selectedShotgunDev")]
        public string SelectedShotgun { get; private set; }
        #endregion

        #region misc upgrades
        [JsonProperty("body_armor_cost")]
        public int BodyArmourCostLevel { get; private set; }

        [JsonProperty("pocket_change")]
        public int PocketChangeLevel { get; private set; }

        [JsonProperty("strength_training")]
        public int StrengthTrainingLevel { get; private set; }
        #endregion
    }
}