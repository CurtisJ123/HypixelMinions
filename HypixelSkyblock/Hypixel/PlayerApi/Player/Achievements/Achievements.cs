using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Achievements
{
    public class Achievements
    {
        [JsonProperty("arena_bossed")]
        public int ArenaBossed { get; private set; }

        [JsonProperty("arena_climb_the_ranks")]
        public int ArenaClimbTheRanks { get; private set; }

        [JsonProperty("arena_gladiator")]
        public int ArenaGladiator { get; private set; }

        [JsonProperty("arena_gotta_wear_em_all")]
        public int ArenaGottaWearEmAll { get; private set; }

        [JsonProperty("blitz_coins")]
        public int BlitzCoins { get; private set; }

        [JsonProperty("blitz_kills")]
        public int BlitzKills { get; private set; }

        [JsonProperty("general_coins")]
        public int GeneralCoins { get; private set; }

        [JsonProperty("general_wins")]
        public int GeneralWins { get; private set; }

        [JsonProperty("quake_killing_sprees")]
        public int QuakeKillingSprees { get; private set; }

        [JsonProperty("quake_kills")]
        public int QuakeKills { get; private set; }

        [JsonProperty("quake_wins")]
        public int QuakeWins { get; private set; }

        [JsonProperty("tntgames_bow_spleef_wins")]
        public int TntgamesBowSpleefWins { get; private set; }

        [JsonProperty("tntgames_tnt_run_wins")]
        public int TntgamesTntRunWins { get; private set; }

        [JsonProperty("tntgames_wizards_wins")]
        public int TntgamesWizardsWins { get; private set; }

        [JsonProperty("vampirez_coins")]
        public int VampirezCoins { get; private set; }

        [JsonProperty("vampirez_kill_survivors")]
        public int VampirezKillSurvivors { get; private set; }

        [JsonProperty("vampirez_kill_vampires")]
        public int VampirezKillVampires { get; private set; }

        [JsonProperty("vampirez_survivor_wins")]
        public int VampirezSurvivorWins { get; private set; }

        [JsonProperty("walls3_coins")]
        public int Walls3Coins { get; private set; }

        [JsonProperty("walls3_kills")]
        public int Walls3Kills { get; private set; }

        [JsonProperty("walls3_wins")]
        public int Walls3Wins { get; private set; }

        [JsonProperty("walls_coins")]
        public int WallsCoins { get; private set; }

        [JsonProperty("walls_kills")]
        public int WallsKills { get; private set; }

        [JsonProperty("walls_wins")]
        public int WallsWins { get; private set; }

        [JsonProperty("uhc_champion")]
        public int UhcChampion { get; private set; }

        [JsonProperty("uhc_hunter")]
        public int UhcHunter { get; private set; }

        [JsonProperty("uhc_moving_up")]
        public int UhcMovingUp { get; private set; }

        [JsonProperty("paintball_kills")]
        public int PaintballKills { get; private set; }

        [JsonProperty("paintball_coins")]
        public int PaintballCoins { get; private set; }

        [JsonProperty("skywars_kills_team")]
        public int SkywarsKillsTeam { get; private set; }

        [JsonProperty("skywars_kills_solo")]
        public int SkywarsKillsSolo { get; private set; }

        [JsonProperty("skywars_wins_solo")]
        public int SkywarsWinsSolo { get; private set; }

        [JsonProperty("skywars_kits_solo")]
        public int SkywarsKitsSolo { get; private set; }

        [JsonProperty("skywars_wins_team")]
        public int SkywarsWinsTeam { get; private set; }

        [JsonProperty("skywars_cages")]
        public int SkywarsCages { get; private set; }

        [JsonProperty("skywars_kits_team")]
        public int SkywarsKitsTeam { get; private set; }

        [JsonProperty("truecombat_kit_hoarder_solo")]
        public int TruecombatKitHoarderSolo { get; private set; }

        [JsonProperty("truecombat_kit_hoarder_team")]
        public int TruecombatKitHoarderTeam { get; private set; }

        [JsonProperty("walls3_guardian")]
        public int Walls3Guardian { get; private set; }

        [JsonProperty("skywars_kills_mega")]
        public int SkywarsKillsMega { get; private set; }

        [JsonProperty("skywars_kits_mega")]
        public int SkywarsKitsMega { get; private set; }

        [JsonProperty("skywars_wins_mega")]
        public int SkywarsWinsMega { get; private set; }

        [JsonProperty("warlords_warrior_level")]
        public int WarlordsWarriorLevel { get; private set; }

        [JsonProperty("warlords_shaman_level")]
        public int WarlordsShamanLevel { get; private set; }

        [JsonProperty("warlords_mage_level")]
        public int WarlordsMageLevel { get; private set; }

        [JsonProperty("warlords_paladin_level")]
        public int WarlordsPaladinLevel { get; private set; }

        [JsonProperty("copsandcrims_bomb_specialist")]
        public int CopsandCrimsBombSpecialist { get; private set; }

        [JsonProperty("general_challenger")]
        public int GeneralChallenger { get; private set; }

        [JsonProperty("general_quest_master")]
        public int GeneralQuestMaster { get; private set; }

        [JsonProperty("speeduhc_hunter")]
        public int SpeeduhcHunter { get; private set; }

        [JsonProperty("skyclash_cards_unlocked")]
        public int SkyclashCardsUnlocked { get; private set; }

        [JsonProperty("skyclash_kills")]
        public int SkyclashKills { get; private set; }

        [JsonProperty("skyclash_packs_opened")]
        public int SkyclashPacksOpened { get; private set; }

        [JsonProperty("truecombat_solo_killer")]
        public int TruecombatSoloKiller { get; private set; }

        [JsonProperty("skyclash_wins")]
        public int SkyclashWins { get; private set; }

        [JsonProperty("paintball_wins")]
        public int PaintballWins { get; private set; }

        [JsonProperty("truecombat_team_killer")]
        public int TruecombatTeamKiller { get; private set; }

        [JsonProperty("arcade_miniwalls_winner")]
        public int ArcadeMiniwallsWinner { get; private set; }

        [JsonProperty("arcade_team_work")]
        public int ArcadeTeamWork { get; private set; }

        [JsonProperty("arcade_arcade_winner")]
        public int ArcadeArcadeWinner { get; private set; }

        [JsonProperty("arcade_arcade_banker")]
        public int ArcadeArcadeBanker { get; private set; }

        [JsonProperty("skyclash_treasure_hunter")]
        public int SkyclashTreasureHunter { get; private set; }

        [JsonProperty("skyclash_mob_beheading")]
        public int SkyclashMobBeheading { get; private set; }

        [JsonProperty("tntgames_tnt_tag_wins")]
        public int TntgamesTntTagWins { get; private set; }

        [JsonProperty("tntgames_pvp_run_killer")]
        public int TntgamesPvpRunKiller { get; private set; }

        [JsonProperty("tntgames_pvp_run_wins")]
        public int TntgamesPvpRunWins { get; private set; }

        [JsonProperty("tntgames_tnt_wizards_kills")]
        public int TntgamesTntWizardsKills { get; private set; }

        [JsonProperty("tntgames_tnt_triathlon")]
        public int TntgamesTntTriathlon { get; private set; }

        [JsonProperty("tntgames_tnt_banker")]
        public int TntgamesTntBanker { get; private set; }

        [JsonProperty("uhc_bounty")]
        public int UhcBounty { get; private set; }

        [JsonProperty("gingerbread_banker")]
        public int GingerbreadBanker { get; private set; }

        [JsonProperty("vampirez_zombie_killer")]
        public int VampirezZombieKiller { get; private set; }

        [JsonProperty("quake_coins")]
        public int QuakeCoins { get; private set; }

        [JsonProperty("quake_headshots")]
        public int QuakeHeadshots { get; private set; }

        [JsonProperty("tntgames_tnt_wizards_caps")]
        public int TntgamesTntWizardsCaps { get; private set; }

        [JsonProperty("truecombat_team_winner")]
        public int TruecombatTeamWinner { get; private set; }

        [JsonProperty("blitz_wins_teams")]
        public int BlitzWinsTeams { get; private set; }

        [JsonProperty("blitz_war_veteran")]
        public int BlitzWarVeteran { get; private set; }

        [JsonProperty("blitz_wins")]
        public int BlitzWins { get; private set; }

        [JsonProperty("blitz_looter")]
        public int BlitzLooter { get; private set; }

        [JsonProperty("blitz_treasure_seeker")]
        public int BlitzTreasureSeeker { get; private set; }

        [JsonProperty("bedwars_wins")]
        public int BedwarsWins { get; private set; }

        [JsonProperty("bedwars_beds")]
        public int BedwarsBeds { get; private set; }

        [JsonProperty("bedwars_level")]
        public int BedwarsLevel { get; private set; }

        [JsonProperty("bedwars_loot_box")]
        public int BedwarsLootBox { get; private set; }

        [JsonProperty("gingerbread_racer")]
        public int GingerbreadRacer { get; private set; }

        [JsonProperty("gingerbread_winner")]
        public int GingerbreadWinner { get; private set; }

        [JsonProperty("murdermystery_wins_as_survivor")]
        public int MurdermysteryWinsAsSurvivor { get; private set; }

        [JsonProperty("arcade_football_pro")]
        public int ArcadeFootballPro { get; private set; }

        [JsonProperty("truecombat_king")]
        public int TruecombatKing { get; private set; }

        [JsonProperty("murdermystery_kills_as_murderer")]
        public int MurdermysteryKillsAsMurderer { get; private set; }

        [JsonProperty("arcade_bounty_hunter")]
        public int ArcadeBountyHunter { get; private set; }

        [JsonProperty("copsandcrims_serial_killer")]
        public int CopsandCrimsSerialKiller { get; private set; }

        [JsonProperty("copsandcrims_hero_terrorist")]
        public int CopsandcrimsHeroTerrorist { get; private set; }

        [JsonProperty("buildbattle_build_battle_points")]
        public int BuildbattleBuildBattlePoints { get; private set; }

        [JsonProperty("buildbattle_build_battle_voter")]
        public int BuildbattleBuildBattleVoter { get; private set; }

        [JsonProperty("buildbattle_build_battle_score")]
        public int BuildbattleBuildBattleScore { get; private set; }

        [JsonProperty("buildbattle_guess_the_build_guesses")]
        public int BuildbattleGuessTheBuildGuesses { get; private set; }

        [JsonProperty("buildbattle_guess_the_build_winner")]
        public int BuildbattleGuessTheBuildWinner { get; private set; }

        [JsonProperty("duels_duels_winner")]
        public int DuelsDuelsWinner { get; private set; }

        [JsonProperty("duels_duels_win_streak")]
        public int DuelsDuelsWinStreak { get; private set; }

        [JsonProperty("murdermystery_wins_as_murderer")]
        public int MurdermysteryWinsAsMurderer { get; private set; }

        [JsonProperty("skywars_wins_lab")]
        public int SkywarsWinsLab { get; private set; }

        [JsonProperty("arcade_farmhunt_dominator")]
        public int ArcadeFarmhuntDominator { get; private set; }

        [JsonProperty("bedwars_bedwars_killer")]
        public int BedwarsBedwarsKiller { get; private set; }

        [JsonProperty("bedwars_collectors_edition")]
        public int BedwarsCollectorsEdition { get; private set; }

        [JsonProperty("truecombat_feels_lucky")]
        public int TruecombatFeelsLucky { get; private set; }

        [JsonProperty("truecombat_solo_winner")]
        public int TruecombatSoloWinner { get; private set; }

        [JsonProperty("tntgames_clinic")]
        public int TntgamesClinic { get; private set; }

        [JsonProperty("murdermystery_hoarder")]
        public int MurdermysteryHoarder { get; private set; }

        [JsonProperty("duels_duels_traveller")]
        public int DuelsDuelsTraveller { get; private set; }

        [JsonProperty("paintball_kill_streaks")]
        public int PaintballKillStreaks { get; private set; }

        [JsonProperty("gingerbread_mystery")]
        public int GingerbreadMystery { get; private set; }

        [JsonProperty("skywars_heads")]
        public int SkywarsHeads { get; private set; }

        [JsonProperty("copsandcrims_cac_banker")]
        public int CopsandcrimsCacBanker { get; private set; }

        [JsonProperty("warlords_ctf_objective")]
        public int WarlordsCtfObjective { get; private set; }

        [JsonProperty("warlords_assist")]
        public int WarlordsAssist { get; private set; }

        [JsonProperty("warlords_coins")]
        public int WarlordsCoins { get; private set; }

        [JsonProperty("warlords_kills")]
        public int WarlordsKills { get; private set; }

        [JsonProperty("warlords_ctf_wins")]
        public int WarlordsCtfWins { get; private set; }
    }
}