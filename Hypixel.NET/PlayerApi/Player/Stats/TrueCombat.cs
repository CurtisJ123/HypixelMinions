using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class TrueCombat
    {
        #region general stats
        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; private set; }

        [JsonProperty("games")]
        public int Games { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("survived_players")]
        public int SurvivedPlayers { get; private set; }

        [JsonProperty("items_enchanted")]
        public int ItemsEnchanted { get; private set; }

        [JsonProperty("arrows_shot")]
        public int ArrowsShot { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("skulls_gathered")]
        public int SkullsGathered { get; private set; }

        [JsonProperty("golden_skulls")]
        public int GoldenSkulls { get; private set; }

        [JsonProperty("giant_zombie")]
        public int GiantZombie { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("activeKit_Team")]
        public string ActiveKitTeam { get; private set; }

        [JsonProperty("activeKit_Solo")]
        public string ActiveKitSolo { get; private set; }

        [JsonProperty("giant_zombie_legendaries")]
        public int GiantZombieLegendaries { get; private set; }

        [JsonProperty("giant_zombie_rares")]
        public int GiantZombieRares { get; private set; }

        [JsonProperty("activeKit_Solo_chaos")]
        public string ActiveKitSoloChaos { get; private set; }

        [JsonProperty("gold_dust")]
        public int GoldDust { get; private set; }

        [JsonProperty("activeKit_Team_chaos")]
        public string ActiveKitTeamChaos { get; private set; }

        [JsonProperty("arrows_hit")]
        public int ArrowsHit { get; private set; }
        #endregion

        #region crazywalls chaos
        [JsonProperty("crazywalls_losses_solo_chaos")]
        public int CrazywallsLossesSoloChaos { get; private set; }

        [JsonProperty("crazywalls_games_solo_chaos")]
        public int CrazywallsGamesSoloChaos { get; private set; }

        [JsonProperty("crazywalls_deaths_solo_chaos")]
        public int CrazywallsDeathsSoloChaos { get; private set; }

        [JsonProperty("crazywalls_kills_weekly_b_solo_chaos")]
        public int CrazywallsKillsWeeklyBSoloChaos { get; private set; }

        [JsonProperty("crazywalls_kills_solo_chaos")]
        public int CrazywallsKillsSoloChaos { get; private set; }

        [JsonProperty("crazywalls_games_team_chaos")]
        public int CrazywallsGamesTeamChaos { get; private set; }

        [JsonProperty("crazywalls_losses_team_chaos")]
        public int CrazywallsLossesTeamChaos { get; private set; }

        [JsonProperty("crazywalls_deaths_team_chaos")]
        public int CrazywallsDeathsTeamChaos { get; private set; }

        [JsonProperty("crazywalls_kills_team_chaos")]
        public int CrazywallsKillsTeamChaos { get; private set; }

        [JsonProperty("crazywalls_wins_solo_chaos")]
        public int CrazywallsWinsSoloChaos { get; private set; }

        [JsonProperty("crazywalls_wins_team_chaos")]
        public int CrazywallsWinsTeamChaos { get; private set; }
        #endregion

        #region crazywalls general
        [JsonProperty("crazywalls_losses_solo")]
        public int CrazywallsLossesSolo { get; private set; }

        [JsonProperty("crazywalls_deaths_solo")]
        public int CrazywallsDeathsSolo { get; private set; }

        [JsonProperty("crazywalls_games_solo")]
        public int CrazywallsGamesSolo { get; private set; }

        [JsonProperty("crazywalls_deaths_team")]
        public int CrazywallsDeathsTeam { get; private set; }

        [JsonProperty("crazywalls_losses_team")]
        public int CrazywallsLossesTeam { get; private set; }

        [JsonProperty("crazywalls_games_team")]
        public int CrazywallsGamesTeam { get; private set; }

        [JsonProperty("crazywalls_kills_solo")]
        public int CrazywallsKillsSolo { get; private set; }

        [JsonProperty("crazywalls_kills_team")]
        public int CrazywallsKillsTeam { get; private set; }

        [JsonProperty("crazywalls_wins_team")]
        public int CrazywallsWinsTeam { get; private set; }

        #endregion

        #region upgrades		
        [JsonProperty("team_blazing_arrow")]
        public int TeamBlazingArrowLevel { get; private set; }

        [JsonProperty("solo_chaos_tomb_robber")]
        public int SoloChaosTombRobberLevel { get; private set; }

        [JsonProperty("solo_chaos_rusher")]
        public int SoloChaosRusherLevel { get; private set; }

        [JsonProperty("team_bounty_hunter")]
        public int TeamBountyHunterLevel { get; private set; }

        [JsonProperty("team_swiftness")]
        public int TeamSwiftnessLevel { get; private set; }

        [JsonProperty("team_adrenaline")]
        public int TeamAdrenalineLevel { get; private set; }

        [JsonProperty("solo_berserk")]
        public int SoloBerserkLevel { get; private set; }

        [JsonProperty("team_vampirism")]
        public int TeamVampirismLevel { get; private set; }

        [JsonProperty("solo_vampirism")]
        public int SoloVampirismLevel { get; private set; }

        [JsonProperty("solo_chaos_berserk")]
        public int SoloChaosBerserkLevel { get; private set; }

        [JsonProperty("solo_chaos_super_luck")]
        public int SoloChaosSuperLuckLevel { get; private set; }

        [JsonProperty("solo_precision")]
        public int SoloPrecisionLevel { get; private set; }

        [JsonProperty("team_precision")]
        public int TeamPrecisionLevel { get; private set; }

        [JsonProperty("solo_chaos_blazing_arrow")]
        public int SoloChaosBlazingArrowLevel { get; private set; }

        [JsonProperty("solo_chaos_adrenaline")]
        public int SoloChaosAdrenalineLevel { get; private set; }

        [JsonProperty("solo_rusher")]
        public int SoloRusherLevel { get; private set; }

        [JsonProperty("solo_swiftness")]
        public int SoloSwiftnessLevel { get; private set; }

        [JsonProperty("solo_blazing_arrow")]
        public int SoloBlazingArrowLevel { get; private set; }

        [JsonProperty("team_rusher")]
        public int TeamRusherLevel { get; private set; }

        [JsonProperty("team_berserk")]
        public int TeamBerserkLevel { get; private set; }

        [JsonProperty("team_smart_mining")]
        public int TeamSmartMiningLevel { get; private set; }

        [JsonProperty("team_last_stand")]
        public int TeamLastStandLevel { get; private set; }

        [JsonProperty("solo_adrenaline")]
        public int SoloAdrenalineLevel { get; private set; }

        [JsonProperty("solo_speed_mining")]
        public int SoloSpeedMiningLevel { get; private set; }

        [JsonProperty("solo_bounty_hunter")]
        public int SoloBountyHunterLevel { get; private set; }

        [JsonProperty("solo_lucky_drops")]
        public int SoloLuckyDropsLevel { get; private set; }

        [JsonProperty("solo_chaos_vampirism")]
        public int SoloChaosVampirismLevel { get; private set; }

        [JsonProperty("team_tomb_robber")]
        public int TeamTombRobberLevel { get; private set; }

        [JsonProperty("crafting_lucky_gold_ingots")]
        public int CraftingLuckyGoldIngotsLevel { get; private set; }

        [JsonProperty("crafting_lucky_enchanted_book_sharpness")]
        public int CraftingLuckyEnchantedBookSharpnessLevel { get; private set; }

        [JsonProperty("crafting_lucky_rejuvenate")]
        public int CraftingLuckyRejuvenateLevel { get; private set; }

        [JsonProperty("crafting_lucky_brawler")]
        public int CraftingLuckyBrawlerLevel { get; private set; }

        [JsonProperty("crafting_lucky_ender_pearls")]
        public int CraftingLuckyEnderPearlsLevel { get; private set; }

        [JsonProperty("solo_smart_mining")]
        public int SoloSmartMiningLevel { get; private set; }

        [JsonProperty("team_knowledge")]
        public int TeamKnowledgeLevel { get; private set; }

        [JsonProperty("solo_chaos_knowledge")]
        public int SoloChaosKnowledgeLevel { get; private set; }

        [JsonProperty("crafting_lucky_cobwebs")]
        public int CraftingLuckyCobwebsLevel { get; private set; }

        [JsonProperty("solo_chaos_businessman")]
        public int SoloChaosBusinessmanLevel { get; private set; }

        [JsonProperty("solo_chaos_bounty_hunter")]
        public int SoloChaosBountyHunterLevel { get; private set; }

        [JsonProperty("solo_chaos_annoy-o-mite")]
        public int SoloChaosAnnoyOMiteLevel { get; private set; }

        [JsonProperty("solo_knowledge")]
        public int SoloKnowledgeLevel { get; private set; }

        [JsonProperty("crafting_lucky_enchanted_book_power")]
        public int CraftingLuckyEnchantedBookPowerLevel { get; private set; }

        [JsonProperty("crafting_lucky_eagle_eye")]
        public int CraftingLuckyEagleEyeLevel { get; private set; }

        [JsonProperty("crafting_lucky_lava_bucket")]
        public int CraftingLuckyLavaBucketLevel { get; private set; }

        [JsonProperty("crafting_normal_enchanted_book_protection")]
        public int CraftingNormalEnchantedBookProtectionLevel { get; private set; }

        [JsonProperty("crafting_normal_enchanted_book_sharpness")]
        public int CraftingNormalEnchantedBookSharpnessLevel { get; private set; }

        [JsonProperty("crafting_normal_enchanted_book_power")]
        public int CraftingNormalEnchantedBookPowerLevel { get; private set; }

        [JsonProperty("crafting_normal_gold_ingots")]
        public int CraftingNormalGoldIngotsLevel { get; private set; }

        [JsonProperty("solo_tomb_robber")]
        public int SoloTombRobberLevel { get; private set; }

        [JsonProperty("crazywalls_wins_solo")]
        public int CrazywallsWinsSolo { get; private set; }

        [JsonProperty("crafting_normal_heal_potion")]
        public int CraftingNormalHealPotionLevel { get; private set; }

        [JsonProperty("team_annoy-o-mite")]
        public int TeamAnnoyOMiteLevel { get; private set; }

        [JsonProperty("crafting_normal_random_item")]
        public int CraftingNormalRandomItemLevel { get; private set; }

        [JsonProperty("crafting_normal_cobwebs")]
        public int CraftingNormalCobwebsLevel { get; private set; }

        [JsonProperty("crafting_normal_lava_bucket")]
        public int CraftingNormalLavaBucketLevel { get; private set; }

        [JsonProperty("crafting_normal_enchanted_book_punch")]
        public int CraftingNormalEnchantedBookPunchLevel { get; private set; }

        [JsonProperty("solo_annoy-o-mite")]
        public int SoloAnnoyOMiteLevel { get; private set; }

        [JsonProperty("team_speed_mining")]
        public int TeamSpeedMiningLevel { get; private set; }

        [JsonProperty("team_group_heal")]
        public int TeamGroupHealLevel { get; private set; }

        [JsonProperty("team_smarty_pants")]
        public int TeamSmartyPantsLevel { get; private set; }

        [JsonProperty("crafting_lucky_enchanted_book_punch")]
        public int CraftingLuckyEnchantedBookPunchLevel { get; private set; }

        [JsonProperty("solo_chaos_speed_mining")]
        public int SoloChaosSpeedMiningLevel { get; private set; }

        [JsonProperty("solo_chaos_smarty_pants")]
        public int SoloChaosSmartyPantsLevel { get; private set; }

        [JsonProperty("solo_smarty_pants")]
        public int SoloSmartyPantsLevel { get; private set; }

        [JsonProperty("solo_chaos_treasure_hunter")]
        public int SoloChaosTreasureHunterLevel { get; private set; }

        [JsonProperty("solo_scavenger")]
        public int SoloScavengerLevel { get; private set; }

        [JsonProperty("team_scavenger")]
        public int TeamScavengerLevel { get; private set; }
        #endregion

        #region kits
        [JsonProperty("kit_basic_chaos_looter")]
        public int KitBasicChaosLooter { get; private set; }

        [JsonProperty("kit_basic_chaos_gladiator")]
        public int KitBasicChaosGladiator { get; private set; }

        [JsonProperty("kit_basic_chaos_armorer")]
        public int KitBasicChaosArmorer { get; private set; }

        [JsonProperty("kit_basic_chaos_weaponsmith")]
        public int KitBasicChaosWeaponsmith { get; private set; }
        #endregion
    }
}