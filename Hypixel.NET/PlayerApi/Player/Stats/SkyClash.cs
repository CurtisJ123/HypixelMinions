using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class SkyClash
    {
        #region general
        [JsonProperty("card_packs")]
        public int CardPacks { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("fastest_win_solo")]
        public int FastestWinSolo { get; private set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; private set; }

        [JsonProperty("void_kills")]
        public int VoidKills { get; private set; }

        [JsonProperty("games")]
        public int Games { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("most_kills_game")]
        public int MostKillsGame { get; private set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("melee_kills")]
        public int MeleeKills { get; private set; }

        [JsonProperty("kills_solo")]
        public int KillsSolo { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("solo_wins")]
        public int SoloWins { get; private set; }

        [JsonProperty("wins_solo")]
        public int WinsSolo { get; private set; }

        [JsonProperty("play_streak")]
        public int PlayStreak { get; private set; }

        [JsonProperty("killstreak")]
        public int Killstreak { get; private set; }

        [JsonProperty("highestKillstreak")]
        public int HighestKillstreak { get; private set; }

        [JsonProperty("playstreak")]
        public int Playstreak { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("deaths_solo")]
        public int DeathsSolo { get; private set; }

        [JsonProperty("quits")]
        public int Quits { get; private set; }

        [JsonProperty("losses_solo")]
        public int LossesSolo { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("mobs_killed")]
        public int MobsKilled { get; private set; }

        [JsonProperty("longest_bow_shot")]
        public int LongestBowShot { get; private set; }

        [JsonProperty("bow_hits")]
        public int BowHits { get; private set; }

        [JsonProperty("bow_shots")]
        public int BowShots { get; private set; }

        [JsonProperty("losses_doubles")]
        public int LossesDoubles { get; private set; }

        [JsonProperty("deaths_doubles")]
        public int DeathsDoubles { get; private set; }

        [JsonProperty("kills_doubles")]
        public int KillsDoubles { get; private set; }

        [JsonProperty("assists")]
        public int Assists { get; private set; }

        [JsonProperty("enderchests_opened")]
        public int EnderchestsOpened { get; private set; }

        [JsonProperty("mob_kills")]
        public int MobKills { get; private set; }

        [JsonProperty("longest_bow_kill")]
        public int LongestBowKill { get; private set; }

        [JsonProperty("bow_kills")]
        public int BowKills { get; private set; }

        [JsonProperty("fastest_win_team_war")]
        public int FastestWinTeamWar { get; private set; }

        [JsonProperty("team_war_wins")]
        public int TeamWarWins { get; private set; }

        [JsonProperty("kills_team_war")]
        public int KillsTeamWar { get; private set; }

        [JsonProperty("wins_team_war")]
        public int WinsTeamWar { get; private set; }

        [JsonProperty("losses_team_war")]
        public int LossesTeamWar { get; private set; }

        [JsonProperty("deaths_team_war")]
        public int DeathsTeamWar { get; private set; }

        [JsonProperty("fastest_win_doubles")]
        public int FastestWinDoubles { get; private set; }

        [JsonProperty("doubles_wins")]
        public int DoublesWins { get; private set; }

        [JsonProperty("wins_doubles")]
        public int WinsDoubles { get; private set; }
        #endregion

        #region perks
        [JsonProperty("public bool perk_damage_potion_new")]
        public bool PerkDamagePotionNew { get; private set; }

        [JsonProperty("perk_honed_bow")]
        public int PerkHonedBow { get; private set; }

        [JsonProperty("perk_void_magnet")]
        public int PerkVoidMagnet { get; private set; }

        [JsonProperty("perk_damage_potion")]
        public int PerkDamagePotion { get; private set; }

        [JsonProperty("perk_blast_protection")]
        public int PerkBlastProtection { get; private set; }

        [JsonProperty("perk_void_warranty")]
        public int PerkVoidWarranty { get; private set; }

        [JsonProperty("perk_fruit_finder")]
        public int PerkFruitFinder { get; private set; }

        [JsonProperty("perk_pearl_absorption")]
        public int PerkPearlAbsorption { get; private set; }

        [JsonProperty("perk_creeper")]
        public int PerkCreeper { get; private set; }

        [JsonProperty("perk_blazing_arrows")]
        public int PerkBlazingArrows { get; private set; }

        [JsonProperty("perk_regeneration")]
        public int PerkRegeneration { get; private set; }

        [JsonProperty("perk_tripleshot")]
        public int PerkTripleshot { get; private set; }

        [JsonProperty("perk_invisibility")]
        public int PerkInvisibility { get; private set; }

        [JsonProperty("perk_sugar_rush")]
        public int PerkSugarRush { get; private set; }

        [JsonProperty("perk_alchemy")]
        public int PerkAlchemy { get; private set; }

        [JsonProperty("perk_energy_drink")]
        public int PerkEnergyDrink { get; private set; }

        [JsonProperty("perk_witch")]
        public int PerkWitch { get; private set; }

        [JsonProperty("perk_sharpened_sword")]
        public int PerkSharpenedSword { get; private set; }

        [JsonProperty("perk_hit_and_run")]
        public int PerkHitAndRun { get; private set; }

        [JsonProperty("perk_hearty_start")]
        public int PerkHeartyStart { get; private set; }

        [JsonProperty("perk_pacify")]
        public int PerkPacify { get; private set; }

        [JsonProperty("perk_skeleton_jockey")]
        public int PerkSkeletonJockey { get; private set; }

        [JsonProperty("perk_resistant")]
        public int PerkResistant { get; private set; }

        [JsonProperty("perk_endless_quiver")]
        public int PerkEndlessQuiver { get; private set; }

        [JsonProperty("perk_marksman")]
        public int PerkMarksman { get; private set; }

        [JsonProperty("perk_iron_golem")]
        public int PerkIronGolem { get; private set; }

        [JsonProperty("perk_supply_drop")]
        public int PerkSupplyDrop { get; private set; }

        [JsonProperty("perk_nutritious")]
        public int PerkNutritious { get; private set; }

        [JsonProperty("perk_arrow_deflection")]
        public int PerkArrowDeflection { get; private set; }

        [JsonProperty("perk_chicken_bow")]
        public int PerkChickenBow { get; private set; }

        [JsonProperty("perk_enderman")]
        public int PerkEnderman { get; private set; }

        [JsonProperty("perk_guardian")]
        public int PerkGuardian { get; private set; }

        [JsonProperty("perk_headstart")]
        public int PerkHeadstart { get; private set; }

        [JsonProperty("perk_snow_golem")]
        public int PerkSnowGolem { get; private set; }

        [JsonProperty("perk_explosive_bow")]
        public int PerkExplosiveBow { get; private set; }

        [JsonProperty("perk_winged_boots")]
        public int PerkWingedBoots { get; private set; }

        [JsonProperty("perk_rampage")]
        public int PerkRampage { get; private set; }

        [JsonProperty("kills_perk_resistant")]
        public int KillsPerkResistant { get; private set; }

        [JsonProperty("losses_perk_resistant")]
        public int LossesPerkResistant { get; private set; }

        [JsonProperty("deaths_perk_void_warranty")]
        public int DeathsPerkVoidWarranty { get; private set; }

        [JsonProperty("deaths_perk_resistant")]
        public int DeathsPerkResistant { get; private set; }

        [JsonProperty("losses_perk_void_warranty")]
        public int LossesPerkVoidWarranty { get; private set; }

        [JsonProperty("deaths_perk_regeneration")]
        public int DeathsPerkRegeneration { get; private set; }

        [JsonProperty("kills_perk_regeneration")]
        public int KillsPerkRegeneration { get; private set; }

        [JsonProperty("losses_perk_regeneration")]
        public int LossesPerkRegeneration { get; private set; }

        [JsonProperty("kills_perk_void_warranty")]
        public int KillsPerkVoidWarranty { get; private set; }

        [JsonProperty("wins_perk_resistant")]
        public int WinsPerkResistant { get; private set; }

        [JsonProperty("wins_perk_void_warranty")]
        public int WinsPerkVoidWarranty { get; private set; }

        [JsonProperty("wins_perk_regeneration")]
        public int WinsPerkRegeneration { get; private set; }

        [JsonProperty("perk_bigger_bangs")]
        public int PerkBiggerBangs { get; private set; }

        [JsonProperty("perk_bat_shield")]
        public int PerkBatShield { get; private set; }

        [JsonProperty("perk_elven_archer")]
        public int PerkElvenArcher { get; private set; }

        [JsonProperty("perk_flower_power")]
        public int PerkFlowerPower { get; private set; }

        [JsonProperty("perk_uhc_challenge")]
        public int PerkUhcChallenge { get; private set; }

        [JsonProperty("perk_mushroom_aura")]
        public int PerkMushroomAura { get; private set; }

        [JsonProperty("perk_nuclear_solution")]
        public int PerkNuclearSolution { get; private set; }

        [JsonProperty("deaths_perk_headstart")]
        public int DeathsPerkHeadstart { get; private set; }

        [JsonProperty("losses_perk_void_magnet")]
        public int LossesPerkVoidMagnet { get; private set; }

        [JsonProperty("deaths_perk_void_magnet")]
        public int DeathsPerkVoidMagnet { get; private set; }

        [JsonProperty("losses_perk_mushroom_aura")]
        public int LossesPerkMushroomAura { get; private set; }

        [JsonProperty("kills_perk_headstart")]
        public int KillsPerkHeadstart { get; private set; }

        [JsonProperty("losses_perk_headstart")]
        public int LossesPerkHeadstart { get; private set; }

        [JsonProperty("kills_perk_mushroom_aura")]
        public int KillsPerkMushroomAura { get; private set; }

        [JsonProperty("deaths_perk_mushroom_aura")]
        public int DeathsPerkMushroomAura { get; private set; }

        [JsonProperty("kills_perk_void_magnet")]
        public int KillsPerkVoidMagnet { get; private set; }

        [JsonProperty("solo_wins_perk_uhc_challenge")]
        public int SoloWinsPerkUhcChallenge { get; private set; }

        [JsonProperty("wins_perk_hit_and_run")]
        public int WinsPerkHitAndRun { get; private set; }

        [JsonProperty("kills_perk_sharpened_sword")]
        public int KillsPerkSharpenedSword { get; private set; }

        [JsonProperty("wins_perk_sharpened_sword")]
        public int WinsPerkSharpenedSword { get; private set; }

        [JsonProperty("kills_solo_perk_uhc_challenge")]
        public int KillsSoloPerkUhcChallenge { get; private set; }

        [JsonProperty("kills_perk_hit_and_run")]
        public int KillsPerkHitAndRun { get; private set; }

        [JsonProperty("kills_perk_winged_boots")]
        public int KillsPerkWingedBoots { get; private set; }

        [JsonProperty("kills_perk_endless_quiver")]
        public int KillsPerkEndlessQuiver { get; private set; }

        [JsonProperty("deaths_perk_endless_quiver")]
        public int DeathsPerkEndlessQuiver { get; private set; }

        [JsonProperty("deaths_perk_winged_boots")]
        public int DeathsPerkWingedBoots { get; private set; }

        [JsonProperty("losses_perk_endless_quiver")]
        public int LossesPerkEndlessQuiver { get; private set; }

        [JsonProperty("losses_perk_winged_boots")]
        public int LossesPerkWingedBoots { get; private set; }

        [JsonProperty("kills_perk_pacify")]
        public int KillsPerkPacify { get; private set; }

        [JsonProperty("wins_perk_pacify")]
        public int WinsPerkPacify { get; private set; }

        [JsonProperty("wins_perk_headstart")]
        public int WinsPerkHeadstart { get; private set; }

        [JsonProperty("losses_perk_pacify")]
        public int LossesPerkPacify { get; private set; }

        [JsonProperty("deaths_perk_pacify")]
        public int DeathsPerkPacify { get; private set; }

        [JsonProperty("wins_perk_mushroom_aura")]
        public int WinsPerkMushroomAura { get; private set; }

        [JsonProperty("wins_perk_void_magnet")]
        public int WinsPerkVoidMagnet { get; private set; }

        [JsonProperty("kills_solo_perk_no_chest_challenge")]
        public int KillsSoloPerkNoChestChallenge { get; private set; }

        [JsonProperty("solo_wins_perk_no_chest_challenge")]
        public int SoloWinsPerkNoChestChallenge { get; private set; }

        [JsonProperty("kills_perk_damage_potion")]
        public int KillsPerkDamagePotion { get; private set; }

        [JsonProperty("wins_perk_witch")]
        public int WinsPerkWitch { get; private set; }

        [JsonProperty("wins_perk_damage_potion")]
        public int WinsPerkDamagePotion { get; private set; }

        [JsonProperty("kills_perk_witch")]
        public int KillsPerkWitch { get; private set; }

        [JsonProperty("losses_perk_witch")]
        public int LossesPerkWitch { get; private set; }

        [JsonProperty("deaths_perk_damage_potion")]
        public int DeathsPerkDamagePotion { get; private set; }

        [JsonProperty("losses_perk_damage_potion")]
        public int LossesPerkDamagePotion { get; private set; }

        [JsonProperty("losses_perk_sharpened_sword")]
        public int LossesPerkSharpenedSword { get; private set; }

        [JsonProperty("deaths_perk_sharpened_sword")]
        public int DeathsPerkSharpenedSword { get; private set; }

        [JsonProperty("deaths_perk_witch")]
        public int DeathsPerkWitch { get; private set; }

        [JsonProperty("deaths_perk_hearty_start")]
        public int DeathsPerkHeartyStart { get; private set; }

        [JsonProperty("deaths_perk_tripleshot")]
        public int DeathsPerkTripleshot { get; private set; }

        [JsonProperty("losses_perk_tripleshot")]
        public int LossesPerkTripleshot { get; private set; }

        [JsonProperty("kills_perk_hearty_start")]
        public int KillsPerkHeartyStart { get; private set; }

        [JsonProperty("losses_perk_hearty_start")]
        public int LossesPerkHeartyStart { get; private set; }

        [JsonProperty("kills_perk_tripleshot")]
        public int KillsPerkTripleshot { get; private set; }

        [JsonProperty("deaths_perk_invisibility")]
        public int DeathsPerkInvisibility { get; private set; }

        [JsonProperty("losses_perk_fruit_finder")]
        public int LossesPerkFruitFinder { get; private set; }

        [JsonProperty("deaths_perk_chicken_bow")]
        public int DeathsPerkChickenBow { get; private set; }

        [JsonProperty("kills_perk_fruit_finder")]
        public int KillsPerkFruitFinder { get; private set; }

        [JsonProperty("deaths_perk_fruit_finder")]
        public int DeathsPerkFruitFinder { get; private set; }

        [JsonProperty("losses_perk_chicken_bow")]
        public int LossesPerkChickenBow { get; private set; }

        [JsonProperty("kills_perk_invisibility")]
        public int KillsPerkInvisibility { get; private set; }

        [JsonProperty("losses_perk_invisibility")]
        public int LossesPerkInvisibility { get; private set; }

        [JsonProperty("kills_perk_chicken_bow")]
        public int KillsPerkChickenBow { get; private set; }

        [JsonProperty("losses_perk_skeleton_jockey")]
        public int LossesPerkSkeletonJockey { get; private set; }

        [JsonProperty("kills_perk_skeleton_jockey")]
        public int KillsPerkSkeletonJockey { get; private set; }

        [JsonProperty("deaths_perk_skeleton_jockey")]
        public int DeathsPerkSkeletonJockey { get; private set; }

        [JsonProperty("losses_perk_enderman")]
        public int LossesPerkEnderman { get; private set; }

        [JsonProperty("deaths_perk_enderman")]
        public int DeathsPerkEnderman { get; private set; }

        [JsonProperty("deaths_perk_creeper")]
        public int DeathsPerkCreeper { get; private set; }

        [JsonProperty("deaths_perk_guardian")]
        public int DeathsPerkGuardian { get; private set; }

        [JsonProperty("losses_perk_guardian")]
        public int LossesPerkGuardian { get; private set; }

        [JsonProperty("losses_perk_creeper")]
        public int LossesPerkCreeper { get; private set; }

        [JsonProperty("kills_perk_enderman")]
        public int KillsPerkEnderman { get; private set; }

        [JsonProperty("kills_perk_creeper")]
        public int KillsPerkCreeper { get; private set; }

        [JsonProperty("kills_perk_guardian")]
        public int KillsPerkGuardian { get; private set; }

        [JsonProperty("wins_perk_guardian")]
        public int WinsPerkGuardian { get; private set; }

        [JsonProperty("wins_perk_creeper")]
        public int WinsPerkCreeper { get; private set; }

        [JsonProperty("wins_perk_enderman")]
        public int WinsPerkEnderman { get; private set; }

        [JsonProperty("perk_nuclear_solution_duplicates")]
        public int PerkNuclearSolutionDuplicates { get; private set; }

        [JsonProperty("deaths_perk_pearl_absorption")]
        public int DeathsPerkPearlAbsorption { get; private set; }

        [JsonProperty("losses_perk_pearl_absorption")]
        public int LossesPerkPearlAbsorption { get; private set; }

        [JsonProperty("kills_perk_pearl_absorption")]
        public int KillsPerkPearlAbsorption { get; private set; }

        [JsonProperty("deaths_perk_bigger_bangs")]
        public int DeathsPerkBiggerBangs { get; private set; }

        [JsonProperty("deaths_perk_snow_golem")]
        public int DeathsPerkSnowGolem { get; private set; }

        [JsonProperty("losses_perk_bigger_bangs")]
        public int LossesPerkBiggerBangs { get; private set; }

        [JsonProperty("kills_perk_bigger_bangs")]
        public int KillsPerkBiggerBangs { get; private set; }

        [JsonProperty("losses_perk_snow_golem")]
        public int LossesPerkSnowGolem { get; private set; }

        [JsonProperty("kills_perk_snow_golem")]
        public int KillsPerkSnowGolem { get; private set; }

        [JsonProperty("losses_perk_explosive_bow")]
        public int LossesPerkExplosiveBow { get; private set; }

        [JsonProperty("kills_perk_explosive_bow")]
        public int KillsPerkExplosiveBow { get; private set; }

        [JsonProperty("deaths_perk_explosive_bow")]
        public int DeathsPerkExplosiveBow { get; private set; }

        [JsonProperty("kills_perk_honed_bow")]
        public int KillsPerkHonedBow { get; private set; }

        [JsonProperty("wins_perk_marksman")]
        public int WinsPerkMarksman { get; private set; }

        [JsonProperty("kills_perk_marksman")]
        public int KillsPerkMarksman { get; private set; }

        [JsonProperty("wins_perk_honed_bow")]
        public int WinsPerkHonedBow { get; private set; }

        [JsonProperty("losses_perk_arrow_deflection")]
        public int LossesPerkArrowDeflection { get; private set; }

        [JsonProperty("deaths_perk_arrow_deflection")]
        public int DeathsPerkArrowDeflection { get; private set; }

        [JsonProperty("kills_perk_blast_protection")]
        public int KillsPerkBlastProtection { get; private set; }

        [JsonProperty("losses_perk_blast_protection")]
        public int LossesPerkBlastProtection { get; private set; }

        [JsonProperty("deaths_perk_blast_protection")]
        public int DeathsPerkBlastProtection { get; private set; }

        [JsonProperty("wins_perk_explosive_bow")]
        public int WinsPerkExplosiveBow { get; private set; }

        [JsonProperty("wins_perk_hearty_start")]
        public int WinsPerkHeartyStart { get; private set; }

        [JsonProperty("deaths_perk_hit_and_run")]
        public int DeathsPerkHitAndRun { get; private set; }

        [JsonProperty("losses_perk_hit_and_run")]
        public int LossesPerkHitAndRun { get; private set; }

        [JsonProperty("deaths_perk_marksman")]
        public int DeathsPerkMarksman { get; private set; }

        [JsonProperty("losses_perk_marksman")]
        public int LossesPerkMarksman { get; private set; }

        [JsonProperty("wins_perk_invisibility")]
        public int WinsPerkInvisibility { get; private set; }

        [JsonProperty("wins_perk_fruit_finder")]
        public int WinsPerkFruitFinder { get; private set; }

        [JsonProperty("losses_perk_elven_archer")]
        public int LossesPerkElvenArcher { get; private set; }

        [JsonProperty("deaths_perk_elven_archer")]
        public int DeathsPerkElvenArcher { get; private set; }

        [JsonProperty("kills_perk_elven_archer")]
        public int KillsPerkElvenArcher { get; private set; }

        [JsonProperty("wins_perk_flower_power")]
        public int WinsPerkFlowerPower { get; private set; }

        [JsonProperty("kills_perk_flower_power")]
        public int KillsPerkFlowerPower { get; private set; }

        [JsonProperty("kills_perk_arrow_deflection")]
        public int KillsPerkArrowDeflection { get; private set; }

        [JsonProperty("wins_perk_tripleshot")]
        public int WinsPerkTripleshot { get; private set; }

        [JsonProperty("wins_perk_bat_shield")]
        public int WinsPerkBatShield { get; private set; }

        [JsonProperty("wins_perk_blast_protection")]
        public int WinsPerkBlastProtection { get; private set; }

        [JsonProperty("kills_perk_bat_shield")]
        public int KillsPerkBatShield { get; private set; }

        [JsonProperty("losses_perk_honed_bow")]
        public int LossesPerkHonedBow { get; private set; }

        [JsonProperty("deaths_perk_honed_bow")]
        public int DeathsPerkHonedBow { get; private set; }

        [JsonProperty("deaths_perk_nuclear_solution")]
        public int DeathsPerkNuclearSolution { get; private set; }

        [JsonProperty("kills_perk_nuclear_solution")]
        public int KillsPerkNuclearSolution { get; private set; }

        [JsonProperty("losses_perk_nuclear_solution")]
        public int LossesPerkNuclearSolution { get; private set; }

        [JsonProperty("kills_solo_perk_archer_challenge")]
        public int KillsSoloPerkArcherChallenge { get; private set; }

        [JsonProperty("deaths_perk_bat_shield")]
        public int DeathsPerkBatShield { get; private set; }

        [JsonProperty("kills_perk_nutritious")]
        public int KillsPerkNutritious { get; private set; }

        [JsonProperty("losses_perk_bat_shield")]
        public int LossesPerkBatShield { get; private set; }

        [JsonProperty("deaths_perk_nutritious")]
        public int DeathsPerkNutritious { get; private set; }

        [JsonProperty("losses_perk_nutritious")]
        public int LossesPerkNutritious { get; private set; }

        [JsonProperty("wins_perk_arrow_deflection")]
        public int WinsPerkArrowDeflection { get; private set; }

        [JsonProperty("deaths_perk_sugar_rush")]
        public int DeathsPerkSugarRush { get; private set; }

        [JsonProperty("losses_perk_sugar_rush")]
        public int LossesPerkSugarRush { get; private set; }

        [JsonProperty("deaths_perk_rampage")]
        public int DeathsPerkRampage { get; private set; }

        [JsonProperty("losses_perk_rampage")]
        public int LossesPerkRampage { get; private set; }

        [JsonProperty("kills_perk_rampage")]
        public int KillsPerkRampage { get; private set; }

        [JsonProperty("kills_perk_alchemy")]
        public int KillsPerkAlchemy { get; private set; }

        [JsonProperty("losses_perk_alchemy")]
        public int LossesPerkAlchemy { get; private set; }

        [JsonProperty("deaths_perk_alchemy")]
        public int DeathsPerkAlchemy { get; private set; }

        [JsonProperty("kills_perk_energy_drink")]
        public int KillsPerkEnergyDrink { get; private set; }

        [JsonProperty("deaths_perk_energy_drink")]
        public int DeathsPerkEnergyDrink { get; private set; }

        [JsonProperty("losses_perk_energy_drink")]
        public int LossesPerkEnergyDrink { get; private set; }

        [JsonProperty("losses_perk_blazing_arrows")]
        public int LossesPerkBlazingArrows { get; private set; }

        [JsonProperty("kills_perk_blazing_arrows")]
        public int KillsPerkBlazingArrows { get; private set; }

        [JsonProperty("deaths_perk_blazing_arrows")]
        public int DeathsPerkBlazingArrows { get; private set; }

        [JsonProperty("kills_perk_iron_golem")]
        public int KillsPerkIronGolem { get; private set; }

        [JsonProperty("deaths_perk_iron_golem")]
        public int DeathsPerkIronGolem { get; private set; }

        [JsonProperty("losses_perk_iron_golem")]
        public int LossesPerkIronGolem { get; private set; }

        [JsonProperty("wins_perk_nuclear_solution")]
        public int WinsPerkNuclearSolution { get; private set; }

        [JsonProperty("kills_perk_sugar_rush")]
        public int KillsPerkSugarRush { get; private set; }

        [JsonProperty("wins_perk_sugar_rush")]
        public int WinsPerkSugarRush { get; private set; }

        [JsonProperty("wins_perk_elven_archer")]
        public int WinsPerkElvenArcher { get; private set; }

        [JsonProperty("wins_perk_alchemy")]
        public int WinsPerkAlchemy { get; private set; }

        [JsonProperty("wins_perk_chicken_bow")]
        public int WinsPerkChickenBow { get; private set; }

        [JsonProperty("wins_perk_energy_drink")]
        public int WinsPerkEnergyDrink { get; private set; }

        [JsonProperty("wins_perk_bigger_bangs")]
        public int WinsPerkBiggerBangs { get; private set; }

        [JsonProperty("wins_perk_snow_golem")]
        public int WinsPerkSnowGolem { get; private set; }

        [JsonProperty("deaths_perk_flower_power")]
        public int DeathsPerkFlowerPower { get; private set; }

        [JsonProperty("losses_perk_flower_power")]
        public int LossesPerkFlowerPower { get; private set; }

        [JsonProperty("wins_perk_endless_quiver")]
        public int WinsPerkEndlessQuiver { get; private set; }

        [JsonProperty("deaths_perk_supply_drop")]
        public int DeathsPerkSupplyDrop { get; private set; }

        [JsonProperty("kills_perk_supply_drop")]
        public int KillsPerkSupplyDrop { get; private set; }

        [JsonProperty("losses_perk_supply_drop")]
        public int LossesPerkSupplyDrop { get; private set; }

        [JsonProperty("wins_perk_blazing_arrows")]
        public int WinsPerkBlazingArrows { get; private set; }

        [JsonProperty("wins_perk_skeleton_jockey")]
        public int WinsPerkSkeletonJockey { get; private set; }

        [JsonProperty("wins_perk_rampage")]
        public int WinsPerkRampage { get; private set; }

        [JsonProperty("wins_perk_pearl_absorption")]
        public int WinsPerkPearlAbsorption { get; private set; }

        [JsonProperty("wins_perk_nutritious")]
        public int WinsPerkNutritious { get; private set; }

        [JsonProperty("perk_monster_hunter")]
        public int PerkMonsterHunter { get; private set; }

        [JsonProperty("perk_lifesteal")]
        public int PerkLifesteal { get; private set; }

        [JsonProperty("perk_void_chest")]
        public int PerkVoidChest { get; private set; }

        [JsonProperty("perk_bounty_hunter")]
        public int PerkBountyHunter { get; private set; }

        [JsonProperty("perk_double_jump")]
        public int PerkDoubleJump { get; private set; }
        #endregion

        #region frostnight kit
        [JsonProperty("kit_frost_knight_minor")]
        public int KitFrostKnightMinor { get; private set; }

        [JsonProperty("melee_kills_kit_frost_knight")]
        public int MeleeKillsKitFrostKnight { get; private set; }

        [JsonProperty("mobs_spawned_kit_frost_knight")]
        public int MobsSpawnedKitFrostKnight { get; private set; }

        [JsonProperty("deaths_kit_frost_knight")]
        public int DeathsKitFrostKnight { get; private set; }

        [JsonProperty("games_played_kit_frost_knight")]
        public int GamesPlayedKitFrostKnight { get; private set; }

        [JsonProperty("kills_kit_frost_knight")]
        public int KillsKitFrostKnight { get; private set; }

        [JsonProperty("most_kills_game_kit_frost_knight")]
        public int MostKillsGameKitFrostKnight { get; private set; }

        [JsonProperty("void_kills_kit_frost_knight")]
        public int VoidKillsKitFrostKnight { get; private set; }

        [JsonProperty("fastest_win_solo_kit_frost_knight")]
        public int FastestWinSoloKitFrostKnight { get; private set; }

        [JsonProperty("solo_wins_kit_frost_knight")]
        public int SoloWinsKitFrostKnight { get; private set; }

        [JsonProperty("bow_shots_kit_frost_knight")]
        public int BowShotsKitFrostKnight { get; private set; }

        [JsonProperty("kit_frost_knight_master")]
        public int KitFrostKnightMaster { get; private set; }

        [JsonProperty("longest_bow_shot_kit_frost_knight")]
        public int LongestBowShotKitFrostKnight { get; private set; }

        [JsonProperty("bow_hits_kit_frost_knight")]
        public int BowHitsKitFrostKnight { get; private set; }

        [JsonProperty("enderchests_opened_kit_frost_knight")]
        public int EnderchestsOpenedKitFrostKnight { get; private set; }

        [JsonProperty("fastest_win_doubles_kit_frost_knight")]
        public int FastestWinDoublesKitFrostKnight { get; private set; }

        [JsonProperty("doubles_wins_kit_frost_knight")]
        public int DoublesWinsKitFrostKnight { get; private set; }

        [JsonProperty("mobs_killed_kit_frost_knight")]
        public int MobsKilledKitFrostKnight { get; private set; }

        [JsonProperty("assists_kit_frost_knight")]
        public int AssistsKitFrostKnight { get; private set; }

        [JsonProperty("longest_bow_kill_kit_frost_knight")]
        public int LongestBowKillKitFrostKnight { get; private set; }

        [JsonProperty("bow_kills_kit_frost_knight")]
        public int BowKillsKitFrostKnight { get; private set; }

        [JsonProperty("cute_pants_found_kit_frost_knight")]
        public int CutePantsFoundKitFrostKnight { get; private set; }
        #endregion

        #region jumpman kit
        [JsonProperty("kit_jumpman_minor")]
        public int KitJumpmanMinor { get; private set; }

        [JsonProperty("kit_jumpman_master")]
        public int KitJumpmanMaster { get; private set; }

        [JsonProperty("most_kills_game_kit_jumpman")]
        public int MostKillsGameKitJumpman { get; private set; }

        [JsonProperty("deaths_kit_jumpman")]
        public int DeathsKitJumpman { get; private set; }

        [JsonProperty("kills_kit_jumpman")]
        public int KillsKitJumpman { get; private set; }

        [JsonProperty("void_kills_kit_jumpman")]
        public int VoidKillsKitJumpman { get; private set; }

        [JsonProperty("melee_kills_kit_jumpman")]
        public int MeleeKillsKitJumpman { get; private set; }

        [JsonProperty("games_played_kit_jumpman")]
        public int GamesPlayedKitJumpman { get; private set; }

        [JsonProperty("longest_bow_shot_kit_jumpman")]
        public int LongestBowShotKitJumpman { get; private set; }

        [JsonProperty("bow_shots_kit_jumpman")]
        public int BowShotsKitJumpman { get; private set; }

        [JsonProperty("bow_hits_kit_jumpman")]
        public int BowHitsKitJumpman { get; private set; }

        [JsonProperty("assists_kit_jumpman")]
        public int AssistsKitJumpman { get; private set; }

        [JsonProperty("mobs_spawned_kit_jumpman")]
        public int MobsSpawnedKitJumpman { get; private set; }

        [JsonProperty("fastest_win_solo_kit_jumpman")]
        public int FastestWinSoloKitJumpman { get; private set; }

        [JsonProperty("solo_wins_kit_jumpman")]
        public int SoloWinsKitJumpman { get; private set; }

        [JsonProperty("enderchests_opened_kit_jumpman")]
        public int EnderchestsOpenedKitJumpman { get; private set; }

        [JsonProperty("mobs_killed_kit_jumpman")]
        public int MobsKilledKitJumpman { get; private set; }
        #endregion

        #region swordman kit
        [JsonProperty("fastest_win_solo_kit_swordsman")]
        public int FastestWinSoloKitSwordsman { get; private set; }

        [JsonProperty("kills_kit_swordsman")]
        public int KillsKitSwordsman { get; private set; }

        [JsonProperty("void_kills_kit_swordsman")]
        public int VoidKillsKitSwordsman { get; private set; }

        [JsonProperty("games_played_kit_swordsman")]
        public int GamesPlayedKitSwordsman { get; private set; }

        [JsonProperty("melee_kills_kit_swordsman")]
        public int MeleeKillsKitSwordsman { get; private set; }

        [JsonProperty("solo_wins_kit_swordsman")]
        public int SoloWinsKitSwordsman { get; private set; }

        [JsonProperty("most_kills_game_kit_swordsman")]
        public int MostKillsGameKitSwordsman { get; private set; }

        [JsonProperty("deaths_kit_swordsman")]
        public int DeathsKitSwordsman { get; private set; }

        [JsonProperty("mobs_killed_kit_swordsman")]
        public int MobsKilledKitSwordsman { get; private set; }

        [JsonProperty("longest_bow_shot_kit_swordsman")]
        public int LongestBowShotKitSwordsman { get; private set; }

        [JsonProperty("bow_shots_kit_swordsman")]
        public int BowShotsKitSwordsman { get; private set; }

        [JsonProperty("bow_hits_kit_swordsman")]
        public int BowHitsKitSwordsman { get; private set; }

        [JsonProperty("enderchests_opened_kit_swordsman")]
        public int EnderchestsOpenedKitSwordsman { get; private set; }

        [JsonProperty("assists_kit_swordsman")]
        public int AssistsKitSwordsman { get; private set; }

        [JsonProperty("kit_swordsman_minor")]
        public int KitSwordsmanMinor { get; private set; }

        [JsonProperty("mob_kills_kit_swordsman")]
        public int MobKillsKitSwordsman { get; private set; }

        [JsonProperty("longest_bow_kill_kit_swordsman")]
        public int LongestBowKillKitSwordsman { get; private set; }

        [JsonProperty("bow_kills_kit_swordsman")]
        public int BowKillsKitSwordsman { get; private set; }

        [JsonProperty("fastest_win_team_war_kit_swordsman")]
        public int FastestWinTeamWarKitSwordsman { get; private set; }

        [JsonProperty("team_war_wins_kit_swordsman")]
        public int TeamWarWinsKitSwordsman { get; private set; }

        [JsonProperty("fastest_win_doubles_kit_swordsman")]
        public int FastestWinDoublesKitSwordsman { get; private set; }

        [JsonProperty("doubles_wins_kit_swordsman")]
        public int DoublesWinsKitSwordsman { get; private set; }

        [JsonProperty("kit_swordsman_master")]
        public int KitSwordsmanMaster { get; private set; }

        [JsonProperty("mobs_spawned_kit_swordsman")]
        public int MobsSpawnedKitSwordsman { get; private set; }

        [JsonProperty("cute_pants_found_kit_swordsman")]
        public int CutePantsFoundKitSwordsman { get; private set; }
        #endregion

        #region assassin kit
        [JsonProperty("games_played_kit_assassin")]
        public int GamesPlayedKitAssassin { get; private set; }

        [JsonProperty("deaths_kit_assassin")]
        public int DeathsKitAssassin { get; private set; }

        [JsonProperty("assists_kit_assassin")]
        public int AssistsKitAssassin { get; private set; }

        [JsonProperty("most_kills_game_kit_assassin")]
        public int MostKillsGameKitAssassin { get; private set; }

        [JsonProperty("mobs_killed_kit_assassin")]
        public int MobsKilledKitAssassin { get; private set; }

        [JsonProperty("melee_kills_kit_assassin")]
        public int MeleeKillsKitAssassin { get; private set; }

        [JsonProperty("kills_kit_assassin")]
        public int KillsKitAssassin { get; private set; }

        [JsonProperty("bow_shots_kit_assassin")]
        public int BowShotsKitAssassin { get; private set; }

        [JsonProperty("void_kills_kit_assassin")]
        public int VoidKillsKitAssassin { get; private set; }

        [JsonProperty("longest_bow_shot_kit_assassin")]
        public int LongestBowShotKitAssassin { get; private set; }

        [JsonProperty("bow_hits_kit_assassin")]
        public int BowHitsKitAssassin { get; private set; }

        [JsonProperty("enderchests_opened_kit_assassin")]
        public int EnderchestsOpenedKitAssassin { get; private set; }

        [JsonProperty("fastest_win_solo_kit_assassin")]
        public int FastestWinSoloKitAssassin { get; private set; }

        [JsonProperty("solo_wins_kit_assassin")]
        public int SoloWinsKitAssassin { get; private set; }

        [JsonProperty("mob_kills_kit_assassin")]
        public int MobKillsKitAssassin { get; private set; }

        [JsonProperty("kit_assassin_minor")]
        public int KitAssassinMinor { get; private set; }

        [JsonProperty("fastest_win_team_war_kit_assassin")]
        public int FastestWinTeamWarKitAssassin { get; private set; }

        [JsonProperty("team_war_wins_kit_assassin")]
        public int TeamWarWinsKitAssassin { get; private set; }

        [JsonProperty("kit_assassin_master")]
        public int KitAssassinMaster { get; private set; }

        [JsonProperty("longest_bow_kill_kit_assassin")]
        public int LongestBowKillKitAssassin { get; private set; }

        [JsonProperty("bow_kills_kit_assassin")]
        public int BowKillsKitAssassin { get; private set; }

        [JsonProperty("mobs_spawned_kit_assassin")]
        public int MobsSpawnedKitAssassin { get; private set; }

        [JsonProperty("cute_pants_found_kit_assassin")]
        public int CutePantsFoundKitAssassin { get; private set; }
        #endregion

        #region necromancer
        [JsonProperty("kit_necromancer_minor")]
        public int KitNecromancerMinor { get; private set; }

        [JsonProperty("longest_bow_shot_kit_necromancer")]
        public int LongestBowShotKitNecromancer { get; private set; }

        [JsonProperty("void_kills_kit_necromancer")]
        public int VoidKillsKitNecromancer { get; private set; }

        [JsonProperty("bow_hits_kit_necromancer")]
        public int BowHitsKitNecromancer { get; private set; }

        [JsonProperty("games_played_kit_necromancer")]
        public int GamesPlayedKitNecromancer { get; private set; }

        [JsonProperty("bow_shots_kit_necromancer")]
        public int BowShotsKitNecromancer { get; private set; }

        [JsonProperty("deaths_kit_necromancer")]
        public int DeathsKitNecromancer { get; private set; }

        [JsonProperty("most_kills_game_kit_necromancer")]
        public int MostKillsGameKitNecromancer { get; private set; }

        [JsonProperty("melee_kills_kit_necromancer")]
        public int MeleeKillsKitNecromancer { get; private set; }

        [JsonProperty("kills_kit_necromancer")]
        public int KillsKitNecromancer { get; private set; }

        [JsonProperty("mobs_killed_kit_necromancer")]
        public int MobsKilledKitNecromancer { get; private set; }

        [JsonProperty("assists_kit_necromancer")]
        public int AssistsKitNecromancer { get; private set; }

        [JsonProperty("mob_kills_kit_necromancer")]
        public int MobKillsKitNecromancer { get; private set; }

        [JsonProperty("enderchests_opened_kit_necromancer")]
        public int EnderchestsOpenedKitNecromancer { get; private set; }

        [JsonProperty("fastest_win_solo_kit_necromancer")]
        public int FastestWinSoloKitNecromancer { get; private set; }

        [JsonProperty("solo_wins_kit_necromancer")]
        public int SoloWinsKitNecromancer { get; private set; }

        [JsonProperty("kit_necromancer_master")]
        public int KitNecromancerMaster { get; private set; }

        [JsonProperty("longest_bow_kill_kit_necromancer")]
        public int LongestBowKillKitNecromancer { get; private set; }

        [JsonProperty("bow_kills_kit_necromancer")]
        public int BowKillsKitNecromancer { get; private set; }

        [JsonProperty("mobs_spawned_kit_necromancer")]
        public int MobsSpawnedKitNecromancer { get; private set; }

        [JsonProperty("cute_pants_found_kit_necromancer")]
        public int CutePantsFoundKitNecromancer { get; private set; }
        #endregion

        #region cleric kit
        [JsonProperty("kit_cleric_minor")]
        public int KitClericMinor { get; private set; }

        [JsonProperty("deaths_kit_cleric")]
        public int DeathsKitCleric { get; private set; }

        [JsonProperty("games_played_kit_cleric")]
        public int GamesPlayedKitCleric { get; private set; }

        [JsonProperty("kills_kit_cleric")]
        public int KillsKitCleric { get; private set; }

        [JsonProperty("melee_kills_kit_cleric")]
        public int MeleeKillsKitCleric { get; private set; }

        [JsonProperty("most_kills_game_kit_cleric")]
        public int MostKillsGameKitCleric { get; private set; }

        [JsonProperty("void_kills_kit_cleric")]
        public int VoidKillsKitCleric { get; private set; }

        [JsonProperty("enderchests_opened_kit_cleric")]
        public int EnderchestsOpenedKitCleric { get; private set; }

        [JsonProperty("mobs_killed_kit_cleric")]
        public int MobsKilledKitCleric { get; private set; }

        [JsonProperty("mob_kills_kit_cleric")]
        public int MobKillsKitCleric { get; private set; }

        [JsonProperty("assists_kit_cleric")]
        public int AssistsKitCleric { get; private set; }

        [JsonProperty("longest_bow_shot_kit_cleric")]
        public int LongestBowShotKitCleric { get; private set; }

        [JsonProperty("bow_hits_kit_cleric")]
        public int BowHitsKitCleric { get; private set; }

        [JsonProperty("bow_shots_kit_cleric")]
        public int BowShotsKitCleric { get; private set; }

        [JsonProperty("fastest_win_solo_kit_cleric")]
        public int FastestWinSoloKitCleric { get; private set; }

        [JsonProperty("solo_wins_kit_cleric")]
        public int SoloWinsKitCleric { get; private set; }

        [JsonProperty("fastest_win_doubles_kit_cleric")]
        public int FastestWinDoublesKitCleric { get; private set; }

        [JsonProperty("doubles_wins_kit_cleric")]
        public int DoublesWinsKitCleric { get; private set; }

        [JsonProperty("kit_cleric_master")]
        public int KitClericMaster { get; private set; }

        [JsonProperty("longest_bow_kill_kit_cleric")]
        public int LongestBowKillKitCleric { get; private set; }

        [JsonProperty("bow_kills_kit_cleric")]
        public int BowKillsKitCleric { get; private set; }

        [JsonProperty("fastest_win_team_war_kit_cleric")]
        public int FastestWinTeamWarKitCleric { get; private set; }

        [JsonProperty("team_war_wins_kit_cleric")]
        public int TeamWarWinsKitCleric { get; private set; }

        [JsonProperty("mobs_spawned_kit_cleric")]
        public int MobsSpawnedKitCleric { get; private set; }

        [JsonProperty("cute_pants_found_kit_cleric")]
        public int CutePantsFoundKitCleric { get; private set; }
        #endregion

        #region scout kit
        [JsonProperty("games_played_kit_scout")]
        public int GamesPlayedKitScout { get; private set; }

        [JsonProperty("deaths_kit_scout")]
        public int DeathsKitScout { get; private set; }

        [JsonProperty("kit_scout_minor")]
        public int KitScoutMinor { get; private set; }

        [JsonProperty("kills_kit_scout")]
        public int KillsKitScout { get; private set; }

        [JsonProperty("melee_kills_kit_scout")]
        public int MeleeKillsKitScout { get; private set; }

        [JsonProperty("most_kills_game_kit_scout")]
        public int MostKillsGameKitScout { get; private set; }

        [JsonProperty("void_kills_kit_scout")]
        public int VoidKillsKitScout { get; private set; }

        [JsonProperty("assists_kit_scout")]
        public int AssistsKitScout { get; private set; }

        [JsonProperty("kit_scout_master")]
        public int KitScoutMaster { get; private set; }

        [JsonProperty("mobs_killed_kit_scout")]
        public int MobsKilledKitScout { get; private set; }

        [JsonProperty("longest_bow_shot_kit_scout")]
        public int LongestBowShotKitScout { get; private set; }

        [JsonProperty("fastest_win_solo_kit_scout")]
        public int FastestWinSoloKitScout { get; private set; }

        [JsonProperty("enderchests_opened_kit_scout")]
        public int EnderchestsOpenedKitScout { get; private set; }

        [JsonProperty("solo_wins_kit_scout")]
        public int SoloWinsKitScout { get; private set; }

        [JsonProperty("bow_shots_kit_scout")]
        public int BowShotsKitScout { get; private set; }

        [JsonProperty("bow_hits_kit_scout")]
        public int BowHitsKitScout { get; private set; }

        [JsonProperty("fastest_win_team_war_kit_scout")]
        public int FastestWinTeamWarKitScout { get; private set; }

        [JsonProperty("team_war_wins_kit_scout")]
        public int TeamWarWinsKitScout { get; private set; }

        [JsonProperty("longest_bow_kill_kit_scout")]
        public int LongestBowKillKitScout { get; private set; }

        [JsonProperty("bow_kills_kit_scout")]
        public int BowKillsKitScout { get; private set; }

        [JsonProperty("fastest_win_doubles_kit_scout")]
        public int FastestWinDoublesKitScout { get; private set; }

        [JsonProperty("doubles_wins_kit_scout")]
        public int DoublesWinsKitScout { get; private set; }

        [JsonProperty("mob_kills_kit_scout")]
        public int MobKillsKitScout { get; private set; }

        [JsonProperty("cute_pants_found_kit_scout")]
        public int CutePantsFoundKitScout { get; private set; }

        [JsonProperty("mobs_spawned_kit_scout")]
        public int MobsSpawnedKitScout { get; private set; }
        #endregion

        #region guardian kit
        [JsonProperty("kit_guardian_minor")]
        public int KitGuardianMinor { get; private set; }

        [JsonProperty("games_played_kit_guardian")]
        public int GamesPlayedKitGuardian { get; private set; }

        [JsonProperty("most_kills_game_kit_guardian")]
        public int MostKillsGameKitGuardian { get; private set; }

        [JsonProperty("void_kills_kit_guardian")]
        public int VoidKillsKitGuardian { get; private set; }

        [JsonProperty("kills_kit_guardian")]
        public int KillsKitGuardian { get; private set; }

        [JsonProperty("deaths_kit_guardian")]
        public int DeathsKitGuardian { get; private set; }

        [JsonProperty("melee_kills_kit_guardian")]
        public int MeleeKillsKitGuardian { get; private set; }

        [JsonProperty("assists_kit_guardian")]
        public int AssistsKitGuardian { get; private set; }

        [JsonProperty("bow_shots_kit_guardian")]
        public int BowShotsKitGuardian { get; private set; }

        [JsonProperty("fastest_win_solo_kit_guardian")]
        public int FastestWinSoloKitGuardian { get; private set; }

        [JsonProperty("enderchests_opened_kit_guardian")]
        public int EnderchestsOpenedKitGuardian { get; private set; }

        [JsonProperty("solo_wins_kit_guardian")]
        public int SoloWinsKitGuardian { get; private set; }

        [JsonProperty("mobs_killed_kit_guardian")]
        public int MobsKilledKitGuardian { get; private set; }

        [JsonProperty("longest_bow_shot_kit_guardian")]
        public int LongestBowShotKitGuardian { get; private set; }

        [JsonProperty("bow_hits_kit_guardian")]
        public int BowHitsKitGuardian { get; private set; }

        [JsonProperty("kit_guardian_master")]
        public int KitGuardianMaster { get; private set; }

        [JsonProperty("mob_kills_kit_guardian")]
        public int MobKillsKitGuardian { get; private set; }

        [JsonProperty("longest_bow_kill_kit_guardian")]
        public int LongestBowKillKitGuardian { get; private set; }

        [JsonProperty("bow_kills_kit_guardian")]
        public int BowKillsKitGuardian { get; private set; }

        [JsonProperty("fastest_win_doubles_kit_guardian")]
        public int FastestWinDoublesKitGuardian { get; private set; }

        [JsonProperty("doubles_wins_kit_guardian")]
        public int DoublesWinsKitGuardian { get; private set; }

        [JsonProperty("fastest_win_team_war_kit_guardian")]
        public int FastestWinTeamWarKitGuardian { get; private set; }

        [JsonProperty("team_war_wins_kit_guardian")]
        public int TeamWarWinsKitGuardian { get; private set; }

        [JsonProperty("mobs_spawned_kit_guardian")]
        public int MobsSpawnedKitGuardian { get; private set; }
        #endregion

        #region berserker kit
        [JsonProperty("most_kills_game_kit_berserker")]
        public int MostKillsGameKitBerserker { get; private set; }

        [JsonProperty("games_played_kit_berserker")]
        public int GamesPlayedKitBerserker { get; private set; }

        [JsonProperty("kills_kit_berserker")]
        public int KillsKitBerserker { get; private set; }

        [JsonProperty("deaths_kit_berserker")]
        public int DeathsKitBerserker { get; private set; }

        [JsonProperty("kit_berserker_minor")]
        public int KitBerserkerMinor { get; private set; }

        [JsonProperty("melee_kills_kit_berserker")]
        public int MeleeKillsKitBerserker { get; private set; }

        [JsonProperty("mobs_killed_kit_berserker")]
        public int MobsKilledKitBerserker { get; private set; }

        [JsonProperty("void_kills_kit_berserker")]
        public int VoidKillsKitBerserker { get; private set; }

        [JsonProperty("kit_berserker_master")]
        public int KitBerserkerMaster { get; private set; }

        [JsonProperty("bow_shots_kit_berserker")]
        public int BowShotsKitBerserker { get; private set; }

        [JsonProperty("enderchests_opened_kit_berserker")]
        public int EnderchestsOpenedKitBerserker { get; private set; }

        [JsonProperty("assists_kit_berserker")]
        public int AssistsKitBerserker { get; private set; }

        [JsonProperty("fastest_win_solo_kit_berserker")]
        public int FastestWinSoloKitBerserker { get; private set; }

        [JsonProperty("solo_wins_kit_berserker")]
        public int SoloWinsKitBerserker { get; private set; }

        [JsonProperty("mob_kills_kit_berserker")]
        public int MobKillsKitBerserker { get; private set; }

        [JsonProperty("mobs_spawned_kit_berserker")]
        public int MobsSpawnedKitBerserker { get; private set; }

        [JsonProperty("longest_bow_shot_kit_berserker")]
        public int LongestBowShotKitBerserker { get; private set; }

        [JsonProperty("bow_hits_kit_berserker")]
        public int BowHitsKitBerserker { get; private set; }

        [JsonProperty("longest_bow_kill_kit_berserker")]
        public int LongestBowKillKitBerserker { get; private set; }

        [JsonProperty("bow_kills_kit_berserker")]
        public int BowKillsKitBerserker { get; private set; }
        #endregion

        #region archer kit
        [JsonProperty("kit_archer_minor")]
        public int KitArcherMinor { get; private set; }

        [JsonProperty("longest_bow_shot_kit_archer")]
        public int LongestBowShotKitArcher { get; private set; }

        [JsonProperty("void_kills_kit_archer")]
        public int VoidKillsKitArcher { get; private set; }

        [JsonProperty("bow_hits_kit_archer")]
        public int BowHitsKitArcher { get; private set; }

        [JsonProperty("kills_kit_archer")]
        public int KillsKitArcher { get; private set; }

        [JsonProperty("bow_shots_kit_archer")]
        public int BowShotsKitArcher { get; private set; }

        [JsonProperty("games_played_kit_archer")]
        public int GamesPlayedKitArcher { get; private set; }

        [JsonProperty("most_kills_game_kit_archer")]
        public int MostKillsGameKitArcher { get; private set; }

        [JsonProperty("deaths_kit_archer")]
        public int DeathsKitArcher { get; private set; }

        [JsonProperty("enderchests_opened_kit_archer")]
        public int EnderchestsOpenedKitArcher { get; private set; }

        [JsonProperty("melee_kills_kit_archer")]
        public int MeleeKillsKitArcher { get; private set; }

        [JsonProperty("assists_kit_archer")]
        public int AssistsKitArcher { get; private set; }

        [JsonProperty("mobs_killed_kit_archer")]
        public int MobsKilledKitArcher { get; private set; }

        [JsonProperty("longest_bow_kill_kit_archer")]
        public int LongestBowKillKitArcher { get; private set; }

        [JsonProperty("bow_kills_kit_archer")]
        public int BowKillsKitArcher { get; private set; }

        [JsonProperty("fastest_win_solo_kit_archer")]
        public int FastestWinSoloKitArcher { get; private set; }

        [JsonProperty("solo_wins_kit_archer")]
        public int SoloWinsKitArcher { get; private set; }

        [JsonProperty("kit_archer_master")]
        public int KitArcherMaster { get; private set; }

        [JsonProperty("mobs_spawned_kit_archer")]
        public int MobsSpawnedKitArcher { get; private set; }

        [JsonProperty("cute_pants_found_kit_archer")]
        public int CutePantsFoundKitArcher { get; private set; }

        [JsonProperty("mob_kills_kit_archer")]
        public int MobKillsKitArcher { get; private set; }

        [JsonProperty("fastest_win_doubles_kit_archer")]
        public int FastestWinDoublesKitArcher { get; private set; }

        [JsonProperty("doubles_wins_kit_archer")]
        public int DoublesWinsKitArcher { get; private set; }
        #endregion

        #region treasure hunter kit
        [JsonProperty("kit_treasure_hunter_minor")]
        public int KitTreasureHunterMinor { get; private set; }

        [JsonProperty("fastest_win_solo_kit_treasure_hunter")]
        public int FastestWinSoloKitTreasureHunter { get; private set; }

        [JsonProperty("games_played_kit_treasure_hunter")]
        public int GamesPlayedKitTreasureHunter { get; private set; }

        [JsonProperty("enderchests_opened_kit_treasure_hunter")]
        public int EnderchestsOpenedKitTreasureHunter { get; private set; }

        [JsonProperty("mobs_spawned_kit_treasure_hunter")]
        public int MobsSpawnedKitTreasureHunter { get; private set; }

        [JsonProperty("solo_wins_kit_treasure_hunter")]
        public int SoloWinsKitTreasureHunter { get; private set; }

        [JsonProperty("kills_kit_treasure_hunter")]
        public int KillsKitTreasureHunter { get; private set; }

        [JsonProperty("void_kills_kit_treasure_hunter")]
        public int VoidKillsKitTreasureHunter { get; private set; }

        [JsonProperty("assists_kit_treasure_hunter")]
        public int AssistsKitTreasureHunter { get; private set; }

        [JsonProperty("most_kills_game_kit_treasure_hunter")]
        public int MostKillsGameKitTreasureHunter { get; private set; }

        [JsonProperty("melee_kills_kit_treasure_hunter")]
        public int MeleeKillsKitTreasureHunter { get; private set; }

        [JsonProperty("deaths_kit_treasure_hunter")]
        public int DeathsKitTreasureHunter { get; private set; }

        [JsonProperty("longest_bow_shot_kit_treasure_hunter")]
        public int LongestBowShotKitTreasureHunter { get; private set; }

        [JsonProperty("bow_shots_kit_treasure_hunter")]
        public int BowShotsKitTreasureHunter { get; private set; }

        [JsonProperty("bow_hits_kit_treasure_hunter")]
        public int BowHitsKitTreasureHunter { get; private set; }

        [JsonProperty("cute_pants_found_kit_treasure_hunter")]
        public int CutePantsFoundKitTreasureHunter { get; private set; }

        [JsonProperty("kit_treasure_hunter_master")]
        public int KitTreasureHunterMaster { get; private set; }

        [JsonProperty("mob_kills_kit_treasure_hunter")]
        public int MobKillsKitTreasureHunter { get; private set; }

        [JsonProperty("mobs_killed_kit_treasure_hunter")]
        public int MobsKilledKitTreasureHunter { get; private set; }

        [JsonProperty("fastest_win_team_war_kit_treasure_hunter")]
        public int FastestWinTeamWarKitTreasureHunter { get; private set; }

        [JsonProperty("team_war_wins_kit_treasure_hunter")]
        public int TeamWarWinsKitTreasureHunter { get; private set; }

        [JsonProperty("fastest_win_doubles_kit_treasure_hunter")]
        public int FastestWinDoublesKitTreasureHunter { get; private set; }

        [JsonProperty("doubles_wins_kit_treasure_hunter")]
        public int DoublesWinsKitTreasureHunter { get; private set; }

        [JsonProperty("longest_bow_kill_kit_treasure_hunter")]
        public int LongestBowKillKitTreasureHunter { get; private set; }

        [JsonProperty("bow_kills_kit_treasure_hunter")]
        public int BowKillsKitTreasureHunter { get; private set; }
        #endregion
    }
}