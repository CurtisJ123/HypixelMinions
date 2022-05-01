using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Walls3
    {
        #region general
        [JsonProperty("chosen_class")]
        public string ChosenClass { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }
        #endregion

        #region final kills
        [JsonProperty("finalKills")]
        public int FinalKills { get; private set; }

        [JsonProperty("finalKills_Arcanist")]
        public int FinalKillsArcanist { get; private set; }

        [JsonProperty("finalKills_Blaze")]
        public int FinalKillsBlaze { get; private set; }

        [JsonProperty("finalKills_Creeper")]
        public int FinalKillsCreeper { get; private set; }

        [JsonProperty("finalKills_Dreadlord")]
        public int FinalKillsDreadlord { get; private set; }

        [JsonProperty("finalKills_Enderman")]
        public int FinalKillsEnderman { get; private set; }

        [JsonProperty("finalKills_Golem")]
        public int FinalKillsGolem { get; private set; }

        [JsonProperty("finalKills_Herobrine")]
        public int FinalKillsHerobrine { get; private set; }

        [JsonProperty("finalKills_Pigman")]
        public int FinalKillsPigman { get; private set; }

        [JsonProperty("finalKills_Shaman")]
        public int FinalKillsShaman { get; private set; }

        [JsonProperty("finalKills_Skeleton")]
        public int FinalKillsSkeleton { get; private set; }

        [JsonProperty("finalKills_Spider")]
        public int FinalKillsSpider { get; private set; }

        [JsonProperty("finalKills_Zombie")]
        public int FinalKillsZombie { get; private set; }

        [JsonProperty("finalKills_Squid")]
        public int FinalKillsSquid { get; private set; }

        [JsonProperty("finalKills_Pirate")]
        public int FinalKillsPirate { get; private set; }

        [JsonProperty("hunter_final_kills")]
        public int HunterFinalKills { get; private set; }

        [JsonProperty("moleman_final_kills")]
        public int MolemanFinalKills { get; private set; }
        #endregion

        #region finalassists
        [JsonProperty("finalAssists")]
        public int FinalAssists { get; private set; }

        [JsonProperty("finalAssists_Dreadlord")]
        public int FinalAssistsDreadlord { get; private set; }

        [JsonProperty("finalAssists_Arcanist")]
        public int FinalAssistsArcanist { get; private set; }

        [JsonProperty("finalAssists_Spider")]
        public int FinalAssistsSpider { get; private set; }

        [JsonProperty("finalAssists_Enderman")]
        public int FinalAssistsEnderman { get; private set; }

        [JsonProperty("finalAssists_Herobrine")]
        public int FinalAssistsHerobrine { get; private set; }

        [JsonProperty("finalAssists_Creeper")]
        public int FinalAssistsCreeper { get; private set; }

        [JsonProperty("finalAssists_Skeleton")]
        public int FinalAssistsSkeleton { get; private set; }

        [JsonProperty("finalAssists_Shaman")]
        public int FinalAssistsShaman { get; private set; }

        [JsonProperty("finalAssists_Golem")]
        public int FinalAssistsGolem { get; private set; }

        [JsonProperty("finalAssists_Zombie")]
        public int FinalAssistsZombie { get; private set; }

        [JsonProperty("finalAssists_Blaze")]
        public int FinalAssistsBlaze { get; private set; }

        [JsonProperty("finalAssists_Pigman")]
        public int FinalAssistsPigman { get; private set; }

        [JsonProperty("finalAssists_Squid")]
        public int FinalAssistsSquid { get; private set; }

        [JsonProperty("finalAssists_Pirate")]
        public int FinalAssistsPirate { get; private set; }

        [JsonProperty("hunter_final_assists")]
        public int HunterFinalAssists { get; private set; }

        [JsonProperty("moleman_final_assists")]
        public int MolemanFinalAssists { get; private set; }
        #endregion


        #region finaldeaths
        [JsonProperty("finalDeaths")]
        public int FinalDeaths { get; private set; }

        [JsonProperty("skeleton_final_deaths")]
        public int SkeletonFinalDeaths { get; private set; }

        [JsonProperty("zombie_final_deaths")]
        public int ZombieFinalDeaths { get; private set; }

        [JsonProperty("arcanist_final_deaths")]
        public int ArcanistFinalDeaths { get; private set; }

        [JsonProperty("enderman_final_deaths")]
        public int EndermanFinalDeaths { get; private set; }

        [JsonProperty("dreadlord_final_deaths")]
        public int DreadlordFinalDeaths { get; private set; }

        [JsonProperty("spider_final_deaths")]
        public int SpiderFinalDeaths { get; private set; }

        [JsonProperty("golem_final_deaths")]
        public int GolemFinalDeaths { get; private set; }

        [JsonProperty("blaze_final_deaths")]
        public int BlazeFinalDeaths { get; private set; }

        [JsonProperty("squid_final_deaths")]
        public int SquidFinalDeaths { get; private set; }

        [JsonProperty("shaman_final_deaths")]
        public int ShamanFinalDeaths { get; private set; }

        [JsonProperty("moleman_final_deaths")]
        public int MolemanFinalDeaths { get; private set; }

        [JsonProperty("pigman_final_deaths")]
        public int PigmanFinalDeaths { get; private set; }

        [JsonProperty("pirate_final_deaths")]
        public int PirateFinalDeaths { get; private set; }

        [JsonProperty("creeper_final_deaths")]
        public int CreeperFinalDeaths { get; private set; }

        [JsonProperty("hunter_final_deaths")]
        public int HunterFinalDeaths { get; private set; }

        [JsonProperty("herobrine_final_deaths")]
        public int HerobrineFinalDeaths { get; private set; }
        #endregion finaldeaths

        #region wins
        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("wins_Arcanist")]
        public int WinsArcanist { get; private set; }

        [JsonProperty("wins_Creeper")]
        public int WinsCreeper { get; private set; }

        [JsonProperty("wins_Dreadlord")]
        public int WinsDreadlord { get; private set; }

        [JsonProperty("wins_Enderman")]
        public int WinsEnderman { get; private set; }

        [JsonProperty("wins_Golem")]
        public int WinsGolem { get; private set; }

        [JsonProperty("wins_Herobrine")]
        public int WinsHerobrine { get; private set; }

        [JsonProperty("wins_Pigman")]
        public int WinsPigman { get; private set; }

        [JsonProperty("wins_Shaman")]
        public int WinsShaman { get; private set; }

        [JsonProperty("wins_Skeleton")]
        public int WinsSkeleton { get; private set; }

        [JsonProperty("wins_Spider")]
        public int WinsSpider { get; private set; }

        [JsonProperty("wins_Zombie")]
        public int WinsZombie { get; private set; }

        [JsonProperty("hunter_wins")]
        public int HunterWins { get; private set; }

        [JsonProperty("moleman_wins")]
        public int MolemanWins { get; private set; }
        #endregion

        #region kills
        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("kills_Arcanist")]
        public int KillsArcanist { get; private set; }

        [JsonProperty("kills_Blaze")]
        public int KillsBlaze { get; private set; }

        [JsonProperty("kills_Creeper")]
        public int KillsCreeper { get; private set; }

        [JsonProperty("kills_Dreadlord")]
        public int KillsDreadlord { get; private set; }

        [JsonProperty("kills_Enderman")]
        public int KillsEnderman { get; private set; }

        [JsonProperty("kills_Golem")]
        public int KillsGolem { get; private set; }

        [JsonProperty("kills_Herobrine")]
        public int KillsHerobrine { get; private set; }

        [JsonProperty("kills_Pigman")]
        public int KillsPigman { get; private set; }

        [JsonProperty("kills_Shaman")]
        public int KillsShaman { get; private set; }

        [JsonProperty("kills_Skeleton")]
        public int KillsSkeleton { get; private set; }

        [JsonProperty("kills_Spider")]
        public int KillsSpider { get; private set; }

        [JsonProperty("kills_Zombie")]
        public int KillsZombie { get; private set; }

        [JsonProperty("hunter_kills")]
        public int HunterKills { get; private set; }

        [JsonProperty("moleman_kills")]
        public int MolemanKills { get; private set; }
        #endregion


        #region deaths
        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("deaths_Arcanist")]
        public int DeathsArcanist { get; private set; }

        [JsonProperty("deaths_Blaze")]
        public int DeathsBlaze { get; private set; }

        [JsonProperty("deaths_Creeper")]
        public int DeathsCreeper { get; private set; }

        [JsonProperty("deaths_Dreadlord")]
        public int DeathsDreadlord { get; private set; }

        [JsonProperty("deaths_Enderman")]
        public int DeathsEnderman { get; private set; }

        [JsonProperty("deaths_Golem")]
        public int DeathsGolem { get; private set; }

        [JsonProperty("deaths_Herobrine")]
        public int DeathsHerobrine { get; private set; }

        [JsonProperty("deaths_Pigman")]
        public int DeathsPigman { get; private set; }

        [JsonProperty("deaths_Shaman")]
        public int DeathsShaman { get; private set; }

        [JsonProperty("deaths_Skeleton")]
        public int DeathsSkeleton { get; private set; }

        [JsonProperty("deaths_Spider")]
        public int DeathsSpider { get; private set; }

        [JsonProperty("deaths_Zombie")]
        public int DeathsZombie { get; private set; }

        [JsonProperty("hunter_deaths")]
        public int HunterDeaths { get; private set; }

        [JsonProperty("moleman_deaths")]
        public int MolemanDeaths { get; private set; }
        #endregion


        #region losses
        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("losses_Arcanist")]
        public int LossesArcanist { get; private set; }

        [JsonProperty("losses_Blaze")]
        public int LossesBlaze { get; private set; }

        [JsonProperty("losses_Creeper")]
        public int LossesCreeper { get; private set; }

        [JsonProperty("losses_Dreadlord")]
        public int LossesDreadlord { get; private set; }

        [JsonProperty("losses_Enderman")]
        public int LossesEnderman { get; private set; }

        [JsonProperty("losses_Golem")]
        public int LossesGolem { get; private set; }

        [JsonProperty("losses_Herobrine")]
        public int LossesHerobrine { get; private set; }

        [JsonProperty("losses_Pigman")]
        public int LossesPigman { get; private set; }

        [JsonProperty("losses_Shaman")]
        public int LossesShaman { get; private set; }

        [JsonProperty("losses_Skeleton")]
        public int LossesSkeleton { get; private set; }

        [JsonProperty("losses_Spider")]
        public int LossesSpider { get; private set; }

        [JsonProperty("losses_Zombie")]
        public int LossesZombie { get; private set; }

        [JsonProperty("hunter_lossess")]
        public int HunterLossess { get; private set; }

        [JsonProperty("moleman_losses")]
        public int MolemanLosses { get; private set; }
        #endregion

        #region assists
        [JsonProperty("assists_Dreadlord")]
        public int AssistsDreadlord { get; private set; }

        [JsonProperty("assists_Arcanist")]
        public int AssistsArcanist { get; private set; }

        [JsonProperty("assists_Spider")]
        public int AssistsSpider { get; private set; }

        [JsonProperty("assists_Enderman")]
        public int AssistsEnderman { get; private set; }

        [JsonProperty("assists_Herobrine")]
        public int AssistsHerobrine { get; private set; }

        [JsonProperty("assists_Creeper")]
        public int AssistsCreeper { get; private set; }

        [JsonProperty("assists_Skeleton")]
        public int AssistsSkeleton { get; private set; }

        [JsonProperty("assists_Shaman")]
        public int AssistsShaman { get; private set; }

        [JsonProperty("assists_Zombie")]
        public int AssistsZombie { get; private set; }

        [JsonProperty("assists_Golem")]
        public int AssistsGolem { get; private set; }

        [JsonProperty("assists_Blaze")]
        public int AssistsBlaze { get; private set; }

        [JsonProperty("assists_Pigman")]
        public int AssistsPigman { get; private set; }

        [JsonProperty("assists_Squid")]
        public int AssistsSquid { get; private set; }

        [JsonProperty("assists_Pirate")]
        public int AssistsPirate { get; private set; }

        [JsonProperty("hunter_assists")]
        public int HunterAssists { get; private set; }

        [JsonProperty("moleman_assists")]
        public int MolemanAssists { get; private set; }
        #endregion

        #region meters walked
        [JsonProperty("skeleton_meters_walked")]
        public int SkeletonMetersWalked { get; private set; }

        [JsonProperty("meters_walked")]
        public int MetersWalked { get; private set; }

        [JsonProperty("enderman_meters_walked")]
        public int EndermanMetersWalked { get; private set; }

        [JsonProperty("arcanist_meters_walked")]
        public int ArcanistMetersWalked { get; private set; }

        [JsonProperty("zombie_meters_walked")]
        public int ZombieMetersWalked { get; private set; }

        [JsonProperty("creeper_meters_walked")]
        public int CreeperMetersWalked { get; private set; }

        [JsonProperty("dreadlord_meters_walked")]
        public int DreadlordMetersWalked { get; private set; }

        [JsonProperty("golem_meters_walked")]
        public int GolemMetersWalked { get; private set; }

        [JsonProperty("spider_meters_walked")]
        public int SpiderMetersWalked { get; private set; }

        [JsonProperty("blaze_meters_walked")]
        public int BlazeMetersWalked { get; private set; }

        [JsonProperty("herobrine_meters_walked")]
        public int HerobrineMetersWalked { get; private set; }

        [JsonProperty("squid_meters_walked")]
        public int SquidMetersWalked { get; private set; }

        [JsonProperty("shaman_meters_walked")]
        public int ShamanMetersWalked { get; private set; }

        [JsonProperty("moleman_meters_walked")]
        public int MolemanMetersWalked { get; private set; }

        [JsonProperty("pigman_meters_walked")]
        public int PigmanMetersWalked { get; private set; }

        [JsonProperty("pirate_meters_walked")]
        public int PirateMetersWalked { get; private set; }

        [JsonProperty("hunter_meters_walked")]
        public int HunterMetersWalked { get; private set; }
        #endregion

        #region potions drunk
        [JsonProperty("potions_drunk")]
        public int PotionsDrunk { get; private set; }

        [JsonProperty("skeleton_potions_drunk")]
        public int SkeletonPotionsDrunk { get; private set; }

        [JsonProperty("arcanist_potions_drunk")]
        public int ArcanistPotionsDrunk { get; private set; }

        [JsonProperty("enderman_potions_drunk")]
        public int EndermanPotionsDrunk { get; private set; }

        [JsonProperty("zombie_potions_drunk")]
        public int ZombiePotionsDrunk { get; private set; }

        [JsonProperty("creeper_potions_drunk")]
        public int CreeperPotionsDrunk { get; private set; }

        [JsonProperty("dreadlord_potions_drunk")]
        public int DreadlordPotionsDrunk { get; private set; }

        [JsonProperty("golem_potions_drunk")]
        public int GolemPotionsDrunk { get; private set; }

        [JsonProperty("spider_potions_drunk")]
        public int SpiderPotionsDrunk { get; private set; }

        [JsonProperty("blaze_potions_drunk")]
        public int BlazePotionsDrunk { get; private set; }

        [JsonProperty("herobrine_potions_drunk")]
        public int HerobrinePotionsDrunk { get; private set; }

        [JsonProperty("squid_potions_drunk")]
        public int SquidPotionsDrunk { get; private set; }

        [JsonProperty("shaman_potions_drunk")]
        public int ShamanPotionsDrunk { get; private set; }

        [JsonProperty("pigman_potions_drunk")]
        public int PigmanPotionsDrunk { get; private set; }

        [JsonProperty("pirate_potions_drunk")]
        public int PiratePotionsDrunk { get; private set; }
        #endregion

        #region blocks broken
        [JsonProperty("blocks_broken")]
        public int BlocksBroken { get; private set; }

        [JsonProperty("skeleton_blocks_broken")]
        public int SkeletonBlocksBroken { get; private set; }

        [JsonProperty("arcanist_blocks_broken")]
        public int ArcanistBlocksBroken { get; private set; }

        [JsonProperty("enderman_blocks_broken")]
        public int EndermanBlocksBroken { get; private set; }

        [JsonProperty("zombie_blocks_broken")]
        public int ZombieBlocksBroken { get; private set; }

        [JsonProperty("creeper_blocks_broken")]
        public int CreeperBlocksBroken { get; private set; }

        [JsonProperty("dreadlord_blocks_broken")]
        public int DreadlordBlocksBroken { get; private set; }

        [JsonProperty("golem_blocks_broken")]
        public int GolemBlocksBroken { get; private set; }

        [JsonProperty("spider_blocks_broken")]
        public int SpiderBlocksBroken { get; private set; }

        [JsonProperty("blaze_blocks_broken")]
        public int BlazeBlocksBroken { get; private set; }

        [JsonProperty("herobrine_blocks_broken")]
        public int HerobrineBlocksBroken { get; private set; }

        [JsonProperty("squid_blocks_broken")]
        public int SquidBlocksBroken { get; private set; }

        [JsonProperty("shaman_blocks_broken")]
        public int ShamanBlocksBroken { get; private set; }

        [JsonProperty("moleman_blocks_broken")]
        public int MolemanBlocksBroken { get; private set; }

        [JsonProperty("pigman_blocks_broken")]
        public int PigmanBlocksBroken { get; private set; }

        [JsonProperty("pirate_blocks_broken")]
        public int PirateBlocksBroken { get; private set; }

        [JsonProperty("hunter_blocks_broken")]
        public int HunterBlocksBroken { get; private set; }
        #endregion

        #region blocks placed
        [JsonProperty("blocks_placed")]
        public int BlocksPlaced { get; private set; }

        [JsonProperty("skeleton_blocks_placed")]
        public int SkeletonBlocksPlaced { get; private set; }

        [JsonProperty("arcanist_blocks_placed")]
        public int ArcanistBlocksPlaced { get; private set; }

        [JsonProperty("enderman_blocks_placed")]
        public int EndermanBlocksPlaced { get; private set; }

        [JsonProperty("zombie_blocks_placed")]
        public int ZombieBlocksPlaced { get; private set; }

        [JsonProperty("creeper_blocks_placed")]
        public int CreeperBlocksPlaced { get; private set; }

        [JsonProperty("dreadlord_blocks_placed")]
        public int DreadlordBlocksPlaced { get; private set; }

        [JsonProperty("golem_blocks_placed")]
        public int GolemBlocksPlaced { get; private set; }

        [JsonProperty("spider_blocks_placed")]
        public int SpiderBlocksPlaced { get; private set; }

        [JsonProperty("blaze_blocks_placed")]
        public int BlazeBlocksPlaced { get; private set; }

        [JsonProperty("herobrine_blocks_placed")]
        public int HerobrineBlocksPlaced { get; private set; }

        [JsonProperty("squid_blocks_placed")]
        public int SquidBlocksPlaced { get; private set; }

        [JsonProperty("shaman_blocks_placed")]
        public int ShamanBlocksPlaced { get; private set; }

        [JsonProperty("moleman_blocks_placed")]
        public int MolemanBlocksPlaced { get; private set; }

        [JsonProperty("pigman_blocks_placed")]
        public int PigmanBlocksPlaced { get; private set; }

        [JsonProperty("pirate_blocks_placed")]
        public int PirateBlocksPlaced { get; private set; }

        [JsonProperty("hunter_blocks_placed")]
        public int HunterBlocksPlaced { get; private set; }
        #endregion

        #region arrows fired
        [JsonProperty("arrows_fired")]
        public int ArrowsFired { get; private set; }

        [JsonProperty("skeleton_arrows_fired")]
        public int SkeletonArrowsFired { get; private set; }

        [JsonProperty("arcanist_arrows_fired")]
        public int ArcanistArrowsFired { get; private set; }

        [JsonProperty("enderman_arrows_fired")]
        public int EndermanArrowsFired { get; private set; }

        [JsonProperty("zombie_arrows_fired")]
        public int ZombieArrowsFired { get; private set; }

        [JsonProperty("creeper_arrows_fired")]
        public int CreeperArrowsFired { get; private set; }

        [JsonProperty("dreadlord_arrows_fired")]
        public int DreadlordArrowsFired { get; private set; }

        [JsonProperty("golem_arrows_fired")]
        public int GolemArrowsFired { get; private set; }

        [JsonProperty("spider_arrows_fired")]
        public int SpiderArrowsFired { get; private set; }

        [JsonProperty("blaze_arrows_fired")]
        public int BlazeArrowsFired { get; private set; }

        [JsonProperty("herobrine_arrows_fired")]
        public int HerobrineArrowsFired { get; private set; }

        [JsonProperty("squid_arrows_fired")]
        public int SquidArrowsFired { get; private set; }

        [JsonProperty("moleman_arrows_fired")]
        public int MolemanArrowsFired { get; private set; }

        [JsonProperty("pigman_arrows_fired")]
        public int PigmanArrowsFired { get; private set; }

        [JsonProperty("hunter_arrows_fired")]
        public int HunterArrowsFired { get; private set; }
        #endregion

        #region arrows hit
        [JsonProperty("arrows_hit")]
        public int ArrowsHit { get; private set; }

        [JsonProperty("skeleton_arrows_hit")]
        public int SkeletonArrowsHit { get; private set; }

        [JsonProperty("arcanist_arrows_hit")]
        public int ArcanistArrowsHit { get; private set; }

        [JsonProperty("enderman_arrows_hit")]
        public int EndermanArrowsHit { get; private set; }

        [JsonProperty("zombie_arrows_hit")]
        public int ZombieArrowsHit { get; private set; }

        [JsonProperty("creeper_arrows_hit")]
        public int CreeperArrowsHit { get; private set; }

        [JsonProperty("dreadlord_arrows_hit")]
        public int DreadlordArrowsHit { get; private set; }

        [JsonProperty("golem_arrows_hit")]
        public int GolemArrowsHit { get; private set; }

        [JsonProperty("spider_arrows_hit")]
        public int SpiderArrowsHit { get; private set; }

        [JsonProperty("blaze_arrows_hit")]
        public int BlazeArrowsHit { get; private set; }

        [JsonProperty("herobrine_arrows_hit")]
        public int HerobrineArrowsHit { get; private set; }

        [JsonProperty("squid_arrows_hit")]
        public int SquidArrowsHit { get; private set; }

        [JsonProperty("moleman_arrows_hit")]
        public int MolemanArrowsHit { get; private set; }

        [JsonProperty("pigman_arrows_hit")]
        public int PigmanArrowsHit { get; private set; }

        [JsonProperty("hunter_arrows_hit")]
        public int HunterArrowsHit { get; private set; }
        #endregion

        #region meters fallen
        [JsonProperty("meters_fallen")]
        public int MetersFallen { get; private set; }

        [JsonProperty("skeleton_meters_fallen")]
        public int SkeletonMetersFallen { get; private set; }

        [JsonProperty("enderman_meters_fallen")]
        public int EndermanMetersFallen { get; private set; }

        [JsonProperty("arcanist_meters_fallen")]
        public int ArcanistMetersFallen { get; private set; }

        [JsonProperty("zombie_meters_fallen")]
        public int ZombieMetersFallen { get; private set; }

        [JsonProperty("creeper_meters_fallen")]
        public int CreeperMetersFallen { get; private set; }

        [JsonProperty("dreadlord_meters_fallen")]
        public int DreadlordMetersFallen { get; private set; }

        [JsonProperty("golem_meters_fallen")]
        public int GolemMetersFallen { get; private set; }

        [JsonProperty("spider_meters_fallen")]
        public int SpiderMetersFallen { get; private set; }

        [JsonProperty("blaze_meters_fallen")]
        public int BlazeMetersFallen { get; private set; }

        [JsonProperty("herobrine_meters_fallen")]
        public int HerobrineMetersFallen { get; private set; }

        [JsonProperty("squid_meters_fallen")]
        public int SquidMetersFallen { get; private set; }

        [JsonProperty("shaman_meters_fallen")]
        public int ShamanMetersFallen { get; private set; }

        [JsonProperty("moleman_meters_fallen")]
        public int MolemanMetersFallen { get; private set; }

        [JsonProperty("pigman_meters_fallen")]
        public int PigmanMetersFallen { get; private set; }

        [JsonProperty("pirate_meters_fallen")]
        public int PirateMetersFallen { get; private set; }

        [JsonProperty("hunter_meters_fallen")]
        public int HunterMetersFallen { get; private set; }
        #endregion

        #region iron ore broken
        [JsonProperty("iron_ore_broken")]
        public int IronOreBroken { get; private set; }

        [JsonProperty("skeleton_iron_ore_broken")]
        public int SkeletonIronOreBroken { get; private set; }

        [JsonProperty("arcanist_iron_ore_broken")]
        public int ArcanistIronOreBroken { get; private set; }

        [JsonProperty("enderman_iron_ore_broken")]
        public int EndermanIronOreBroken { get; private set; }

        [JsonProperty("zombie_iron_ore_broken")]
        public int ZombieIronOreBroken { get; private set; }

        [JsonProperty("creeper_iron_ore_broken")]
        public int CreeperIronOreBroken { get; private set; }

        [JsonProperty("dreadlord_iron_ore_broken")]
        public int DreadlordIronOreBroken { get; private set; }

        [JsonProperty("golem_iron_ore_broken")]
        public int GolemIronOreBroken { get; private set; }

        [JsonProperty("spider_iron_ore_broken")]
        public int SpiderIronOreBroken { get; private set; }

        [JsonProperty("blaze_iron_ore_broken")]
        public int BlazeIronOreBroken { get; private set; }

        [JsonProperty("herobrine_iron_ore_broken")]
        public int HerobrineIronOreBroken { get; private set; }

        [JsonProperty("squid_iron_ore_broken")]
        public int SquidIronOreBroken { get; private set; }

        [JsonProperty("shaman_iron_ore_broken")]
        public int ShamanIronOreBroken { get; private set; }

        [JsonProperty("moleman_iron_ore_broken")]
        public int MolemanIronOreBroken { get; private set; }

        [JsonProperty("pigman_iron_ore_broken")]
        public int PigmanIronOreBroken { get; private set; }

        [JsonProperty("pirate_iron_ore_broken")]
        public int PirateIronOreBroken { get; private set; }

        [JsonProperty("hunter_iron_ore_broken")]
        public int HunterIronOreBroken { get; private set; }
        #endregion

        #region diamond ore
        [JsonProperty("diamond_ore_broken")]
        public int DiamondOreBroken { get; private set; }

        [JsonProperty("skeleton_diamond_ore_broken")]
        public int SkeletonDiamondOreBroken { get; private set; }

        [JsonProperty("arcanist_diamond_ore_broken")]
        public int ArcanistDiamondOreBroken { get; private set; }

        [JsonProperty("dreadlord_diamond_ore_broken")]
        public int DreadlordDiamondOreBroken { get; private set; }

        [JsonProperty("enderman_diamond_ore_broken")]
        public int EndermanDiamondOreBroken { get; private set; }

        [JsonProperty("golem_diamond_ore_broken")]
        public int GolemDiamondOreBroken { get; private set; }

        [JsonProperty("zombie_diamond_ore_broken")]
        public int ZombieDiamondOreBroken { get; private set; }

        [JsonProperty("shaman_diamond_ore_broken")]
        public int ShamanDiamondOreBroken { get; private set; }

        [JsonProperty("squid_diamond_ore_broken")]
        public int SquidDiamondOreBroken { get; private set; }

        [JsonProperty("pirate_diamond_ore_broken")]
        public int PirateDiamondOreBroken { get; private set; }
        #endregion

        #region wither damage
        [JsonProperty("wither_damage")]
        public int WitherDamage { get; private set; }

        [JsonProperty("arcanist_wither_damage")]
        public int ArcanistWitherDamage { get; private set; }

        [JsonProperty("zombie_wither_damage")]
        public int ZombieWitherDamage { get; private set; }

        [JsonProperty("dreadlord_wither_damage")]
        public int DreadlordWitherDamage { get; private set; }

        [JsonProperty("golem_wither_damage")]
        public int GolemWitherDamage { get; private set; }

        [JsonProperty("enderman_wither_damage")]
        public int EndermanWitherDamage { get; private set; }

        [JsonProperty("blaze_wither_damage")]
        public int BlazeWitherDamage { get; private set; }

        [JsonProperty("spider_wither_damage")]
        public int SpiderWitherDamage { get; private set; }

        [JsonProperty("hunter_wither_damage")]
        public int HunterWitherDamage { get; private set; }

        [JsonProperty("creeper_wither_damage")]
        public int CreeperWitherDamage { get; private set; }

        [JsonProperty("skeleton_wither_damage")]
        public int SkeletonWitherDamage { get; private set; }
        #endregion

        #region wither kills
        [JsonProperty("wither_kills")]
        public int WitherKills { get; private set; }

        [JsonProperty("arcanist_wither_kills")]
        public int ArcanistWitherKills { get; private set; }

        [JsonProperty("zombie_wither_kills")]
        public int ZombieWitherKills { get; private set; }

        [JsonProperty("dreadlord_wither_kills")]
        public int DreadlordWitherKills { get; private set; }

        [JsonProperty("golem_wither_kills")]
        public int GolemWitherKills { get; private set; }

        [JsonProperty("enderman_wither_kills")]
        public int EndermanWitherKills { get; private set; }

        [JsonProperty("blaze_wither_kills")]
        public int BlazeWitherKills { get; private set; }

        [JsonProperty("spider_wither_kills")]
        public int SpiderWitherKills { get; private set; }

        [JsonProperty("hunter_wither_kills")]
        public int HunterWitherKills { get; private set; }

        [JsonProperty("creeper_wither_kills")]
        public int CreeperWitherKills { get; private set; }

        [JsonProperty("skeleton_wither_kills")]
        public int SkeletonWitherKills { get; private set; }
        #endregion
    }
}