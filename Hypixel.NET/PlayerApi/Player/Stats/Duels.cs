using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Duels
    {
        #region general
        [JsonProperty("games_played_duels")]
        public int GamesPlayedDuels { get; private set; }

        [JsonProperty("duels_recently_played")]
        public string DuelsRecentlyPlayed { get; private set; }

        [JsonProperty("melee_swings")]
        public int MeleeSwings { get; private set; }

        [JsonProperty("melee_hits")]
        public int MeleeHits { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("rounds_played")]
        public int RoundsPlayed { get; private set; }

        [JsonProperty("bow_shots")]
        public int BowShots { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("bow_hits")]
        public int BowHits { get; private set; }

        [JsonProperty("health_regenerated")]
        public int HealthRegenerated { get; private set; }

        [JsonProperty("damage_dealt")]
        public int DamageDealt { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("current_winstreak")]
        public int CurrentWinstreak { get; private set; }

        [JsonProperty("best_overall_winstreak")]
        public int BestOverallWinstreak { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("blocks_placed")]
        public int BlocksPlaced { get; private set; }

        [JsonProperty("maps_won_on")]
        public List<string> MapsWonOn { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("meters_travelled")]
        public int MetersTravelled { get; private set; }

        [JsonProperty("duels_chests")]
        public int DuelsChests { get; private set; }

        [JsonProperty("Duels_openedRares")]
        public int DuelsOpenedRares { get; private set; }

        [JsonProperty("Duels_openedChests")]
        public int DuelsOpenedChests { get; private set; }

        [JsonProperty("Duels_openedCommons")]
        public int DuelsOpenedCommons { get; private set; }

        [JsonProperty("equipped_custom_titles")]
        public string EquippedCustomTitles { get; private set; }
        #endregion

        #region Uhc
        [JsonProperty("duels_winstreak_best_uhc_four")]
        public int DuelsWinstreakBestUhcFour { get; private set; }

        [JsonProperty("duels_winstreak_best_uhc_duel")]
        public int DuelsWinstreakBestUhcDuel { get; private set; }

        [JsonProperty("duels_winstreak_uhc_four")]
        public int DuelsWinstreakUhcFour { get; private set; }

        [JsonProperty("uhc_duel_health_regenerated")]
        public int UhcDuelHealthRegenerated { get; private set; }

        [JsonProperty("uhc_duel_bow_shots")]
        public int UhcDuelBowShots { get; private set; }

        [JsonProperty("uhc_duel_melee_swings")]
        public int UhcDuelMeleeSwings { get; private set; }

        [JsonProperty("uhc_duel_kills")]
        public int UhcDuelKills { get; private set; }

        [JsonProperty("uhc_duel_bow_hits")]
        public int UhcDuelBowHits { get; private set; }

        [JsonProperty("uhc_duel_rounds_played")]
        public int UhcDuelRoundsPlayed { get; private set; }

        [JsonProperty("uhc_duel_damage_dealt")]
        public int UhcDuelDamageDealt { get; private set; }

        [JsonProperty("uhc_duel_wins")]
        public int UhcDuelWins { get; private set; }

        [JsonProperty("uhc_duel_melee_hits")]
        public int UhcDuelMeleeHits { get; private set; }

        [JsonProperty("uhc_duel_losses")]
        public int UhcDuelLosses { get; private set; }

        [JsonProperty("uhc_duel_deaths")]
        public int UhcDuelDeaths { get; private set; }

        [JsonProperty("uhc_tournament_melee_hits")]
        public int UhcTournamentMeleeHits { get; private set; }

        [JsonProperty("uhc_tournament_health_regenerated")]
        public int UhcTournamentHealthRegenerated { get; private set; }

        [JsonProperty("uhc_tournament_damage_dealt")]
        public int UhcTournamentDamageDealt { get; private set; }

        [JsonProperty("uhc_tournament_melee_swings")]
        public int UhcTournamentMeleeSwings { get; private set; }

        [JsonProperty("uhc_tournament_rounds_played")]
        public int UhcTournamentRoundsPlayed { get; private set; }

        [JsonProperty("uhc_tournament_bow_hits")]
        public int UhcTournamentBowHits { get; private set; }

        [JsonProperty("uhc_tournament_bow_shots")]
        public int UhcTournamentBowShots { get; private set; }

        [JsonProperty("uhc_tournament_deaths")]
        public int UhcTournamentDeaths { get; private set; }

        [JsonProperty("uhc_tournament_kills")]
        public int UhcTournamentKills { get; private set; }

        [JsonProperty("current_uhc_winstreak")]
        public int CurrentUhcWinstreak { get; private set; }

        [JsonProperty("best_uhc_winstreak")]
        public int BestUhcWinstreak { get; private set; }

        [JsonProperty("uhc_four_health_regenerated")]
        public int UhcFourHealthRegenerated { get; private set; }

        [JsonProperty("uhc_four_melee_swings")]
        public int UhcFourMeleeSwings { get; private set; }

        [JsonProperty("uhc_four_bow_hits")]
        public int UhcFourBowHits { get; private set; }

        [JsonProperty("uhc_four_melee_hits")]
        public int UhcFourMeleeHits { get; private set; }

        [JsonProperty("uhc_four_rounds_played")]
        public int UhcFourRoundsPlayed { get; private set; }

        [JsonProperty("uhc_four_damage_dealt")]
        public int UhcFourDamageDealt { get; private set; }

        [JsonProperty("uhc_four_bow_shots")]
        public int UhcFourBowShots { get; private set; }

        [JsonProperty("uhc_tournament_losses")]
        public int UhcTournamentLosses { get; private set; }

        [JsonProperty("uhc_doubles_blocks_placed")]
        public int UhcDoublesBlocksPlaced { get; private set; }

        [JsonProperty("uhc_doubles_bow_shots")]
        public int UhcDoublesBowShots { get; private set; }

        [JsonProperty("golden_apples_eaten")]
        public int GoldenApplesEaten { get; private set; }

        [JsonProperty("uhc_doubles_rounds_played")]
        public int UhcDoublesRoundsPlayed { get; private set; }

        [JsonProperty("uhc_doubles_golden_apples_eaten")]
        public int UhcDoublesGoldenApplesEaten { get; private set; }

        [JsonProperty("uhc_doubles_melee_swings")]
        public int UhcDoublesMeleeSwings { get; private set; }

        [JsonProperty("uhc_doubles_health_regenerated")]
        public int UhcDoublesHealthRegenerated { get; private set; }

        [JsonProperty("uhc_doubles_melee_hits")]
        public int UhcDoublesMeleeHits { get; private set; }

        [JsonProperty("uhc_doubles_damage_dealt")]
        public int UhcDoublesDamageDealt { get; private set; }

        [JsonProperty("uhc_doubles_bow_hits")]
        public int UhcDoublesBowHits { get; private set; }

        [JsonProperty("uhc_four_golden_apples_eaten")]
        public int UhcFourGoldenApplesEaten { get; private set; }

        [JsonProperty("uhc_four_blocks_placed")]
        public int UhcFourBlocksPlaced { get; private set; }

        [JsonProperty("uhc_duel_blocks_placed")]
        public int UhcDuelBlocksPlaced { get; private set; }

        [JsonProperty("uhc_duel_golden_apples_eaten")]
        public int UhcDuelGoldenApplesEaten { get; private set; }

        [JsonProperty("uhc_doubles_wins")]
        public int UhcDoublesWins { get; private set; }

        [JsonProperty("duels_winstreak_best_uhc_doubles")]
        public int DuelsWinstreakBestUhcDoubles { get; private set; }

        [JsonProperty("uhc_doubles_kills")]
        public int UhcDoublesKills { get; private set; }

        [JsonProperty("current_winstreak_mode_uhc_duel")]
        public int CurrentWinstreakModeUhcDuel { get; private set; }

        [JsonProperty("best_winstreak_mode_uhc_duel")]
        public int BestWinstreakModeUhcDuel { get; private set; }

        [JsonProperty("best_winstreak_mode_uhc_doubles")]
        public int BestWinstreakModeUhcDoubles { get; private set; }

        [JsonProperty("current_winstreak_mode_uhc_doubles")]
        public int CurrentWinstreakModeUhcDoubles { get; private set; }

        [JsonProperty("uhc_doubles_deaths")]
        public int UhcDoublesDeaths { get; private set; }

        [JsonProperty("uhc_doubles_losses")]
        public int UhcDoublesLosses { get; private set; }

        [JsonProperty("uhc_duel")]
        public bool UhcDuel { get; private set; }

        [JsonProperty("uhc_doubles")]
        public bool UhcDoubles { get; private set; }

        [JsonProperty("uhc_meetup_health_regenerated")]
        public int UhcMeetupHealthRegenerated { get; private set; }

        [JsonProperty("uhc_meetup_bow_shots")]
        public int UhcMeetupBowShots { get; private set; }

        [JsonProperty("uhc_meetup_melee_hits")]
        public int UhcMeetupMeleeHits { get; private set; }

        [JsonProperty("uhc_meetup_bow_hits")]
        public int UhcMeetupBowHits { get; private set; }

        [JsonProperty("uhc_meetup_damage_dealt")]
        public int UhcMeetupDamageDealt { get; private set; }

        [JsonProperty("uhc_meetup_blocks_placed")]
        public int UhcMeetupBlocksPlaced { get; private set; }

        [JsonProperty("uhc_meetup_rounds_played")]
        public int UhcMeetupRoundsPlayed { get; private set; }

        [JsonProperty("uhc_meetup_melee_swings")]
        public int UhcMeetupMeleeSwings { get; private set; }

        [JsonProperty("current_winstreak_mode_uhc_meetup")]
        public int CurrentWinstreakModeUhcMeetup { get; private set; }

        [JsonProperty("uhc_meetup_losses")]
        public int UhcMeetupLosses { get; private set; }

        [JsonProperty("uhc_meetup_deaths")]
        public int UhcMeetupDeaths { get; private set; }

        [JsonProperty("uhc_meetup_kills")]
        public int UhcMeetupKills { get; private set; }

        [JsonProperty("duels_winstreak_uhc_duel")]
        public int DuelsWinstreakUhcDuel { get; private set; }

        [JsonProperty("uhc_four_wins")]
        public int UhcFourWins { get; private set; }

        [JsonProperty("uhc_four_kills")]
        public int UhcFourKills { get; private set; }

        [JsonProperty("uhc_four_deaths")]
        public int UhcFourDeaths { get; private set; }

        [JsonProperty("uhc_four_losses")]
        public int UhcFourLosses { get; private set; }
        #endregion

        #region skywars duels
        [JsonProperty("sw_duels_kit")]
        public string SwDuelsKit { get; private set; }

        [JsonProperty("duels_winstreak_best_sw_duel")]
        public int DuelsWinstreakBestSwDuel { get; private set; }

        [JsonProperty("duels_winstreak_sw_duel")]
        public int DuelsWinstreakSwDuel { get; private set; }

        [JsonProperty("sw_tournament_rounds_played")]
        public int SwTournamentRoundsPlayed { get; private set; }

        [JsonProperty("sw_tournament_melee_hits")]
        public int SwTournamentMeleeHits { get; private set; }

        [JsonProperty("sw_tournament_melee_swings")]
        public int SwTournamentMeleeSwings { get; private set; }

        [JsonProperty("sw_duel_damage_dealt")]
        public int SwDuelDamageDealt { get; private set; }

        [JsonProperty("sw_duel_rounds_played")]
        public int SwDuelRoundsPlayed { get; private set; }

        [JsonProperty("sw_duel_melee_hits")]
        public int SwDuelMeleeHits { get; private set; }

        [JsonProperty("sw_duel_melee_swings")]
        public int SwDuelMeleeSwings { get; private set; }

        [JsonProperty("best_skywars_winstreak")]
        public int BestSkywarsWinstreak { get; private set; }

        [JsonProperty("current_skywars_winstreak")]
        public int CurrentSkywarsWinstreak { get; private set; }

        [JsonProperty("sw_duel_champion_kit_wins")]
        public int SwDuelChampionKitWins { get; private set; }

        [JsonProperty("kit_wins")]
        public int KitWins { get; private set; }

        [JsonProperty("sw_duel_kit_wins")]
        public int SwDuelKitWins { get; private set; }

        [JsonProperty("champion_kit_wins")]
        public int ChampionKitWins { get; private set; }

        [JsonProperty("sw_duel_wins")]
        public int SwDuelWins { get; private set; }

        [JsonProperty("sw_duels_kit_new2")]
        public string SwDuelsKitNew2 { get; private set; }

        [JsonProperty("sw_duel_health_regenerated")]
        public int SwDuelHealthRegenerated { get; private set; }

        [JsonProperty("sw_duel_blocks_placed")]
        public int SwDuelBlocksPlaced { get; private set; }

        [JsonProperty("sw_duel_armorer_kit_wins")]
        public int SwDuelArmorerKitWins { get; private set; }

        [JsonProperty("sw_duel_kills")]
        public int SwDuelKills { get; private set; }

        [JsonProperty("armorer_kit_wins")]
        public int ArmorerKitWins { get; private set; }

        [JsonProperty("sw_tournament_health_regenerated")]
        public int SwTournamentHealthRegenerated { get; private set; }

        [JsonProperty("sw_tournament_damage_dealt")]
        public int SwTournamentDamageDealt { get; private set; }

        [JsonProperty("sw_duel_losses")]
        public int SwDuelLosses { get; private set; }

        [JsonProperty("sw_duel_deaths")]
        public int SwDuelDeaths { get; private set; }

        [JsonProperty("sw_duel_bow_hits")]
        public int SwDuelBowHits { get; private set; }

        [JsonProperty("scout_kit_wins")]
        public int ScoutKitWins { get; private set; }

        [JsonProperty("sw_duel_scout_kit_wins")]
        public int SwDuelScoutKitWins { get; private set; }

        [JsonProperty("sw_duel_bow_shots")]
        public int SwDuelBowShots { get; private set; }

        [JsonProperty("sw_tournament_bow_hits")]
        public int SwTournamentBowHits { get; private set; }

        [JsonProperty("sw_tournament_bow_shots")]
        public int SwTournamentBowShots { get; private set; }

        [JsonProperty("sw_duels_kit_new")]
        public string SwDuelsKitNew { get; private set; }

        [JsonProperty("skywars_rookie_title_prestige")]
        public int SkywarsRookieTitlePrestige { get; private set; }

        [JsonProperty("sw_tournament_kills")]
        public int SwTournamentKills { get; private set; }

        [JsonProperty("sw_tournament_deaths")]
        public int SwTournamentDeaths { get; private set; }

        #endregion

        #region classic duels
        [JsonProperty("duels_winstreak_best_classic_duel")]
        public int DuelsWinstreakBestClassicDuel { get; private set; }

        [JsonProperty("duels_winstreak_classic_duel")]
        public int DuelsWinstreakClassicDuel { get; private set; }

        [JsonProperty("classic_duel_rounds_played")]
        public int ClassicDuelRoundsPlayed { get; private set; }

        [JsonProperty("classic_duel_melee_hits")]
        public int ClassicDuelMeleeHits { get; private set; }

        [JsonProperty("classic_duel_health_regenerated")]
        public int ClassicDuelHealthRegenerated { get; private set; }

        [JsonProperty("classic_duel_damage_dealt")]
        public int ClassicDuelDamageDealt { get; private set; }

        [JsonProperty("classic_duel_bow_hits")]
        public int ClassicDuelBowHits { get; private set; }

        [JsonProperty("classic_duel_bow_shots")]
        public int ClassicDuelBowShots { get; private set; }

        [JsonProperty("classic_duel_melee_swings")]
        public int ClassicDuelMeleeSwings { get; private set; }

        [JsonProperty("current_classic_winstreak")]
        public int CurrentClassicWinstreak { get; private set; }

        [JsonProperty("best_classic_winstreak")]
        public int BestClassicWinstreak { get; private set; }

        [JsonProperty("classic_duel_kills")]
        public int ClassicDuelKills { get; private set; }

        [JsonProperty("classic_duel_wins")]
        public int ClassicDuelWins { get; private set; }

        [JsonProperty("classic_duel_losses")]
        public int ClassicDuelLosses { get; private set; }

        [JsonProperty("classic_duel_deaths")]
        public int ClassicDuelDeaths { get; private set; }

        [JsonProperty("best_winstreak_mode_classic_duel")]
        public int BestWinstreakModeClassicDuel { get; private set; }

        [JsonProperty("current_winstreak_mode_classic_duel")]
        public int CurrentWinstreakModeClassicDuel { get; private set; }
        #endregion

        #region mega walls duels
        [JsonProperty("mw_duels_class")]
        public string MwDuelsClass { get; private set; }

        [JsonProperty("duels_winstreak_mw_duel")]
        public int DuelsWinstreakMwDuel { get; private set; }

        [JsonProperty("duels_winstreak_best_mw_duel")]
        public int DuelsWinstreakBestMwDuel { get; private set; }

        [JsonProperty("mw_duel_melee_swings")]
        public int MwDuelMeleeSwings { get; private set; }

        [JsonProperty("mw_duel_melee_hits")]
        public int MwDuelMeleeHits { get; private set; }

        [JsonProperty("mw_duel_health_regenerated")]
        public int MwDuelHealthRegenerated { get; private set; }

        [JsonProperty("mw_duel_rounds_played")]
        public int MwDuelRoundsPlayed { get; private set; }

        [JsonProperty("mw_duel_damage_dealt")]
        public int MwDuelDamageDealt { get; private set; }

        [JsonProperty("mw_duel_bow_shots")]
        public int MwDuelBowShots { get; private set; }

        [JsonProperty("mw_duel_bow_hits")]
        public int MwDuelBowHits { get; private set; }

        [JsonProperty("current_mega_walls_winstreak")]
        public int CurrentMegaWallsWinstreak { get; private set; }

        [JsonProperty("best_mega_walls_winstreak")]
        public int BestMegaWallsWinstreak { get; private set; }

        [JsonProperty("mw_duel_herobrine_kit_wins")]
        public int MwDuelHerobrineKitWins { get; private set; }

        [JsonProperty("herobrine_kit_wins")]
        public int HerobrineKitWins { get; private set; }

        [JsonProperty("mw_duel_kit_wins")]
        public int MwDuelKitWins { get; private set; }

        [JsonProperty("mw_duel_kills")]
        public int MwDuelKills { get; private set; }

        [JsonProperty("mw_duel_wins")]
        public int MwDuelWins { get; private set; }

        [JsonProperty("mw_duel_losses")]
        public int MwDuelLosses { get; private set; }

        [JsonProperty("mw_duel_deaths")]
        public int MwDuelDeaths { get; private set; }
        #endregion

        #region bow duels
        [JsonProperty("duels_winstreak_bow_duel")]
        public int DuelsWinstreakBowDuel { get; private set; }

        [JsonProperty("duels_winstreak_best_bow_duel")]
        public int DuelsWinstreakBestBowDuel { get; private set; }

        [JsonProperty("bow_duel_bow_hits")]
        public int BowDuelBowHits { get; private set; }

        [JsonProperty("bow_duel_bow_shots")]
        public int BowDuelBowShots { get; private set; }

        [JsonProperty("bow_duel_health_regenerated")]
        public int BowDuelHealthRegenerated { get; private set; }

        [JsonProperty("bow_duel_damage_dealt")]
        public int BowDuelDamageDealt { get; private set; }

        [JsonProperty("bow_duel_rounds_played")]
        public int BowDuelRoundsPlayed { get; private set; }

        [JsonProperty("best_bow_winstreak")]
        public int BestBowWinstreak { get; private set; }

        [JsonProperty("current_bow_winstreak")]
        public int CurrentBowWinstreak { get; private set; }

        [JsonProperty("bow_duel_wins")]
        public int BowDuelWins { get; private set; }

        [JsonProperty("bow_duel_deaths")]
        public int BowDuelDeaths { get; private set; }

        [JsonProperty("bow_duel_losses")]
        public int BowDuelLosses { get; private set; }

        [JsonProperty("bow_duel_kills")]
        public int BowDuelKills { get; private set; }
        #endregion

        #region op duels
        [JsonProperty("duels_winstreak_best_op_duel")]
        public int DuelsWinstreakBestOpDuel { get; private set; }

        [JsonProperty("duels_winstreak_op_duel")]
        public int DuelsWinstreakOpDuel { get; private set; }
        #endregion

        #region combo duels
        [JsonProperty("duels_winstreak_best_combo_duel")]
        public int DuelsWinstreakBestComboDuel { get; private set; }

        [JsonProperty("duels_winstreak_combo_duel")]
        public int DuelsWinstreakComboDuel { get; private set; }

        [JsonProperty("combo_duel_melee_hits")]
        public int ComboDuelMeleeHits { get; private set; }

        [JsonProperty("combo_duel_melee_swings")]
        public int ComboDuelMeleeSwings { get; private set; }

        [JsonProperty("combo_duel_rounds_played")]
        public int ComboDuelRoundsPlayed { get; private set; }

        [JsonProperty("combo_duel_health_regenerated")]
        public int ComboDuelHealthRegenerated { get; private set; }

        [JsonProperty("combo_duel_golden_apples_eaten")]
        public int ComboDuelGoldenApplesEaten { get; private set; }

        [JsonProperty("best_combo_winstreak")]
        public int BestComboWinstreak { get; private set; }

        [JsonProperty("current_combo_winstreak")]
        public int CurrentComboWinstreak { get; private set; }

        [JsonProperty("combo_duel_wins")]
        public int ComboDuelWins { get; private set; }

        [JsonProperty("combo_duel_damage_dealt")]
        public int ComboDuelDamageDealt { get; private set; }

        [JsonProperty("combo_duel_kills")]
        public int ComboDuelKills { get; private set; }

        [JsonProperty("combo_duel_losses")]
        public int ComboDuelLosses { get; private set; }

        [JsonProperty("combo_duel_deaths")]
        public int ComboDuelDeaths { get; private set; }
        #endregion

        #region sumo
        [JsonProperty("sumo_tournament_deaths")]
        public int SumoTournamentDeaths { get; private set; }

        [JsonProperty("sumo_tournament_rounds_played")]
        public int SumoTournamentRoundsPlayed { get; private set; }

        [JsonProperty("sumo_tournament_losses")]
        public int SumoTournamentLosses { get; private set; }

        [JsonProperty("sumo_tournament_melee_hits")]
        public int SumoTournamentMeleeHits { get; private set; }

        [JsonProperty("sumo_tournament_melee_swings")]
        public int SumoTournamentMeleeSwings { get; private set; }
        #endregion

        #region bowspleef

        [JsonProperty("bowspleef_duel_rounds_played")]
        public int BowspleefDuelRoundsPlayed { get; private set; }

        #endregion

        #region bridge
        [JsonProperty("bridge_four_rounds_played")]
        public int BridgeFourRoundsPlayed { get; private set; }

        [JsonProperty("bridge_four_damage_dealt")]
        public int BridgeFourDamageDealt { get; private set; }

        [JsonProperty("bridge_four_bow_hits")]
        public int BridgeFourBowHits { get; private set; }

        [JsonProperty("bridge_four_blocks_placed")]
        public int BridgeFourBlocksPlaced { get; private set; }

        [JsonProperty("bridge_four_bow_shots")]
        public int BridgeFourBowShots { get; private set; }

        [JsonProperty("bridge_four_melee_swings")]
        public int BridgeFourMeleeSwings { get; private set; }

        [JsonProperty("bridge_four_health_regenerated")]
        public int BridgeFourHealthRegenerated { get; private set; }

        [JsonProperty("bridge_four_melee_hits")]
        public int BridgeFourMeleeHits { get; private set; }
        #endregion

        #region blitz
        [JsonProperty("blitz_duels_kit")]
        public string BlitzDuelsKit { get; private set; }

        [JsonProperty("current_blitz_winstreak")]
        public int CurrentBlitzWinstreak { get; private set; }

        [JsonProperty("best_blitz_winstreak")]
        public int BestBlitzWinstreak { get; private set; }

        [JsonProperty("blitz_duel_melee_swings")]
        public int BlitzDuelMeleeSwings { get; private set; }

        [JsonProperty("blitz_duel_damage_dealt")]
        public int BlitzDuelDamageDealt { get; private set; }

        [JsonProperty("blitz_duel_melee_hits")]
        public int BlitzDuelMeleeHits { get; private set; }

        [JsonProperty("blitz_duel_rounds_played")]
        public int BlitzDuelRoundsPlayed { get; private set; }

        [JsonProperty("blitz_duel_wins")]
        public int BlitzDuelWins { get; private set; }

        [JsonProperty("blitz_duel_health_regenerated")]
        public int BlitzDuelHealthRegenerated { get; private set; }

        [JsonProperty("blitz_duel_kills")]
        public int BlitzDuelKills { get; private set; }

        [JsonProperty("duels_winstreak_best_blitz_duel")]
        public int DuelsWinstreakBestBlitzDuel { get; private set; }

        [JsonProperty("blitz_duel_losses")]
        public int BlitzDuelLosses { get; private set; }

        [JsonProperty("blitz_duel_deaths")]
        public int BlitzDuelDeaths { get; private set; }

        [JsonProperty("blitz_duel_bow_shots")]
        public int BlitzDuelBowShots { get; private set; }

        [JsonProperty("blitz_duel_bow_hits")]
        public int BlitzDuelBowHits { get; private set; }

        [JsonProperty("blitz_duel_kit_wins")]
        public int BlitzDuelKitWins { get; private set; }

        [JsonProperty("blitz_duel_horsetamer_kit_wins")]
        public int BlitzDuelHorsetamerKitWins { get; private set; }

        [JsonProperty("horsetamer_kit_wins")]
        public int HorsetamerKitWins { get; private set; }

        [JsonProperty("blitz_duel_armorer_kit_wins")]
        public int BlitzDuelArmorerKitWins { get; private set; }

        [JsonProperty("special_challenger")]
        public bool SpecialChallenger { get; private set; }

        [JsonProperty("blitz_duel_blocks_placed")]
        public int BlitzDuelBlocksPlaced { get; private set; }

        [JsonProperty("blitz_duel")]
        public bool BlitzDuel { get; private set; }

        [JsonProperty("blitz_duel_baker_kit_wins")]
        public int BlitzDuelBakerKitWins { get; private set; }

        [JsonProperty("baker_kit_wins")]
        public int BakerKitWins { get; private set; }

        [JsonProperty("blitz_duel_necromancer_kit_wins")]
        public int BlitzDuelNecromancerKitWins { get; private set; }

        [JsonProperty("necromancer_kit_wins")]
        public int NecromancerKitWins { get; private set; }

        [JsonProperty("golem_kit_wins")]
        public int GolemKitWins { get; private set; }

        [JsonProperty("blitz_duel_golem_kit_wins")]
        public int BlitzDuelGolemKitWins { get; private set; }

        [JsonProperty("blitz_duel_fisherman_kit_wins")]
        public int BlitzDuelFishermanKitWins { get; private set; }

        [JsonProperty("fisherman_kit_wins")]
        public int FishermanKitWins { get; private set; }

        [JsonProperty("knight_kit_wins")]
        public int KnightKitWins { get; private set; }

        [JsonProperty("blitz_duel_knight_kit_wins")]
        public int BlitzDuelKnightKitWins { get; private set; }

        [JsonProperty("hunter_kit_wins")]
        public int HunterKitWins { get; private set; }

        [JsonProperty("blitz_duel_hunter_kit_wins")]
        public int BlitzDuelHunterKitWins { get; private set; }

        [JsonProperty("blitz_duel_astronaut_kit_wins")]
        public int BlitzDuelAstronautKitWins { get; private set; }

        [JsonProperty("astronaut_kit_wins")]
        public int AstronautKitWins { get; private set; }

        [JsonProperty("blitz_duel_jockey_kit_wins")]
        public int BlitzDuelJockeyKitWins { get; private set; }

        [JsonProperty("jockey_kit_wins")]
        public int JockeyKitWins { get; private set; }

        [JsonProperty("arachnologist_kit_wins")]
        public int ArachnologistKitWins { get; private set; }

        [JsonProperty("blitz_duel_arachnologist_kit_wins")]
        public int BlitzDuelArachnologistKitWins { get; private set; }

        [JsonProperty("archer_kit_wins")]
        public int ArcherKitWins { get; private set; }

        [JsonProperty("blitz_duel_archer_kit_wins")]
        public int BlitzDuelArcherKitWins { get; private set; }

        #endregion

        #region potion duel
        [JsonProperty("potion_duel_heal_pots_used")]
        public int PotionDuelHealPotsUsed { get; private set; }

        [JsonProperty("potion_duel_melee_swings")]
        public int PotionDuelMeleeSwings { get; private set; }

        [JsonProperty("potion_duel_rounds_played")]
        public int PotionDuelRoundsPlayed { get; private set; }

        [JsonProperty("potion_duel_melee_hits")]
        public int PotionDuelMeleeHits { get; private set; }

        [JsonProperty("potion_duel_health_regenerated")]
        public int PotionDuelHealthRegenerated { get; private set; }

        [JsonProperty("potion_duel_damage_dealt")]
        public int PotionDuelDamageDealt { get; private set; }

        [JsonProperty("heal_pots_used")]
        public int HealPotsUsed { get; private set; }

        [JsonProperty("potion_duel_deaths")]
        public int PotionDuelDeaths { get; private set; }

        [JsonProperty("potion_duel_losses")]
        public int PotionDuelLosses { get; private set; }

        [JsonProperty("potion_duel_kills")]
        public int PotionDuelKills { get; private set; }

        [JsonProperty("potion_duel_wins")]
        public int PotionDuelWins { get; private set; }

        [JsonProperty("duels_winstreak_best_potion_duel")]
        public int DuelsWinstreakBestPotionDuel { get; private set; }
        #endregion

        #region sumo duel
        [JsonProperty("sumo_duel_melee_swings")]
        public int SumoDuelMeleeSwings { get; private set; }

        [JsonProperty("sumo_duel_rounds_played")]
        public int SumoDuelRoundsPlayed { get; private set; }

        [JsonProperty("sumo_duel_melee_hits")]
        public int SumoDuelMeleeHits { get; private set; }

        [JsonProperty("current_sumo_winstreak")]
        public int CurrentSumoWinstreak { get; private set; }

        [JsonProperty("sumo_duel_losses")]
        public int SumoDuelLosses { get; private set; }

        [JsonProperty("sumo_duel_deaths")]
        public int SumoDuelDeaths { get; private set; }

        [JsonProperty("best_sumo_winstreak")]
        public int BestSumoWinstreak { get; private set; }

        [JsonProperty("sumo_duel_kills")]
        public int SumoDuelKills { get; private set; }

        [JsonProperty("sumo_duel_wins")]
        public int SumoDuelWins { get; private set; }

        [JsonProperty("duels_winstreak_best_sumo_duel")]
        public int DuelsWinstreakBestSumoDuel { get; private set; }

        [JsonProperty("current_winstreak_mode_sumo_duel")]
        public int CurrentWinstreakModeSumoDuel { get; private set; }
        #endregion

        #region prestige
        [JsonProperty("all_modes_diamond_title_prestige")]
        public int AllModesDiamondTitlePrestige { get; private set; }

        [JsonProperty("classic_rookie_title_prestige")]
        public int ClassicRookieTitlePrestige { get; private set; }

        [JsonProperty("op_rookie_title_prestige")]
        public int OpRookieTitlePrestige { get; private set; }

        [JsonProperty("tournament_rookie_title_prestige")]
        public int TournamentRookieTitlePrestige { get; private set; }

        [JsonProperty("combo_rookie_title_prestige")]
        public int ComboRookieTitlePrestige { get; private set; }

        [JsonProperty("sumo_rookie_title_prestige")]
        public int SumoRookieTitlePrestige { get; private set; }

        [JsonProperty("tnt_games_rookie_title_prestige")]
        public int TntGamesRookieTitlePrestige { get; private set; }

        [JsonProperty("bow_rookie_title_prestige")]
        public int BowRookieTitlePrestige { get; private set; }

        [JsonProperty("mega_walls_rookie_title_prestige")]
        public int MegaWallsRookieTitlePrestige { get; private set; }

        [JsonProperty("blitz_master_title_prestige")]
        public int BlitzMasterTitlePrestige { get; private set; }

        [JsonProperty("no_debuff_rookie_title_prestige")]
        public int NoDebuffRookieTitlePrestige { get; private set; }

        [JsonProperty("uhc_rookie_title_prestige")]
        public int UhcRookieTitlePrestige { get; private set; }

        [JsonProperty("bridge_rookie_title_prestige")]
        public int BridgeRookieTitlePrestige { get; private set; }

        [JsonProperty("all_modes_master_title_prestige")]
        public int AllModesMasterTitlePrestige { get; private set; }

        [JsonProperty("blitz_legend_title_prestige")]
        public int BlitzLegendTitlePrestige { get; private set; }

        [JsonProperty("bridge_diamond_title_prestige")]
        public int BridgeDiamondTitlePrestige { get; private set; }
        #endregion

        #region no debuff duels
        [JsonProperty("current_no_debuff_winstreak")]
        public int CurrentNoDebuffWinstreak { get; private set; }

        [JsonProperty("best_no_debuff_winstreak")]
        public int BestNoDebuffWinstreak { get; private set; }

        #endregion

        #region the bridge
        [JsonProperty("bridge_duel_wins")]
        public int BridgeDuelWins { get; private set; }

        [JsonProperty("bridge_duel_deaths")]
        public int BridgeDuelDeaths { get; private set; }

        [JsonProperty("goals")]
        public int Goals { get; private set; }

        [JsonProperty("bridge_duel_goals")]
        public int BridgeDuelGoals { get; private set; }

        [JsonProperty("bridge_duel_kills")]
        public int BridgeDuelKills { get; private set; }

        [JsonProperty("bridge_duel_rounds_played")]
        public int BridgeDuelRoundsPlayed { get; private set; }

        [JsonProperty("current_winstreak_mode_bridge_doubles")]
        public int CurrentWinstreakModeBridgeDoubles { get; private set; }

        [JsonProperty("best_bridge_winstreak")]
        public int BestBridgeWinstreak { get; private set; }

        [JsonProperty("best_winstreak_mode_bridge_doubles")]
        public int BestWinstreakModeBridgeDoubles { get; private set; }

        [JsonProperty("current_bridge_winstreak")]
        public int CurrentBridgeWinstreak { get; private set; }

        [JsonProperty("bridgeMapWins")]
        public List<string> BridgeMapWins { get; private set; }

        [JsonProperty("bridge_doubles_bridge_deaths")]
        public int BridgeDoublesBridgeDeaths { get; private set; }

        [JsonProperty("bridge_doubles_goals")]
        public int BridgeDoublesGoals { get; private set; }

        [JsonProperty("bridge_doubles_bridge_kills")]
        public int BridgeDoublesBridgeKills { get; private set; }

        [JsonProperty("bridge_doubles_blocks_placed")]
        public int BridgeDoublesBlocksPlaced { get; private set; }

        [JsonProperty("bridge_doubles_bow_shots")]
        public int BridgeDoublesBowShots { get; private set; }

        [JsonProperty("bridge_doubles_melee_hits")]
        public int BridgeDoublesMeleeHits { get; private set; }

        [JsonProperty("bridge_doubles_wins")]
        public int BridgeDoublesWins { get; private set; }

        [JsonProperty("bridge_doubles_rounds_played")]
        public int BridgeDoublesRoundsPlayed { get; private set; }

        [JsonProperty("bridge_doubles_damage_dealt")]
        public int BridgeDoublesDamageDealt { get; private set; }

        [JsonProperty("bridge_doubles_health_regenerated")]
        public int BridgeDoublesHealthRegenerated { get; private set; }

        [JsonProperty("bridge_doubles_melee_swings")]
        public int BridgeDoublesMeleeSwings { get; private set; }

        [JsonProperty("bridge_doubles_bow_hits")]
        public int BridgeDoublesBowHits { get; private set; }

        [JsonProperty("bridge_kills")]
        public int BridgeKills { get; private set; }

        [JsonProperty("bridge_deaths")]
        public int BridgeDeaths { get; private set; }

        [JsonProperty("duels_winstreak_best_bridge_doubles")]
        public int DuelsWinstreakBestBridgeDoubles { get; private set; }

        [JsonProperty("best_winstreak_mode_bridge_four")]
        public int BestWinstreakModeBridgeFour { get; private set; }

        [JsonProperty("current_winstreak_mode_bridge_four")]
        public int CurrentWinstreakModeBridgeFour { get; private set; }

        [JsonProperty("bridge_four_bridge_deaths")]
        public int BridgeFourBridgeDeaths { get; private set; }

        [JsonProperty("bridge_four_bridge_kills")]
        public int BridgeFourBridgeKills { get; private set; }

        [JsonProperty("bridge_four_goals")]
        public int BridgeFourGoals { get; private set; }

        [JsonProperty("bridge_four_wins")]
        public int BridgeFourWins { get; private set; }

        [JsonProperty("duels_winstreak_best_bridge_four")]
        public int DuelsWinstreakBestBridgeFour { get; private set; }

        [JsonProperty("leaderboardPage_goals")]
        public int LeaderboardPageGoals { get; private set; }

        [JsonProperty("leaderboardPage_win_streak")]
        public int LeaderboardPageWinStreak { get; private set; }

        [JsonProperty("leaderboardPage_wins")]
        public int LeaderboardPageWins { get; private set; }

        [JsonProperty("bridge_four_losses")]
        public int BridgeFourLosses { get; private set; }

        [JsonProperty("current_winstreak_mode_bridge_duel")]
        public int CurrentWinstreakModeBridgeDuel { get; private set; }

        [JsonProperty("bridge_duel_health_regenerated")]
        public int BridgeDuelHealthRegenerated { get; private set; }

        [JsonProperty("bridge_duel_damage_dealt")]
        public int BridgeDuelDamageDealt { get; private set; }

        [JsonProperty("bridge_duel_melee_swings")]
        public int BridgeDuelMeleeSwings { get; private set; }

        [JsonProperty("bridge_duel_bow_hits")]
        public int BridgeDuelBowHits { get; private set; }

        [JsonProperty("bridge_duel_losses")]
        public int BridgeDuelLosses { get; private set; }

        [JsonProperty("bridge_duel_bridge_deaths")]
        public int BridgeDuelBridgeDeaths { get; private set; }

        [JsonProperty("bridge_duel_bridge_kills")]
        public int BridgeDuelBridgeKills { get; private set; }

        [JsonProperty("bridge_duel_melee_hits")]
        public int BridgeDuelMeleeHits { get; private set; }

        [JsonProperty("bridge_duel_blocks_placed")]
        public int BridgeDuelBlocksPlaced { get; private set; }

        [JsonProperty("bridge_duel_bow_shots")]
        public int BridgeDuelBowShots { get; private set; }

        [JsonProperty("best_winstreak_mode_bridge_duel")]
        public int BestWinstreakModeBridgeDuel { get; private set; }

        [JsonProperty("duels_winstreak_best_bridge_duel")]
        public int DuelsWinstreakBestBridgeDuel { get; private set; }

        [JsonProperty("bridge_iron_title_prestige")]
        public int BridgeIronTitlePrestige { get; private set; }

        [JsonProperty("bridge_doubles_losses")]
        public int BridgeDoublesLosses { get; private set; }

        [JsonProperty("best_winstreak_mode_bridge_2v2v2v2")]
        public int BestWinstreakModeBridge2V2V2V2 { get; private set; }

        [JsonProperty("current_winstreak_mode_bridge_2v2v2v2")]
        public int CurrentWinstreakModeBridge2V2V2V2 { get; private set; }

        [JsonProperty("bridge_2v2v2v2_goals")]
        public int Bridge2V2V2V2Goals { get; private set; }

        [JsonProperty("bridge_2v2v2v2_health_regenerated")]
        public int Bridge2V2V2V2HealthRegenerated { get; private set; }

        [JsonProperty("bridge_2v2v2v2_blocks_placed")]
        public int Bridge2V2V2V2BlocksPlaced { get; private set; }

        [JsonProperty("bridge_2v2v2v2_rounds_played")]
        public int Bridge2V2V2V2RoundsPlayed { get; private set; }

        [JsonProperty("bridge_2v2v2v2_melee_swings")]
        public int Bridge2V2V2V2MeleeSwings { get; private set; }

        [JsonProperty("bridge_2v2v2v2_bridge_deaths")]
        public int Bridge2V2V2V2BridgeDeaths { get; private set; }

        [JsonProperty("bridge_2v2v2v2_wins")]
        public int Bridge2V2V2V2Wins { get; private set; }

        [JsonProperty("bridge_2v2v2v2_melee_hits")]
        public int Bridge2V2V2V2MeleeHits { get; private set; }

        [JsonProperty("bridge_2v2v2v2_bridge_kills")]
        public int Bridge2V2V2V2BridgeKills { get; private set; }

        [JsonProperty("bridge_2v2v2v2_damage_dealt")]
        public int Bridge2V2V2V2DamageDealt { get; private set; }

        [JsonProperty("duels_winstreak_best_bridge_2v2v2v2")]
        public int DuelsWinstreakBestBridge2V2V2V2 { get; private set; }

        [JsonProperty("bridge_2v2v2v2_losses")]
        public int Bridge2V2V2V2Losses { get; private set; }

        [JsonProperty("current_winstreak_mode_bridge_3v3v3v3")]
        public int CurrentWinstreakModeBridge3V3V3V3 { get; private set; }

        [JsonProperty("best_winstreak_mode_bridge_3v3v3v3")]
        public int BestWinstreakModeBridge3V3V3V3 { get; private set; }

        [JsonProperty("bridge_3v3v3v3_blocks_placed")]
        public int Bridge3V3V3V3BlocksPlaced { get; private set; }

        [JsonProperty("bridge_3v3v3v3_goals")]
        public int Bridge3V3V3V3Goals { get; private set; }

        [JsonProperty("bridge_3v3v3v3_rounds_played")]
        public int Bridge3V3V3V3RoundsPlayed { get; private set; }

        [JsonProperty("bridge_3v3v3v3_health_regenerated")]
        public int Bridge3V3V3V3HealthRegenerated { get; private set; }

        [JsonProperty("bridge_3v3v3v3_wins")]
        public int Bridge3V3V3V3Wins { get; private set; }

        [JsonProperty("duels_winstreak_best_bridge_3v3v3v3")]
        public int DuelsWinstreakBestBridge3V3V3V3 { get; private set; }

        [JsonProperty("bridge_3v3v3v3_melee_hits")]
        public int Bridge3V3V3V3MeleeHits { get; private set; }

        [JsonProperty("bridge_3v3v3v3_melee_swings")]
        public int Bridge3V3V3V3MeleeSwings { get; private set; }

        [JsonProperty("bridge_3v3v3v3_bridge_deaths")]
        public int Bridge3V3V3V3BridgeDeaths { get; private set; }

        [JsonProperty("bridge_3v3v3v3_bridge_kills")]
        public int Bridge3V3V3V3BridgeKills { get; private set; }

        [JsonProperty("bridge_3v3v3v3_damage_dealt")]
        public int Bridge3V3V3V3DamageDealt { get; private set; }

        [JsonProperty("bridge_3v3v3v3_losses")]
        public int Bridge3V3V3V3Losses { get; private set; }

        [JsonProperty("bridge_3v3v3v3_bow_shots")]
        public int Bridge3V3V3V3BowShots { get; private set; }

        [JsonProperty("bridge_gold_title_prestige")]
        public int BridgeGoldTitlePrestige { get; private set; }

        [JsonProperty("bridge_2v2v2v2_bow_shots")]
        public int Bridge2V2V2V2BowShots { get; private set; }

        [JsonProperty("bridge_2v2v2v2_bow_hits")]
        public int Bridge2V2V2V2BowHits { get; private set; }

        [JsonProperty("bridge_3v3v3v3_bow_hits")]
        public int Bridge3V3V3V3BowHits { get; private set; }
        #endregion

        #region op duels
        [JsonProperty("op_duel_health_regenerated")]
        public int OpDuelHealthRegenerated { get; private set; }

        [JsonProperty("op_duel_damage_dealt")]
        public int OpDuelDamageDealt { get; private set; }

        [JsonProperty("op_duel_rounds_played")]
        public int OpDuelRoundsPlayed { get; private set; }

        [JsonProperty("op_duel_melee_swings")]
        public int OpDuelMeleeSwings { get; private set; }

        [JsonProperty("op_duel_melee_hits")]
        public int OpDuelMeleeHits { get; private set; }
        #endregion
    }
}