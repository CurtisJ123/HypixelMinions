using System.Collections.Generic;
using Hypixel.NET.PlayerApi.Player.Stats.SkywarsStats;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class SkyWars
    {
        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("activeKit_TEAM")]
        public string ActiveKitTeam { get; private set; }

        [JsonProperty("soul_well")]
        public int SoulWellUses { get; private set; }

        [JsonProperty("usedSoulWell")]
        public bool UsedSoulWell { get; private set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; private set; }

        [JsonProperty("survived_players")]
        public int SurvivedPlayers { get; private set; }

        [JsonProperty("arrows_hit")]
        public int ArrowsHit { get; private set; }

        [JsonProperty("blocks_broken")]
        public int BlocksBroken { get; private set; }

        [JsonProperty("blocks_placed")]
        public int BlocksPlaced { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("survived_players_team")]
        public int SurvivedPlayersTeam { get; private set; }

        [JsonProperty("losses_team_insane")]
        public int GameLossesTeamInsane { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("deaths_team")]
        public int DeathsTeam { get; private set; }

        [JsonProperty("arrows_shot")]
        public int ArrowsShot { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("kills_team")]
        public int KillsTeam { get; private set; }

        [JsonProperty("deaths_team_insane")]
        public int DeathsTeamInsane { get; private set; }

        [JsonProperty("kills_team_insane")]
        public int KillsTeamInsane { get; private set; }

        [JsonProperty("souls_gathered")]
        public int SoulsGathered { get; private set; }

        [JsonProperty("items_enchanted")]
        public int ItemsEnchanted { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("quits")]
        public int Quits { get; private set; }

        [JsonProperty("losses_team")]
        public int LossesTeam { get; private set; }

        [JsonProperty("souls")]
        public int CurrentSouls { get; private set; }

        [JsonProperty("egg_thrown")]
        public int EggsThrown { get; private set; }

        [JsonProperty("losses_team_normal")]
        public int LossesTeamNormal { get; private set; }

        [JsonProperty("deaths_team_normal")]
        public int DeathsTeamNormal { get; private set; }

        [JsonProperty("kills_team_normal")]
        public int KillsTeamNormal { get; private set; }

        [JsonProperty("games_team")]
        public int GamesTeam { get; private set; }

        [JsonProperty("assists_team")]
        public int AssistsTeam { get; private set; }

        [JsonProperty("assists")]
        public int Assists { get; private set; }

        [JsonProperty("games")]
        public int Games { get; private set; }

        [JsonProperty("activeKit_MEGA")]
        public string MegaActiveKit { get; private set; }

        [JsonProperty("games_mega")]
        public int GamesMega { get; private set; }

        [JsonProperty("enderpearls_thrown")]
        public int EnderpearlsThrown { get; private set; }

        [JsonProperty("kills_mega")]
        public int KillsMega { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("survived_players_mega")]
        public int SurvivedPlayersMega { get; private set; }

        [JsonProperty("wins_mega_normal")]
        public int WinsMegaNormal { get; private set; }

        [JsonProperty("wins_mega")]
        public int WinsMega { get; private set; }

        [JsonProperty("kills_mega_normal")]
        public int KillsMegaNormal { get; private set; }

        [JsonProperty("assists_mega")]
        public int AssistsMega { get; private set; }

        [JsonProperty("paid_souls")]
        public int BoughtSouls { get; private set; }

        [JsonProperty("losses_mega_normal")]
        public int LossesMegaNormal { get; private set; }

        [JsonProperty("deaths_mega_normal")]
        public int DeathsMegaNormal { get; private set; }

        [JsonProperty("losses_mega")]
        public int LossesMega { get; private set; }

        [JsonProperty("deaths_mega")]
        public int DeathsMega { get; private set; }

        [JsonProperty("refill_chest_destroy")]
        public int TotalDestroyedChests { get; private set; }

        [JsonProperty("public string activeKit_SOLO")]
        public string SoloActiveKit { get; private set; }

        [JsonProperty("survived_players_solo")]
        public int SurvivedPlayersSolo { get; private set; }

        [JsonProperty("losses_solo_normal")]
        public int LossesSoloNormal { get; private set; }

        [JsonProperty("deaths_solo")]
        public int DeathsSolo { get; private set; }

        [JsonProperty("deaths_solo_normal")]
        public int DeathsSoloNormal { get; private set; }

        [JsonProperty("losses_solo")]
        public int LossesSolo { get; private set; }

        [JsonProperty("wins_team_normal")]
        public int WinsTeamNormal { get; private set; }

        [JsonProperty("wins_team")]
        public int WinsTeam { get; private set; }

        [JsonProperty("soul_well_rares")]
        public int SoulWellRaresWon { get; private set; }

        [JsonProperty("public string activeCage")]
        public string ActiveCage { get; private set; }

        [JsonProperty("games_solo")]
        public int GamesSolo { get; private set; }

        [JsonProperty("kills_solo_normal")]
        public int KillsSoloNormal { get; private set; }

        [JsonProperty("wins_solo_normal")]
        public int WinsSoloNormal { get; private set; }

        [JsonProperty("wins_solo")]
        public int WinsSolo { get; private set; }

        [JsonProperty("kills_solo")]
        public int KillsSolo { get; private set; }

        [JsonProperty("soul_well_legendaries")]
        public int SoulWellLegendaryWon { get; private set; }

        [JsonProperty("losses_solo_insane")]
        public int LossesSoloInsane { get; private set; }

        [JsonProperty("deaths_solo_insane")]
        public int DeathsSoloInsane { get; private set; }

        [JsonProperty("assists_solo")]
        public int SoloAssists { get; private set; }

        [JsonProperty("wins_team_insane")]
        public int WinsTeamInsane { get; private set; }

        [JsonProperty("wins_solo_insane")]
        public int WinsSoloInsane { get; private set; }

        [JsonProperty("kills_solo_insane")]
        public int KillsSoloInsane { get; private set; }

        [JsonProperty("winstreak_ranked")]
        public int WinstreakRanked { get; private set; }

        [JsonProperty("killstreak")]
        public int KillStreak { get; private set; }

        [JsonProperty("games_ranked")]
        public int GamesRanked { get; private set; }

        [JsonProperty("wins_ranked_normal")]
        public int WinsRankedNormal { get; private set; }

        [JsonProperty("killstreak_ranked")]
        public int KillstreakRanked { get; private set; }

        [JsonProperty("kills_ranked_normal")]
        public int KillsRankedNormal { get; private set; }

        [JsonProperty("survived_players_ranked")]
        public int SurvivedPlayersRanked { get; private set; }

        [JsonProperty("kills_ranked")]
        public int KillsRanked { get; private set; }

        [JsonProperty("wins_ranked")]
        public int WinsRanked { get; private set; }

        [JsonProperty("highestKillstreak")]
        public int HighestKillstreak { get; private set; }

        [JsonProperty("highestWinstreak")]
        public int HighestWinStreak { get; private set; }

        [JsonProperty("killstreak_team")]
        public int KillStreakTeam { get; private set; }

        [JsonProperty("winstreak_team")]
        public int WinStreakTeam { get; private set; }

        [JsonProperty("killstreak_solo")]
        public int KillStreakSolo { get; private set; }

        [JsonProperty("winstreak_solo")]
        public int WinStreakSolo { get; private set; }

        [JsonProperty("losses_ranked")]
        public int LossesRanked { get; private set; }

        [JsonProperty("deaths_ranked_normal")]
        public int DeathsRankedNormal { get; private set; }

        [JsonProperty("losses_ranked_normal")]
        public int LossesRankedNormal { get; private set; }

        [JsonProperty("deaths_ranked")]
        public int DeathsRanked { get; private set; }

        [JsonProperty("assists_ranked")]
        public int AssistsRanked { get; private set; }

        [JsonProperty("fastest_win")]
        public int FastestWin { get; private set; }

        [JsonProperty("fastest_win_team")]
        public int FastestWinTeam { get; private set; }

        [JsonProperty("melee_kills_team")]
        public int MeleeKillsTeam { get; private set; }

        [JsonProperty("void_kills")]
        public int VoidKills { get; private set; }

        [JsonProperty("chests_opened_team")]
        public int ChestsOpenedTeam { get; private set; }

        [JsonProperty("time_played")]
        public int TimePlayed { get; private set; }

        [JsonProperty("most_kills_game")]
        public int MostKillsGame { get; private set; }

        [JsonProperty("arrows_shot_team")]
        public int ArrowsShotTeam { get; private set; }

        [JsonProperty("chests_opened")]
        public int ChestsOpened { get; private set; }

        [JsonProperty("melee_kills")]
        public int MeleeKills { get; private set; }

        [JsonProperty("arrows_hit_team")]
        public int ArrowsHitTeam { get; private set; }

        [JsonProperty("most_kills_game_team")]
        public int MostKillsGameTeam { get; private set; }

        [JsonProperty("time_played_team")]
        public int TimePlayedTeam { get; private set; }

        [JsonProperty("void_kills_team")]
        public int VoidKillsTeam { get; private set; }

        [JsonProperty("chests_opened_mega")]
        public int ChestsOpenedMega { get; private set; }

        [JsonProperty("most_kills_game_mega")]
        public int MostKillsGameMega { get; private set; }

        [JsonProperty("void_kills_mega")]
        public int VoidKillsMega { get; private set; }

        [JsonProperty("time_played_mega")]
        public int TimePlayedMega { get; private set; }

        [JsonProperty("melee_kills_mega")]
        public int MeleeKillsMega { get; private set; }

        [JsonProperty("arrows_shot_mega")]
        public int ArrowsShotMega { get; private set; }

        [JsonProperty("arrows_hit_mega")]
        public int ArrowsHitMega { get; private set; }

        [JsonProperty("fastest_win_mega")]
        public int FastestWinMega { get; private set; }

        [JsonProperty("fastest_win_solo")]
        public int FastestWinSolo { get; private set; }

        [JsonProperty("melee_kills_solo")]
        public int MeleeKillsSolo { get; private set; }

        [JsonProperty("arrows_hit_solo")]
        public int ArrowsHitSolo { get; private set; }

        [JsonProperty("most_kills_game_solo")]
        public int MostKillsGameSolo { get; private set; }

        [JsonProperty("chests_opened_solo")]
        public int ChestsOpenedSolo { get; private set; }

        [JsonProperty("time_played_solo")]
        public int TimePlayedSolo { get; private set; }

        [JsonProperty("arrows_shot_solo")]
        public int ArrowsShotSolo { get; private set; }

        [JsonProperty("void_kills_solo")]
        public int VoidKillsSolo { get; private set; }

        [JsonProperty("mob_kills")]
        public int MobKills { get; private set; }

        [JsonProperty("mob_kills_solo")]
        public int MobKillsSolo { get; private set; }

        [JsonProperty("mob_kills_team")]
        public int MobKillsTeam { get; private set; }

        [JsonProperty("chests_opened_ranked")]
        public int ChestsOpenedRanked { get; private set; }

        [JsonProperty("time_played_ranked")]
        public int TimePlayedRanked { get; private set; }

        [JsonProperty("fastest_win_ranked")]
        public int FastestWinRanked { get; private set; }

        [JsonProperty("void_kills_ranked")]
        public int VoidKillsRanked { get; private set; }

        [JsonProperty("most_kills_game_ranked")]
        public int MostKillsGameRanked { get; private set; }

        [JsonProperty("melee_kills_ranked")]
        public int MeleeKillsRanked { get; private set; }

        [JsonProperty("arrows_hit_ranked")]
        public int ArrowsHitRanked { get; private set; }

        [JsonProperty("arrows_shot_ranked")]
        public int ArrowsShotRanked { get; private set; }

        [JsonProperty("mob_kills_mega")]
        public int MobKillsMega { get; private set; }

        [JsonProperty("games_played_skywars")]
        public int TotalSkywarsGamesPlayed { get; private set; }

        [JsonProperty("survived_players_lab_solo")]
        public int SurvivedPlayersLabSolo { get; private set; }

        [JsonProperty("wins_lab")]
        public int WinsLab { get; private set; }

        [JsonProperty("killstreak_lab")]
        public int KillStreakLab { get; private set; }

        [JsonProperty("void_kills_lab")]
        public int VoidKillsLab { get; private set; }

        [JsonProperty("souls_gathered_lab")]
        public int SoulsGatheredLab { get; private set; }

        [JsonProperty("games_lab")]
        public int GamesLab { get; private set; }

        [JsonProperty("survived_players_lab")]
        public int SurvivedPlayersLab { get; private set; }

        [JsonProperty("coins_gained_lab")]
        public int CoinsGainedLab { get; private set; }

        [JsonProperty("kills_lab")]
        public int KillsLab { get; private set; }

        [JsonProperty("winstreak_lab")]
        public int WinstreakLab { get; private set; }

        [JsonProperty("games_lab_solo")]
        public int GamesLabSolo { get; private set; }

        [JsonProperty("egg_thrown_lab")]
        public int EggsThrownLab { get; private set; }

        [JsonProperty("melee_kills_lab_solo")]
        public int MeleeKillsLabSolo { get; private set; }

        [JsonProperty("blocks_placed_lab")]
        public int BlocksPlacedLab { get; private set; }

        [JsonProperty("kills_lab_solo")]
        public int KillsLabSolo { get; private set; }

        [JsonProperty("chests_opened_lab_solo")]
        public int ChestsOpenedLabSolo { get; private set; }

        [JsonProperty("winstreak_lab_solo")]
        public int WinstreakLabSolo { get; private set; }

        [JsonProperty("time_played_lab_solo")]
        public int TimePlayedLabSolo { get; private set; }

        [JsonProperty("time_played_lab")]
        public int TimePlayedLab { get; private set; }

        [JsonProperty("killstreak_lab_solo")]
        public int KillstreakLabSolo { get; private set; }

        [JsonProperty("chests_opened_lab")]
        public int ChestsOpenedLab { get; private set; }

        [JsonProperty("wins_lab_solo")]
        public int WinsLabSolo { get; private set; }

        [JsonProperty("void_kills_lab_solo")]
        public int VoidKillsLabSolo { get; private set; }

        [JsonProperty("melee_kills_lab")]
        public int MeleeKillsLab { get; private set; }

        [JsonProperty("souls_lab")]
        public int SoulsLab { get; private set; }

        [JsonProperty("win_streak_lab")]
        public int WinStreakLab { get; private set; }

        [JsonProperty("deaths_lab")]
        public int DeathsLab { get; private set; }

        [JsonProperty("deaths_lab_solo")]
        public int DeathsLabSolo { get; private set; }

        [JsonProperty("losses_lab_solo")]
        public int LossesLabSolo { get; private set; }

        [JsonProperty("losses_lab")]
        public int LossesLab { get; private set; }

        [JsonProperty("quits_lab")]
        public int QuitsLab { get; private set; }

        [JsonProperty("blocks_broken_lab")]
        public int BlocksBrokenLab { get; private set; }

        [JsonProperty("arrows_shot_lab_solo")]
        public int ArrowsShotLabSolo { get; private set; }

        [JsonProperty("arrows_shot_lab")]
        public int ArrowsShotLab { get; private set; }

        [JsonProperty("survived_players_lab_team")]
        public int SurvivedPlayersLabTeam { get; private set; }

        [JsonProperty("losses_lab_team")]
        public int LossesLabTeam { get; private set; }

        [JsonProperty("melee_kills_lab_team")]
        public int MeleeKillsLabTeam { get; private set; }

        [JsonProperty("kills_lab_team")]
        public int KillsLabTeam { get; private set; }

        [JsonProperty("deaths_lab_team")]
        public int DeathsLabTeam { get; private set; }

        [JsonProperty("chests_opened_lab_team")]
        public int ChestsOpenedLabTeam { get; private set; }

        [JsonProperty("time_played_lab_team")]
        public int TimePlayedLabTeam { get; private set; }

        [JsonProperty("enderpearls_thrown_lab")]
        public int EnderpearlsThrownLab { get; private set; }

        [JsonProperty("void_kills_lab_team")]
        public int VoidKillsLabTeam { get; private set; }

        [JsonProperty("games_lab_team")]
        public int GamesLabTeam { get; private set; }

        [JsonProperty("fastest_win_lab_team")]
        public int FastestWinLabTeam { get; private set; }

        [JsonProperty("fastest_win_lab")]
        public int FastestWinLab { get; private set; }

        [JsonProperty("winstreak_lab_team")]
        public int WinstreakLabTeam { get; private set; }

        [JsonProperty("killstreak_lab_team")]
        public int KillstreakLabTeam { get; private set; }

        [JsonProperty("wins_lab_team")]
        public int WinsLabTeam { get; private set; }

        [JsonProperty("lab_win_tnt_madness_lab")]
        public int LabWinTntMadnessLab { get; private set; }

        [JsonProperty("lab_win_slime_lab")]
        public int LabWinSlimeLab { get; private set; }

        [JsonProperty("lab_win_slime_lab_solo")]
        public int LabWinSlimeLabSolo { get; private set; }

        [JsonProperty("arrows_hit_lab")]
        public int ArrowsHitLab { get; private set; }

        [JsonProperty("arrows_hit_lab_solo")]
        public int ArrowsHitLabSolo { get; private set; }

        [JsonProperty("assists_lab")]
        public int AssistsLab { get; private set; }

        [JsonProperty("assists_lab_solo")]
        public int AssistsLabSolo { get; private set; }

        [JsonProperty("arrows_shot_lab_team")]
        public int ArrowsShotLabTeam { get; private set; }

        [JsonProperty("lab_win_slime_lab_team")]
        public int LabWinSlimeLabTeam { get; private set; }

        [JsonProperty("assists_lab_team")]
        public int AssistsLabTeam { get; private set; }

        [JsonProperty("arrows_hit_lab_team")]
        public int ArrowsHitLabTeam { get; private set; }

        [JsonProperty("mob_kills_lab_team")]
        public int MobKillsLabTeam { get; private set; }

        [JsonProperty("mob_kills_lab")]
        public int MobKillsLab { get; private set; }

        [JsonProperty("lab_win_tnt_madness_lab_solo")]
        public int LabWinTntMadnessLabSolo { get; private set; }

        [JsonProperty("longest_bow_shot_lab")]
        public int LongestBowShotLab { get; private set; }

        [JsonProperty("longest_bow_shot_lab_team")]
        public int LongestBowShotLabTeam { get; private set; }

        [JsonProperty("lab_win_rush_lab_team")]
        public int LabWinRushLabTeam { get; private set; }

        [JsonProperty("lab_win_rush_lab")]
        public int LabWinRushLab { get; private set; }

        [JsonProperty("lab_win_rush_lab_solo")]
        public int LabWinRushLabSolo { get; private set; }

        [JsonProperty("mob_kills_lab_solo")]
        public int MobKillsLabSolo { get; private set; }

        [JsonProperty("longest_bow_kill")]
        public int LongestBowKill { get; private set; }

        [JsonProperty("longest_bow_kill_solo")]
        public int LongestBowKillSolo { get; private set; }

        [JsonProperty("longest_bow_kill_team")]
        public int LongestBowKillTeam { get; private set; }

        [JsonProperty("longest_bow_kill_ranked")]
        public int LongestBowKillRanked { get; private set; }

        [JsonProperty("longest_bow_kill_mega")]
        public int LongestBowKillMega { get; private set; }

        [JsonProperty("skywars_chests")]
        public int SkywarsChests { get; private set; }

        [JsonProperty("lab_win_lucky_blocks_lab_team")]
        public int LabWinLuckyBlocksLabTeam { get; private set; }

        [JsonProperty("lab_win_lucky_blocks_lab")]
        public int LabWinLuckyBlocksLab { get; private set; }

        [JsonProperty("SkyWars_openedCommons")]
        public int SkywarsChestsOpenedCommons { get; private set; }

        [JsonProperty("skywars_chest_history")]
        public List<string> SkywarsChestHistory { get; private set; }

        [JsonProperty("SkyWars_openedChests")]
        public int SkyWarsOpenedChests { get; private set; }

        [JsonProperty("SkyWars_openedRares")]
        public int SkywarsChestsOpenedRares { get; private set; }

        [JsonProperty("lab_win_lucky_blocks_lab_solo")]
        public int LabWinLuckyBlocksLabSolo { get; private set; }

        [JsonProperty("refill_chest_destroy_lab")]
        public int RefillChestsDestroyedLab { get; private set; }

        [JsonProperty("cosmetic_tokens")]
        public int CosmeticTokens { get; private set; }

        [JsonProperty("public string active_victorydance")]
        public string ActiveVictorydance { get; private set; }

        [JsonProperty("bow_kills_team")]
        public int BowKillsTeam { get; private set; }

        [JsonProperty("bow_kills")]
        public int BowKills { get; private set; }

        [JsonProperty("bow_kills_solo")]
        public int BowKillsSolo { get; private set; }

        [JsonProperty("skywars_easter_boxes")]
        public int SkywarsEasterBoxes { get; private set; }

        [JsonProperty("longest_bow_kill_lab_solo")]
        public int LongestBowKillLabSolo { get; private set; }

        [JsonProperty("longest_bow_kill_lab")]
        public int LongestBowKillLab { get; private set; }

        [JsonProperty("bow_kills_lab")]
        public int BowKillsLab { get; private set; }

        [JsonProperty("bow_kills_lab_solo")]
        public int BowKillsLabSolo { get; private set; }

        [JsonProperty("bow_kills_lab_team")]
        public int BowKillsLabTeam { get; private set; }

        [JsonProperty("beast_chance")]
        public int BeastChance { get; private set; }

        [JsonProperty("fastest_win_lab_solo")]
        public int FastestWinLabSolo { get; private set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab_solo")]
        public int LabWinHuntersVsBeastsLabSolo { get; private set; }

        [JsonProperty("lab_win_hunters_vs_beasts_lab")]
        public int LabWinHuntersVsBeastsLab { get; private set; }

        [JsonProperty("activeKit_MEGA_DOUBLES_random")]
        public bool ActiveKitMegaDoublesRandom { get; private set; }

        [JsonProperty("public string activeKit_MEGA_DOUBLES")]
        public string ActiveKitMegaDoubles { get; private set; }

        [JsonProperty("time_played_mega_doubles")]
        public int TimePlayedMegaDoubles { get; private set; }

        [JsonProperty("losses_mega_doubles_normal")]
        public int LossesMegaDoublesNormal { get; private set; }

        [JsonProperty("kills_mega_doubles_normal")]
        public int KillsMegaDoublesNormal { get; private set; }

        [JsonProperty("deaths_mega_doubles_normal")]
        public int DeathsMegaDoublesNormal { get; private set; }

        [JsonProperty("survived_players_mega_doubles")]
        public int SurvivedPlayersMegaDoubles { get; private set; }

        [JsonProperty("losses_mega_doubles")]
        public int LossesMegaDoubles { get; private set; }

        [JsonProperty("melee_kills_mega_doubles")]
        public int MeleeKillsMegaDoubles { get; private set; }

        [JsonProperty("kills_mega_doubles")]
        public int KillsMegaDoubles { get; private set; }

        [JsonProperty("deaths_mega_doubles")]
        public int DeathsMegaDoubles { get; private set; }

        [JsonProperty("chests_opened_mega_doubles")]
        public int ChestsOpenedMegaDoubles { get; private set; }

        [JsonProperty("games_mega_doubles")]
        public int GamesMegaDoubles { get; private set; }

        [JsonProperty("public bool activeKit_SOLO_random")]
        public bool ActiveKitSoloRandom { get; private set; }

        [JsonProperty("lab_hvb_hunter_wins_lab")]
        public int LabHvbHunterWinsLab { get; private set; }

        [JsonProperty("public bool activeKit_TEAMS_random")]
        public bool ActiveKitTeamsRandom { get; private set; }

        [JsonProperty("arrows_shot_mega_doubles")]
        public int ArrowsShotMegaDoubles { get; private set; }

        [JsonProperty("arrows_hit_mega_doubles")]
        public int ArrowsHitMegaDoubles { get; private set; }

        [JsonProperty("void_kills_mega_doubles")]
        public int VoidKillsMegaDoubles { get; private set; }

        [JsonProperty("lab_hvb_beast_wins_lab")]
        public int LabHvbBeastWinsLab { get; private set; }

        [JsonProperty("lab_hvb_beast_enraged_wins_lab")]
        public int LabHvbBeastEnragedWinsLab { get; private set; }

        [JsonProperty("lab_hvb_beast_enrages_lab")]
        public int LabHvbBeastEnragesLab { get; private set; }

        [JsonProperty("assists_mega_doubles")]
        public int AssistsMegaDoubles { get; private set; }

        [JsonProperty("skywars_experience")]
        public int SkywarsExperience { get; private set; }

        [JsonProperty("most_kills_game_lab_solo")]
        public int MostKillsGameLabSolo { get; private set; }

        [JsonProperty("most_kills_game_lab")]
        public int MostKillsGameLab { get; private set; }

        [JsonProperty("selected_prestige_icon")]
        public string SelectedPrestigeIcon { get; private set; }

        [JsonProperty("challenge_wins_uhc")]
        public int ChallengeWinsUhc { get; private set; }

        [JsonProperty("challenge_attempts_uhc_solo")]
        public int ChallengeAttemptsUhcSolo { get; private set; }

        [JsonProperty("challenge_wins_uhc_solo")]
        public int ChallengeWinsUhcSolo { get; private set; }

        [JsonProperty("challenge_attempts_uhc")]
        public int ChallengeAttemptsUhc { get; private set; }

        [JsonProperty("challenge_wins")]
        public int ChallengeWins { get; private set; }

        [JsonProperty("challenge_attempts_solo")]
        public int ChallengeAttemptsSolo { get; private set; }

        [JsonProperty("challenge_wins_solo")]
        public int ChallengeWinsSolo { get; private set; }

        [JsonProperty("challenge_attempts")]
        public int ChallengeAttempts { get; private set; }

        [JsonProperty("challenge_attempts_no_chest")]
        public int ChallengeAttemptsNoChest { get; private set; }

        [JsonProperty("challenge_attempts_no_chest_solo")]
        public int ChallengeAttemptsNoChestSolo { get; private set; }

        [JsonProperty("heads")]
        public int TotalHeads { get; private set; }

        [JsonProperty("heads_solo")]
        public int HeadsSolo { get; private set; }

        [JsonProperty("heads_succulent_solo")]
        public int HeadsSucculentSolo { get; private set; }

        [JsonProperty("heads_succulent")]
        public int HeadsSucculent { get; private set; }

        [JsonProperty("longest_bow_shot_lab_solo")]
        public int LongestBowShotLabSolo { get; private set; }

        [JsonProperty("challenge_attempts_archer_solo")]
        public int ChallengeAttemptsArcherSolo { get; private set; }

        [JsonProperty("challenge_attempts_archer")]
        public int ChallengeAttemptsArcher { get; private set; }

        [JsonProperty("challenge_attempts_paper")]
        public int ChallengeAttemptsPaper { get; private set; }

        [JsonProperty("challenge_attempts_paper_solo")]
        public int ChallengeAttemptsPaperSolo { get; private set; }

        [JsonProperty("challenge_wins_paper_solo")]
        public int ChallengeWinsPaperSolo { get; private set; }

        [JsonProperty("challenge_wins_paper")]
        public int ChallengeWinsPaper { get; private set; }

        [JsonProperty("challenge_attempts_rookie_solo")]
        public int ChallengeAttemptsRookieSolo { get; private set; }

        [JsonProperty("challenge_attempts_rookie")]
        public int ChallengeAttemptsRookie { get; private set; }

        [JsonProperty("heads_eww")]
        public int HeadsEww { get; private set; }

        [JsonProperty("heads_eww_solo")]
        public int HeadsEwwSolo { get; private set; }

        [JsonProperty("head_collection")]
        public HeadCollection HeadCollection { get; private set; }

        [JsonProperty("angel_of_death_level")]
        public int AngelOfDeathLevel { get; private set; }

        [JsonProperty("heads_decent")]
        public int HeadsDecent { get; private set; }

        [JsonProperty("heads_team")]
        public int HeadsTeam { get; private set; }

        [JsonProperty("heads_decent_team")]
        public int HeadsDecentTeam { get; private set; }

        [JsonProperty("heads_divine")]
        public int HeadsDivine { get; private set; }

        [JsonProperty("heads_divine_team")]
        public int HeadsDivineTeam { get; private set; }

        [JsonProperty("challenge_wins_archer")]
        public int ChallengeWinsArcher { get; private set; }

        [JsonProperty("challenge_wins_archer_solo")]
        public int ChallengeWinsArcherSolo { get; private set; }

        [JsonProperty("challenge_attempts_half_health")]
        public int ChallengeAttemptsHalfHealth { get; private set; }

        [JsonProperty("challenge_attempts_half_health_solo")]
        public int ChallengeAttemptsHalfHealthSolo { get; private set; }

        [JsonProperty("challenge_attempts_no_block_solo")]
        public int ChallengeAttemptsNoBlockSolo { get; private set; }

        [JsonProperty("challenge_attempts_no_block")]
        public int ChallengeAttemptsNoBlock { get; private set; }

        [JsonProperty("heads_tasty_solo")]
        public int HeadsTastySolo { get; private set; }

        [JsonProperty("heads_tasty")]
        public int HeadsTasty { get; private set; }

        [JsonProperty("heads_decent_solo")]
        public int HeadsDecentSolo { get; private set; }

        [JsonProperty("heads_salty")]
        public int HeadsSalty { get; private set; }

        [JsonProperty("heads_meh")]
        public int HeadsMeh { get; private set; }

        [JsonProperty("heads_meh_solo")]
        public int HeadsMehSolo { get; private set; }

        [JsonProperty("heads_salty_solo")]
        public int HeadsSaltySolo { get; private set; }

        [JsonProperty("heads_divine_solo")]
        public int HeadsDivineSolo { get; private set; }

        [JsonProperty("heads_tasty_team")]
        public int HeadsTastyTeam { get; private set; }

        [JsonProperty("heads_meh_team")]
        public int HeadsMehTeam { get; private set; }

        [JsonProperty("heads_yucky_solo")]
        public int HeadsYuckySolo { get; private set; }

        [JsonProperty("heads_yucky")]
        public int HeadsYucky { get; private set; }

        [JsonProperty("heads_salty_team")]
        public int HeadsSaltyTeam { get; private set; }
    }
}