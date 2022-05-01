using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Bedwars
    {
        #region general
        [JsonProperty("Experience")]
        public int Experience { get; private set; }

        [JsonProperty("spray_glyph_field")]
        public string SprayGlyphField { get; private set; }

        [JsonProperty("activeDeathCry")]
        public string ActiveDeathCry { get; private set; }

        [JsonProperty("activeKillEffect")]
        public string ActiveKillEffect { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("activeVictoryDance")]
        public string ActiveVictoryDance { get; private set; }

        [JsonProperty("spray_storage_new")]
        public string SprayStorage { get; private set; }

        [JsonProperty("winstreak")]
        public int Winstreak { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("activeNPCSkin")]
        public string ActiveNpcSkin { get; private set; }

        [JsonProperty("activeIslandTopper")]
        public string ActiveIslandTopper { get; private set; }

        [JsonProperty("activeProjectileTrail")]
        public string ActiveProjectileTrail { get; private set; }

        [JsonProperty("glyph_storage_new")]
        public string GlyphStorage { get; private set; }

        [JsonProperty("activeSprays")]
        public string ActiveSprays { get; private set; }

        [JsonProperty("activeBedDestroy")]
        public string ActiveBedDestroySound { get; private set; }

        [JsonProperty("activeGlyph")]
        public string ActiveGlyph { get; private set; }
        #endregion

        #region loot boxes
        [JsonProperty("bedwars_boxes")]
        public int BedwarsBoxes { get; private set; }

        [JsonProperty("bedwars_box")]
        public int BedwarsBox { get; private set; }

        [JsonProperty("chest_history")]
        public string ChestHistory { get; private set; }

        [JsonProperty("bedwars_box_commons")]
        public int BedwarsBoxCommons { get; private set; }

        [JsonProperty("bedwars_box_rares")]
        public int BedwarsBoxRares { get; private set; }

        [JsonProperty("chest_history_new")]
        public List<string> ChestHistoryNew { get; private set; }

        [JsonProperty("bedwars_box_legendaries")]
        public int BedwarsBoxLegendaries { get; private set; }

        [JsonProperty("bedwars_box_epics")]
        public int BedwarsBoxEpics { get; private set; }

        [JsonProperty("Bedwars_openedChests")]
        public int BedwarsOpenedChests { get; private set; }

        [JsonProperty("Bedwars_openedCommons")]
        public int BedwarsOpenedCommons { get; private set; }

        [JsonProperty("Bedwars_openedRares")]
        public int BedwarsOpenedRares { get; private set; }

        [JsonProperty("Bedwars_openedEpics")]
        public int BedwarsOpenedEpics { get; private set; }

        [JsonProperty("Bedwars_openedLegendaries")]
        public int BedwarsOpenedLegendaries { get; private set; }

        [JsonProperty("bedwars_lunar_boxes")]
        public int BedwarsLunarBoxes { get; private set; }

        [JsonProperty("bedwars_easter_boxes")]
        public int BedwarsEasterBoxes { get; private set; }

        #endregion

        #region overall stats
        [JsonProperty("final_deaths_bedwars")]
        public int FinalDeathsBedwars { get; private set; }

        [JsonProperty("gold_resources_collected_bedwars")]
        public int GoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("emerald_resources_collected_bedwars")]
        public int EmeraldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("resources_collected_bedwars")]
        public int ResourcesCollectedBedwars { get; private set; }

        [JsonProperty("games_played_bedwars")]
        public int GamesPlayedBedwars { get; private set; }

        [JsonProperty("entity_attack_final_kills_bedwars")]
        public int EntityAttackFinalKillsBedwars { get; private set; }

        [JsonProperty("beds_lost_bedwars")]
        public int BedsLostBedwars { get; private set; }

        [JsonProperty("kills_bedwars")]
        public int KillsBedwars { get; private set; }

        [JsonProperty("entity_attack_kills_bedwars")]
        public int EntityAttackKillsBedwars { get; private set; }

        [JsonProperty("fall_final_deaths_bedwars")]
        public int FallFinalDeathsBedwars { get; private set; }

        [JsonProperty("losses_bedwars")]
        public int LossesBedwars { get; private set; }

        [JsonProperty("items_purchased_bedwars")]
        public int BedwarsItemsPurchasedBedwars { get; private set; }

        [JsonProperty("final_kills_bedwars")]
        public int FinalKillsBedwars { get; private set; }

        [JsonProperty("iron_resources_collected_bedwars")]
        public int IronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("beds_broken_bedwars")]
        public int BedsBrokenBedwars { get; private set; }

        [JsonProperty("_items_purchased_bedwars")]
        public int ItemsPurchasedBedwars { get; private set; }

        [JsonProperty("void_kills_bedwars")]
        public int VoidKillsBedwars { get; private set; }

        [JsonProperty("deaths_bedwars")]
        public int DeathsBedwars { get; private set; }

        [JsonProperty("fall_deaths_bedwars")]
        public int FallDeathsBedwars { get; private set; }

        [JsonProperty("permanent _items_purchased_bedwars")]
        public int PermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("wins_bedwars")]
        public int WinsBedwars { get; private set; }

        [JsonProperty("void_final_kills_bedwars")]
        public int VoidFinalKillsBedwars { get; private set; }

        [JsonProperty("entity_attack_deaths_bedwars")]
        public int EntityAttackDeathsBedwars { get; private set; }

        [JsonProperty("diamond_resources_collected_bedwars")]
        public int DiamondResourcesCollectedBedwars { get; private set; }

        [JsonProperty("entity_attack_final_deaths_bedwars")]
        public int EntityAttackFinalDeathsBedwars { get; private set; }

        [JsonProperty("void_deaths_bedwars")]
        public int VoidDeathsBedwars { get; private set; }

        [JsonProperty("entity_explosion_final_kills_bedwars")]
        public int EntityExplosionFinalKillsBedwars { get; private set; }

        [JsonProperty("entity_explosion_kills_bedwars")]
        public int EntityExplosionKillsBedwars { get; private set; }

        [JsonProperty("void_final_deaths_bedwars")]
        public int VoidFinalDeathsBedwars { get; private set; }

        [JsonProperty("fall_kills_bedwars")]
        public int FallKillsBedwars { get; private set; }

        [JsonProperty("fall_final_kills_bedwars")]
        public int FallFinalKillsBedwars { get; private set; }

        [JsonProperty("projectile_deaths_bedwars")]
        public int ProjectileDeathsBedwars { get; private set; }

        [JsonProperty("projectile_kills_bedwars")]
        public int ProjectileKillsBedwars { get; private set; }

        [JsonProperty("entity_explosion_deaths_bedwars")]
        public int EntityExplosionDeathsBedwars { get; private set; }

        [JsonProperty("projectile_final_kills_bedwars")]
        public int ProjectileFinalKillsBedwars { get; private set; }

        [JsonProperty("entity_explosion_final_deaths_bedwars")]
        public int EntityExplosionFinalDeathsBedwars { get; private set; }

        [JsonProperty("projectile_final_deaths_bedwars")]
        public int ProjectileFinalDeathsBedwars { get; private set; }

        [JsonProperty("fire_tick_deaths_bedwars")]
        public int FireTickDeathsBedwars { get; private set; }

        [JsonProperty("wrapped_present_resources_collected_bedwars")]
        public int WrappedPresentResourcesCollectedBedwars { get; private set; }

        [JsonProperty("fire_tick_kills_bedwars")]
        public int FireTickKillsBedwars { get; private set; }

        [JsonProperty("fire_kills_bedwars")]
        public int FireKillsBedwars { get; private set; }

        [JsonProperty("fire_tick_final_kills_bedwars")]
        public int FireTickFinalKillsBedwars { get; private set; }
        #endregion

        #region solos
        [JsonProperty("eight_one_beds_lost_bedwars")]
        public int SolosBedsLostBedwars { get; private set; }

        [JsonProperty("eight_one_entity_attack_final_kills_bedwars")]
        public int SolosEntityAttackFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_one_deaths_bedwars")]
        public int SolosDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_void_deaths_bedwars")]
        public int SolosVoidDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_games_played_bedwars")]
        public int SolosGamesPlayedBedwars { get; private set; }

        [JsonProperty("eight_one_final_kills_bedwars")]
        public int SolosFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_one_beds_broken_bedwars")]
        public int SolosBedsBrokenBedwars { get; private set; }

        [JsonProperty("eight_one_iron_resources_collected_bedwars")]
        public int SolosIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_emerald_resources_collected_bedwars")]
        public int SolosEmeraldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_items_purchased_bedwars")]
        public int SolosItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_one_diamond_resources_collected_bedwars")]
        public int SolosDiamondResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_permanent _items_purchased_bedwars")]
        public int SolosPermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_one_entity_attack_kills_bedwars")]
        public int SolosEntityAttackKillsBedwars { get; private set; }

        [JsonProperty("eight_one_void_final_kills_bedwars")]
        public int SolosVoidFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_one_wins_bedwars")]
        public int SolosWinsBedwars { get; private set; }

        [JsonProperty("eight_one_kills_bedwars")]
        public int SolosKillsBedwars { get; private set; }

        [JsonProperty("eight_one_resources_collected_bedwars")]
        public int SolosResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_gold_resources_collected_bedwars")]
        public int SolosGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_final_deaths_bedwars")]
        public int SolosFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_entity_attack_final_deaths_bedwars")]
        public int SolosEntityAttackFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_losses_bedwars")]
        public int SolosLossesBedwars { get; private set; }

        [JsonProperty("eight_one_fall_kills_bedwars")]
        public int SolosFallKillsBedwars { get; private set; }

        [JsonProperty("eight_one_projectile_kills_bedwars")]
        public int SolosProjectileKillsBedwars { get; private set; }

        [JsonProperty("eight_one_void_kills_bedwars")]
        public int SolosVoidKillsBedwars { get; private set; }

        [JsonProperty("eight_one_void_final_deaths_bedwars")]
        public int SolosVoidFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_entity_attack_deaths_bedwars")]
        public int SolosEntityAttackDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_fall_final_kills_bedwars")]
        public int SolosFallFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_one_fall_deaths_bedwars")]
        public int SolosFallDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_projectile_final_kills_bedwars")]
        public int SolosProjectileFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_one_entity_explosion_kills_bedwars")]
        public int SolosEntityExplosionKillsBedwars { get; private set; }

        [JsonProperty("eight_one_projectile_deaths_bedwars")]
        public int SolosProjectileDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_winstreak")]
        public int SolosWinstreak { get; private set; }
        #endregion

        #region duos
        [JsonProperty("eight_two_void_deaths_bedwars")]
        public int DuosVoidDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_beds_broken_bedwars")]
        public int DuosBedsBrokenBedwars { get; private set; }

        [JsonProperty("eight_two_emerald_resources_collected_bedwars")]
        public int DuosEmeraldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_permanent _items_purchased_bedwars")]
        public int DuosPermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_two_resources_collected_bedwars")]
        public int DuosResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_diamond_resources_collected_bedwars")]
        public int DuosDiamondResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_fall_deaths_bedwars")]
        public int DuosFallDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_kills_bedwars")]
        public int DuosKillsBedwars { get; private set; }

        [JsonProperty("eight_two_entity_attack_final_kills_bedwars")]
        public int DuosEntityAttackFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_entity_attack_kills_bedwars")]
        public int DuosEntityAttackKillsBedwars { get; private set; }

        [JsonProperty("eight_two_iron_resources_collected_bedwars")]
        public int DuosIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_final_deaths_bedwars")]
        public int DuosFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_void_final_deaths_bedwars")]
        public int DuosVoidFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_deaths_bedwars")]
        public int DuosDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_games_played_bedwars")]
        public int DuosGamesPlayedBedwars { get; private set; }

        [JsonProperty("eight_two_items_purchased_bedwars")]
        public int DuosItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_two_beds_lost_bedwars")]
        public int DuosBedsLostBedwars { get; private set; }

        [JsonProperty("eight_two_entity_attack_deaths_bedwars")]
        public int DuosEntityAttackDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_void_final_kills_bedwars")]
        public int DuosVoidFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_gold_resources_collected_bedwars")]
        public int DuosGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_final_kills_bedwars")]
        public int DuosFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_losses_bedwars")]
        public int DuosLossesBedwars { get; private set; }

        [JsonProperty("eight_two_fall_final_kills_bedwars")]
        public int DuosFallFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_wins_bedwars")]
        public int DuosWinsBedwars { get; private set; }

        [JsonProperty("eight_two_fall_kills_bedwars")]
        public int DuosFallKillsBedwars { get; private set; }

        [JsonProperty("eight_two_void_kills_bedwars")]
        public int DuosVoidKillsBedwars { get; private set; }

        [JsonProperty("eight_two_entity_attack_final_deaths_bedwars")]
        public int DuosEntityAttackFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_fall_final_deaths_bedwars")]
        public int DuosFallFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_projectile_final_kills_bedwars")]
        public int DuosProjectileFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_entity_explosion_final_kills_bedwars")]
        public int DuosEntityExplosionFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_projectile_kills_bedwars")]
        public int DuosProjectileKillsBedwars { get; private set; }

        [JsonProperty("eight_two_projectile_deaths_bedwars")]
        public int DuosProjectileDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_winstreak")]
        public int DuosWinstreak { get; private set; }

        [JsonProperty("eight_two_fire_kills_bedwars")]
        public int DuosFireKillsBedwars { get; private set; }
        #endregion

        #region trios
        [JsonProperty("four_three_iron_resources_collected_bedwars")]
        public int TriosIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_three_entity_attack_final_deaths_bedwars")]
        public int TriosEntityAttackFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_three_games_played_bedwars")]
        public int TriosGamesPlayedBedwars { get; private set; }

        [JsonProperty("four_three_fall_deaths_bedwars")]
        public int TriosFallDeathsBedwars { get; private set; }

        [JsonProperty("four_three_emerald_resources_collected_bedwars")]
        public int TriosEmeraldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_three_beds_lost_bedwars")]
        public int TriosBedsLostBedwars { get; private set; }

        [JsonProperty("four_three_gold_resources_collected_bedwars")]
        public int TriosGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_three_deaths_bedwars")]
        public int TriosDeathsBedwars { get; private set; }

        [JsonProperty("four_three_beds_broken_bedwars")]
        public int TriosBedsBrokenBedwars { get; private set; }

        [JsonProperty("four_three_losses_bedwars")]
        public int TriosLossesBedwars { get; private set; }

        [JsonProperty("four_three_items_purchased_bedwars")]
        public int TriosItemsPurchasedBedwars { get; private set; }

        [JsonProperty("four_three_final_deaths_bedwars")]
        public int TriosFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_three_resources_collected_bedwars")]
        public int TriosResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_three_void_final_kills_bedwars")]
        public int TriosVoidFinalKillsBedwars { get; private set; }

        [JsonProperty("four_three_wins_bedwars")]
        public int TriosWinsBedwars { get; private set; }

        [JsonProperty("four_three_entity_explosion_final_kills_bedwars")]
        public int TriosEntityExplosionFinalKillsBedwars { get; private set; }

        [JsonProperty("four_three_void_deaths_bedwars")]
        public int TriosVoidDeathsBedwars { get; private set; }

        [JsonProperty("four_three_entity_attack_deaths_bedwars")]
        public int TriosEntityAttackDeathsBedwars { get; private set; }

        [JsonProperty("four_three_permanent _items_purchased_bedwars")]
        public int TriosPermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("four_three_entity_attack_final_kills_bedwars")]
        public int TriosEntityAttackFinalKillsBedwars { get; private set; }

        [JsonProperty("four_three_final_kills_bedwars")]
        public int TriosFinalKillsBedwars { get; private set; }

        [JsonProperty("four_three_diamond_resources_collected_bedwars")]
        public int TriosDiamondResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_three_void_kills_bedwars")]
        public int TriosVoidKillsBedwars { get; private set; }

        [JsonProperty("four_three_fall_final_kills_bedwars")]
        public int TriosFallFinalKillsBedwars { get; private set; }

        [JsonProperty("four_three_kills_bedwars")]
        public int TriosKillsBedwars { get; private set; }

        [JsonProperty("four_three_entity_attack_kills_bedwars")]
        public int TriosEntityAttackKillsBedwars { get; private set; }

        [JsonProperty("four_three_entity_explosion_kills_bedwars")]
        public int TriosEntityExplosionKillsBedwars { get; private set; }

        [JsonProperty("four_three_void_final_deaths_bedwars")]
        public int TriosVoidFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_three_entity_explosion_deaths_bedwars")]
        public int TriosEntityExplosionDeathsBedwars { get; private set; }

        [JsonProperty("four_three_projectile_kills_bedwars")]
        public int TriosProjectileKillsBedwars { get; private set; }

        [JsonProperty("four_three_fall_kills_bedwars")]
        public int TriosFallKillsBedwars { get; private set; }

        [JsonProperty("four_three_entity_explosion_final_deaths_bedwars")]
        public int TriosEntityExplosionFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_three_fall_final_deaths_bedwars")]
        public int TriosFallFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_three_projectile_final_kills_bedwars")]
        public int TriosProjectileFinalKillsBedwars { get; private set; }

        [JsonProperty("four_three_wrapped_present_resources_collected_bedwars")]
        public int TriosWrappedPresentResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_three_fire_tick_deaths_bedwars")]
        public int TriosFireTickDeathsBedwars { get; private set; }

        [JsonProperty("four_three_winstreak")]
        public int TriosWinstreak { get; private set; }

        #endregion

        #region fours
        [JsonProperty("four_four_beds_broken_bedwars")]
        public int FoursBedsBrokenBedwars { get; private set; }

        [JsonProperty("four_four_kills_bedwars")]
        public int FoursKillsBedwars { get; private set; }

        [JsonProperty("four_four_final_deaths_bedwars")]
        public int FoursFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_four_gold_resources_collected_bedwars")]
        public int FoursGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_beds_lost_bedwars")]
        public int FoursBedsLostBedwars { get; private set; }

        [JsonProperty("four_four_losses_bedwars")]
        public int FoursLossesBedwars { get; private set; }

        [JsonProperty("four_four_iron_resources_collected_bedwars")]
        public int FoursIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_fall_final_deaths_bedwars")]
        public int FoursFallFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_four_resources_collected_bedwars")]
        public int FoursResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_items_purchased_bedwars")]
        public int FoursItemsPurchasedBedwars { get; private set; }

        [JsonProperty("four_four_entity_attack_kills_bedwars")]
        public int FoursEntityAttackKillsBedwars { get; private set; }

        [JsonProperty("four_four_final_kills_bedwars")]
        public int FoursFinalKillsBedwars { get; private set; }

        [JsonProperty("four_four_emerald_resources_collected_bedwars")]
        public int FoursEmeraldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_permanent _items_purchased_bedwars")]
        public int FoursPermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("four_four_void_kills_bedwars")]
        public int FoursVoidKillsBedwars { get; private set; }

        [JsonProperty("four_four_fall_deaths_bedwars")]
        public int FoursFallDeathsBedwars { get; private set; }

        [JsonProperty("four_four_deaths_bedwars")]
        public int FoursDeathsBedwars { get; private set; }

        [JsonProperty("four_four_wins_bedwars")]
        public int FoursWinsBedwars { get; private set; }

        [JsonProperty("four_four_void_final_kills_bedwars")]
        public int FoursVoidFinalKillsBedwars { get; private set; }

        [JsonProperty("four_four_entity_attack_deaths_bedwars")]
        public int FoursEntityAttackDeathsBedwars { get; private set; }

        [JsonProperty("four_four_diamond_resources_collected_bedwars")]
        public int FoursDiamondResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_entity_explosion_kills_bedwars")]
        public int FoursEntityExplosionKillsBedwars { get; private set; }

        [JsonProperty("four_four_void_deaths_bedwars")]
        public int FoursVoidDeathsBedwars { get; private set; }

        [JsonProperty("four_four_void_final_deaths_bedwars")]
        public int FoursVoidFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_four_fall_kills_bedwars")]
        public int FoursFallKillsBedwars { get; private set; }

        [JsonProperty("four_four_fall_final_kills_bedwars")]
        public int FoursFallFinalKillsBedwars { get; private set; }

        [JsonProperty("four_four_projectile_deaths_bedwars")]
        public int FoursProjectileDeathsBedwars { get; private set; }

        [JsonProperty("four_four_entity_attack_final_deaths_bedwars")]
        public int FoursEntityAttackFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_four_entity_explosion_final_kills_bedwars")]
        public int FoursEntityExplosionFinalKillsBedwars { get; private set; }

        [JsonProperty("four_four_entity_explosion_deaths_bedwars")]
        public int FoursEntityExplosionDeathsBedwars { get; private set; }

        [JsonProperty("four_four_entity_explosion_final_deaths_bedwars")]
        public int FoursEntityExplosionFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_four_projectile_kills_bedwars")]
        public int FoursProjectileKillsBedwars { get; private set; }

        [JsonProperty("four_four_projectile_final_kills_bedwars")]
        public int FoursProjectileFinalKillsBedwars { get; private set; }

        [JsonProperty("four_four_projectile_final_deaths_bedwars")]
        public int FoursProjectileFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_four_fire_tick_deaths_bedwars")]
        public int FoursFireTickDeathsBedwars { get; private set; }

        [JsonProperty("four_four_wrapped_present_resources_collected_bedwars")]
        public int FoursWrappedPresentResourcesCollected { get; private set; }

        [JsonProperty("four_four_winstreak")]
        public int FoursWinstreak { get; private set; }

        [JsonProperty("four_four_fire_tick_kills_bedwars")]
        public int FoursFireTickKillsBedwars { get; private set; }

        [JsonProperty("four_four_fire_tick_final_kills_bedwars")]
        public int FoursFireTickFinalKillsBedwars { get; private set; }
        #endregion

        #region castle bedwars mode
        [JsonProperty("castle_winstreak")]
        public int CastleWinstreak { get; private set; }

        [JsonProperty("castle_beds_lost_bedwars")]
        public int CastleBedsLostBedwars { get; private set; }

        [JsonProperty("castle_permanent _items_purchased_bedwars")]
        public int CastlePermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("castle_deaths_bedwars")]
        public int CastleDeathsBedwars { get; private set; }

        [JsonProperty("castle_beds_broken_bedwars")]
        public int CastleBedsBrokenBedwars { get; private set; }

        [JsonProperty("castle_games_played_bedwars")]
        public int CastleGamesPlayedBedwars { get; private set; }

        [JsonProperty("castle_wins_bedwars")]
        public int CastleWinsBedwars { get; private set; }

        [JsonProperty("castle_fall_kills_bedwars")]
        public int CastleFallKillsBedwars { get; private set; }

        [JsonProperty("castle_entity_attack_kills_bedwars")]
        public int CastleEntityAttackKillsBedwars { get; private set; }

        [JsonProperty("castle_items_purchased_bedwars")]
        public int CastleItemsPurchasedBedwars { get; private set; }

        [JsonProperty("castle_diamond_resources_collected_bedwars")]
        public int CastleDiamondResourcesCollectedBedwars { get; private set; }

        [JsonProperty("castle_gold_resources_collected_bedwars")]
        public int CastleGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("castle_resources_collected_bedwars")]
        public int CastleResourcesCollectedBedwars { get; private set; }

        [JsonProperty("castle_void_deaths_bedwars")]
        public int CastleVoidDeathsBedwars { get; private set; }

        [JsonProperty("castle_iron_resources_collected_bedwars")]
        public int CastleIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("castle_void_kills_bedwars")]
        public int CastleVoidKillsBedwars { get; private set; }

        [JsonProperty("castle_kills_bedwars")]
        public int CastleKillsBedwars { get; private set; }

        [JsonProperty("castle_entity_attack_final_kills_bedwars")]
        public int CastleEntityAttackFinalKillsBedwars { get; private set; }

        [JsonProperty("castle_entity_attack_deaths_bedwars")]
        public int CastleEntityAttackDeathsBedwars { get; private set; }

        [JsonProperty("castle_emerald_resources_collected_bedwars")]
        public int CastleEmeraldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("castle_final_kills_bedwars")]
        public int CastleFinalKillsBedwars { get; private set; }

        [JsonProperty("castle_void_final_kills_bedwars")]
        public int CastleVoidFinalKillsBedwars { get; private set; }

        [JsonProperty("castle_entity_attack_final_deaths_bedwars")]
        public int CastleEntityAttackFinalDeathsBedwars { get; private set; }

        [JsonProperty("castle_final_deaths_bedwars")]
        public int CastleFinalDeathsBedwars { get; private set; }

        [JsonProperty("castle_entity_explosion_final_kills_bedwars")]
        public int CastleEntityExplosionFinalKillsBedwars { get; private set; }

        [JsonProperty("castle_fall_deaths_bedwars")]
        public int CastleFallDeathsBedwars { get; private set; }

        [JsonProperty("castle_void_final_deaths_bedwars")]
        public int CastleVoidFinalDeathsBedwars { get; private set; }

        [JsonProperty("castle_losses_bedwars")]
        public int CastleLossesBedwars { get; private set; }

        [JsonProperty("castle_entity_explosion_kills_bedwars")]
        public int CastleEntityExplosionKillsBedwars { get; private set; }

        [JsonProperty("castle_fall_final_kills_bedwars")]
        public int CastleFallFinalKillsBedwars { get; private set; }

        [JsonProperty("castle_projectile_deaths_bedwars")]
        public int CastleProjectileDeathsBedwars { get; private set; }

        [JsonProperty("castle_entity_explosion_deaths_bedwars")]
        public int CastleEntityExplosionDeathsBedwars { get; private set; }

        [JsonProperty("castle_suffocation_deaths_bedwars")]
        public int CastleSuffocationDeathsBedwars { get; private set; }

        [JsonProperty("castle_entity_explosion_final_deaths_bedwars")]
        public int CastleEntityExplosionFinalDeathsBedwars { get; private set; }

        [JsonProperty("castle_fall_final_deaths_bedwars")]
        public int CastleFallFinalDeathsBedwars { get; private set; }

        [JsonProperty("castle_projectile_final_kills_bedwars")]
        public int CastleProjectileFinalKillsBedwars { get; private set; }

        [JsonProperty("castle_projectile_kills_bedwars")]
        public int CastleProjectileKillsBedwars { get; private set; }

        [JsonProperty("castle_fire_tick_deaths_bedwars")]
        public int CastleFireTickDeathsBedwars { get; private set; }

        [JsonProperty("castle_projectile_final_deaths_bedwars")]
        public int CastleProjectileFinalDeathsBedwars { get; private set; }
        #endregion

        #region rush bedwars mode
        [JsonProperty("eight_one_rush_winstreak")]
        public int SolosRushWinstreak { get; private set; }

        [JsonProperty("eight_one_rush_kills_bedwars")]
        public int SolosRushKillsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_beds_broken_bedwars")]
        public int SolosRushBedsBrokenBedwars { get; private set; }

        [JsonProperty("eight_one_rush_items_purchased_bedwars")]
        public int SolosRushItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_one_rush_games_played_bedwars")]
        public int SolosRushGamesPlayedBedwars { get; private set; }

        [JsonProperty("eight_one_rush_deaths_bedwars")]
        public int SolosRushDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_entity_attack_final_kills_bedwars")]
        public int SolosRushEntityAttackFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_emerald_resources_collected_bedwars")]
        public int SolosRushEmeraldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_rush_void_final_kills_bedwars")]
        public int SolosRushVoidFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_entity_attack_deaths_bedwars")]
        public int SolosRushEntityAttackDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_final_kills_bedwars")]
        public int SolosRushFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_gold_resources_collected_bedwars")]
        public int SolosRushGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_rush_resources_collected_bedwars")]
        public int SolosRushResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_rush_void_kills_bedwars")]
        public int SolosRushVoidKillsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_diamond_resources_collected_bedwars")]
        public int SolosRushDiamondResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_rush_entity_attack_kills_bedwars")]
        public int SolosRushEntityAttackKillsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_wins_bedwars")]
        public int SolosRushWinsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_permanent _items_purchased_bedwars")]
        public int SolosRushPermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_one_rush_iron_resources_collected_bedwars")]
        public int SolosRushIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_one_rush_void_deaths_bedwars")]
        public int SolosRushVoidDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_fall_final_deaths_bedwars")]
        public int SolosRushFallFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_losses_bedwars")]
        public int SolosRushLossesBedwars { get; private set; }

        [JsonProperty("eight_one_rush_beds_lost_bedwars")]
        public int SolosRushBedsLostBedwars { get; private set; }

        [JsonProperty("eight_one_rush_final_deaths_bedwars")]
        public int SolosRushFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_entity_attack_final_deaths_bedwars")]
        public int SolosRushEntityAttackFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_one_rush_entity_explosion_final_kills_bedwars")]
        public int SolosRushEntityExplosionFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_winstreak")]
        public int DuosRushWinstreak { get; private set; }

        [JsonProperty("eight_two_rush_kills_bedwars")]
        public int DuosRushKillsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_beds_broken_bedwars")]
        public int DuosRushBedsBrokenBedwars { get; private set; }

        [JsonProperty("eight_two_rush_items_purchased_bedwars")]
        public int DuosRushItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_two_rush_games_played_bedwars")]
        public int DuosRushGamesPlayedBedwars { get; private set; }

        [JsonProperty("eight_two_rush_deaths_bedwars")]
        public int DuosRushDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_entity_attack_final_kills_bedwars")]
        public int DuosRushEntityAttackFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_emerald_resources_collected_bedwars")]
        public int DuosRushEmeraldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_rush_void_final_kills_bedwars")]
        public int DuosRushVoidFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_entity_attack_deaths_bedwars")]
        public int DuosRushEntityAttackDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_final_kills_bedwars")]
        public int DuosRushFinalKillsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_gold_resources_collected_bedwars")]
        public int DuosRushGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_rush_resources_collected_bedwars")]
        public int DuosRushResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_rush_void_kills_bedwars")]
        public int DuosRushVoidKillsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_diamond_resources_collected_bedwars")]
        public int DuosRushDiamondResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_rush_entity_attack_kills_bedwars")]
        public int DuosRushEntityAttackKillsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_wins_bedwars")]
        public int DuosRushWinsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_permanent _items_purchased_bedwars")]
        public int DuosRushPermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_two_rush_iron_resources_collected_bedwars")]
        public int DuosRushIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_rush_void_deaths_bedwars")]
        public int DuosRushVoidDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_fall_final_deaths_bedwars")]
        public int DuosRushFallFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_losses_bedwars")]
        public int DuosRushLossesBedwars { get; private set; }

        [JsonProperty("eight_two_rush_beds_lost_bedwars")]
        public int DuosRushBedsLostBedwars { get; private set; }

        [JsonProperty("eight_two_rush_final_deaths_bedwars")]
        public int DuosRushFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_entity_attack_final_deaths_bedwars")]
        public int DuosRushEntityAttackFinalDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_rush_entity_explosion_final_kills_bedwars")]
        public int DuosRushEntityExplosionFinalKillsBedwars { get; private set; }

        [JsonProperty("four_four_rush_winstreak")]
        public int FoursRushWinstreak { get; private set; }

        [JsonProperty("four_four_rush_kills_bedwars")]
        public int FoursRushKillsBedwars { get; private set; }

        [JsonProperty("four_four_rush_beds_broken_bedwars")]
        public int FoursRushBedsBrokenBedwars { get; private set; }

        [JsonProperty("four_four_rush_items_purchased_bedwars")]
        public int FoursRushItemsPurchasedBedwars { get; private set; }

        [JsonProperty("four_four_rush_games_played_bedwars")]
        public int FoursRushGamesPlayedBedwars { get; private set; }

        [JsonProperty("four_four_rush_deaths_bedwars")]
        public int FoursRushDeathsBedwars { get; private set; }

        [JsonProperty("four_four_rush_entity_attack_final_kills_bedwars")]
        public int FoursRushEntityAttackFinalKillsBedwars { get; private set; }

        [JsonProperty("four_four_rush_emerald_resources_collected_bedwars")]
        public int FoursRushEmeraldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_rush_void_final_kills_bedwars")]
        public int FoursRushVoidFinalKillsBedwars { get; private set; }

        [JsonProperty("four_four_rush_entity_attack_deaths_bedwars")]
        public int FoursRushEntityAttackDeathsBedwars { get; private set; }

        [JsonProperty("four_four_rush_final_kills_bedwars")]
        public int FoursRushFinalKillsBedwars { get; private set; }

        [JsonProperty("four_four_rush_gold_resources_collected_bedwars")]
        public int FoursRushGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_rush_resources_collected_bedwars")]
        public int FoursRushResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_rush_void_kills_bedwars")]
        public int FoursRushVoidKillsBedwars { get; private set; }

        [JsonProperty("four_four_rush_diamond_resources_collected_bedwars")]
        public int FoursRushDiamondResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_rush_entity_attack_kills_bedwars")]
        public int FoursRushEntityAttackKillsBedwars { get; private set; }

        [JsonProperty("four_four_rush_wins_bedwars")]
        public int FoursRushWinsBedwars { get; private set; }

        [JsonProperty("four_four_rush_permanent _items_purchased_bedwars")]
        public int FoursRushPermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("four_four_rush_iron_resources_collected_bedwars")]
        public int FoursRushIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_rush_void_deaths_bedwars")]
        public int FoursRushVoidDeathsBedwars { get; private set; }

        [JsonProperty("four_four_rush_fall_final_deaths_bedwars")]
        public int FoursRushFallFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_four_rush_losses_bedwars")]
        public int FoursRushLossesBedwars { get; private set; }

        [JsonProperty("four_four_rush_beds_lost_bedwars")]
        public int FoursRushBedsLostBedwars { get; private set; }

        [JsonProperty("four_four_rush_final_deaths_bedwars")]
        public int FoursRushFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_four_rush_entity_attack_final_deaths_bedwars")]
        public int FoursRushEntityAttackFinalDeathsBedwars { get; private set; }

        [JsonProperty("four_four_rush_entity_explosion_final_kills_bedwars")]
        public int FoursRushEntityExplosionFinalKillsBedwars { get; private set; }
        #endregion

        #region lucky bedwars mode
        [JsonProperty("eight_two_lucky_winstreak")]
        public int DuosLuckyWinstreak { get; private set; }

        [JsonProperty("eight_two_lucky_void_deaths_bedwars")]
        public int DuosLuckyVoidDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_lucky_permanent _items_purchased_bedwars")]
        public int DuosLuckyPermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_two_lucky_items_purchased_bedwars")]
        public int DuosLuckyItemsPurchasedBedwars { get; private set; }

        [JsonProperty("eight_two_lucky_games_played_bedwars")]
        public int DuosLuckyGamesPlayedBedwars { get; private set; }

        [JsonProperty("eight_two_lucky_beds_broken_bedwars")]
        public int DuosLuckyBedsBrokenBedwars { get; private set; }

        [JsonProperty("eight_two_lucky_resources_collected_bedwars")]
        public int DuosLuckyResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_lucky_deaths_bedwars")]
        public int DuosLuckyDeathsBedwars { get; private set; }

        [JsonProperty("eight_two_lucky_iron_resources_collected_bedwars")]
        public int DuosLuckyIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_lucky_gold_resources_collected_bedwars")]
        public int DuosLuckyGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("eight_two_lucky_wins_bedwars")]
        public int DuosLuckyWinsBedwars { get; private set; }

        [JsonProperty("four_four_lucky_winstreak")]
        public int FoursLuckyWinstreak { get; private set; }

        [JsonProperty("four_four_lucky_void_deaths_bedwars")]
        public int FoursLuckyVoidDeathsBedwars { get; private set; }

        [JsonProperty("four_four_lucky_permanent _items_purchased_bedwars")]
        public int FoursLuckyPermanentItemsPurchasedBedwars { get; private set; }

        [JsonProperty("four_four_lucky_items_purchased_bedwars")]
        public int FoursLuckyItemsPurchasedBedwars { get; private set; }

        [JsonProperty("four_four_lucky_games_played_bedwars")]
        public int FoursLuckyGamesPlayedBedwars { get; private set; }

        [JsonProperty("four_four_lucky_beds_broken_bedwars")]
        public int FoursLuckyBedsBrokenBedwars { get; private set; }

        [JsonProperty("four_four_lucky_resources_collected_bedwars")]
        public int FoursLuckyResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_lucky_deaths_bedwars")]
        public int FoursLuckyDeathsBedwars { get; private set; }

        [JsonProperty("four_four_lucky_iron_resources_collected_bedwars")]
        public int FoursLuckyIronResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_lucky_gold_resources_collected_bedwars")]
        public int FoursLuckyGoldResourcesCollectedBedwars { get; private set; }

        [JsonProperty("four_four_lucky_wins_bedwars")]
        public int FoursLuckyWinsBedwars { get; private set; }
        #endregion

        #region Bedwars tourney Dec 2019
        [JsonProperty("tourney_bedwars_two_four_0_winstreak2")]
        public int TourneyDec2019WinStreak { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0__items_purchased_bedwars")]
        public int TourneyDec2019itemsPurchased { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_deaths_bedwars")]
        public int TourneyDec2019Deaths { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_entity_attack_deaths_bedwars")]
        public int TourneyDec2019EntityAttackDeaths { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_entity_attack_final_kills_bedwars")]
        public int TourneyDec2019EntityAttackFinalKills { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_fall_deaths_bedwars")]
        public int TourneyDec2019FallDeaths { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_fall_kills_bedwars")]
        public int TourneyDec2019FallKills { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_final_kills_bedwars")]
        public int TourneyDec2019FinalKills { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_games_played_bedwars")]
        public int TourneyDec2019GamesPlayed { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_gold_resources_collected_bedwars")]
        public int TourneyDec2019GoldCollected { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_iron_resources_collected_bedwars")]
        public int TourneyDec2019IronCollected { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_items_purchased_bedwars")]
        public int TourneyDec2019IOtemsPurchased { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_kills_bedwars")]
        public int TourneyDec2019Kills { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_resources_collected_bedwars")]
        public int TourneyDec2019ResourcesCollected { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_wins_bedwars")]
        public int TourneyDec2019Wins { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_void_deaths_bedwars")]
        public int TourneyDec2019VoidDeaths { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_void_kills_bedwars")]
        public int TourneyDec2019VoidKills { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_beds_broken_bedwars")]
        public int TourneyDec2019BedsBroken { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_entity_explosion_deaths_bedwars")]
        public int TourneyDec2019EntityExplosionDeaths { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_void_final_kills_bedwars")]
        public int TourneyDec2019VoidFinalKills { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_projectile_deaths_bedwars")]
        public int TourneyDec2019ProjectileDeaths { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_emerald_resources_collected_bedwars")]
        public int TourneyDec2019EmeraldsCollected { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_entity_explosion_kills_bedwars")]
        public int TourneyDec2019EntityExplosionKills { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_fall_final_kills_bedwars")]
        public int TourneyDec2019FallFinalKills { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_diamond_resources_collected_bedwars")]
        public int TourneyDec2019DiamondsCollected { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_beds_lost_bedwars")]
        public int TourneyDec2019BedsLost { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_entity_attack_final_deaths_bedwars")]
        public int TourneyDec2019EntityAttackFinalDeaths { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_final_deaths_bedwars")]
        public int TourneyDec2019FinalDeaths { get; set; }

        [JsonProperty("tourney_bedwars_two_four_0_losses_bedwars")]
        public int TourneyDec2019Losses { get; set; }
    #endregion
}
}