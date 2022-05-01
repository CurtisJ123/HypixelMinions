using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Arcade
    {
        #region general
        [JsonProperty("coins")]
        public string Coins { get; private set; }
        #endregion

        #region creeper attack

        [JsonProperty("max_wave")]
        public int MaxWave { get; private set; }

        #endregion

        #region hypixel says/santa says

        [JsonProperty("rounds_santa_says")]
        public int RoundsSantaSays { get; private set; }

        [JsonProperty("rounds_simon_says")]
        public int SimonSaysRounds { get; private set; }

        [JsonProperty("wins_simon_says")]
        public int SimonSaysWins { get; private set; }

        #endregion

        #region dragonwars

        [JsonProperty("kills_dragonwars2")]
        public int Dragonwars2Kills { get; private set; }

        [JsonProperty("wins_dragonwars2")]
        public int Dragonwars2Wins { get; private set; }

        #endregion

        #region hole in the wall

        [JsonProperty("hitw_record_q")]
        public int HoleInTheWallRecordQualifier { get; private set; }

        [JsonProperty("hitw_record_f")]
        public int HoleInTheWallRecordFinalScore { get; private set; }

        [JsonProperty("rounds_hole_in_the_wall")]
        public int RoundsHoleInTheWall { get; private set; }

        [JsonProperty("wins_hole_in_the_wall")]
        public long WinsHoleInTheWall { get; private set; }

        #endregion

        #region farmhunt

        [JsonProperty("poop_collected")]
        public int PoopCollected { get; private set; }

        [JsonProperty("wins_farm_hunt")]
        public long WinsFarmHunt { get; private set; }

        #endregion
        
        #region galaxy wars

        [JsonProperty("sw_kills")]
        public int GalaxyWarsKills { get; private set; }

        [JsonProperty("sw_shots_fired")]
        public int GalaxyWarsShotsFired{ get; private set; }

        [JsonProperty("sw_rebel_kills")]
        public int GalaxyWarsRebelKills { get; private set; }

        [JsonProperty("sw_deaths")]
        public int GalaxyWarsDeaths { get; private set; }

        [JsonProperty("sw_empire_kills")]
        public int GalaxyWarsEmpireKills { get; private set; }


        #endregion

        #region partygames

        [JsonProperty("wins_party")]
        public int PartyGamesWins { get; private set; }

        #endregion

        #region miniwalls
        [JsonProperty("miniwalls_activeKit")]
        public string MiniwallsActiveKit { get; private set; }

        [JsonProperty("arrows_hit_mini_walls")]
        public int ArrowsHitMiniWalls { get; private set; }

        [JsonProperty("final_kills_mini_walls")]
        public int FinalKillsMiniWalls { get; private set; }

        [JsonProperty("kills_mini_walls")]
        public int KillsMiniWalls { get; private set; }

        [JsonProperty("wins_mini_walls")]
        public int WinsMiniWalls { get; private set; }

        [JsonProperty("wither_kills_mini_walls")]
        public int WitherKillsMiniWalls { get; private set; }

        [JsonProperty("deaths_mini_walls")]
        public int DeathsMiniWalls { get; private set; }

        [JsonProperty("arrows_shot_mini_walls")]
        public int ArrowsShotMiniWalls { get; private set; }

        [JsonProperty("wither_damage_mini_walls")]
        public int WitherDamageMiniWalls { get; private set; }
        #endregion

        #region soccer

        [JsonProperty("powerkicks_soccer")]
        public long SoccerPowerkicks { get; private set; }

        [JsonProperty("goals_soccer")]
        public long SoccerGoals { get; private set; }

        [JsonProperty("wins_soccer")]
        public long SoccerWins { get; private set; }

        [JsonProperty("kicks_soccer")]
        public long KicksSoccer { get; private set; }

        #endregion

        #region throwout
        [JsonProperty("kills_throw_out")]
        public int ThrowOutKills { get; private set; }

        [JsonProperty("deaths_throw_out")]
        public int ThrowOutDeaths { get; private set; }
        #endregion

        #region bounty hunters

        [JsonProperty("kills_oneinthequiver")]
        public long BountyHunterKills { get; private set; }

        [JsonProperty("bounty_kills_oneinthequiver")]
        public long BountyHunterBountyKills { get; private set; }

        [JsonProperty("deaths_oneinthequiver")]
        public long BountyHunterDeaths { get; private set; }

        #endregion

        #region zombies
        [JsonProperty("headshots_dayone")]
        public long HeadshotsDayone { get; private set; }

        [JsonProperty("kills_dayone")]
        public long KillsDayone { get; private set; }

        [JsonProperty("wins_dayone")]
        public long WinsDayone { get; private set; }

        [JsonProperty("fastest_time_10_zombies_deadend_normal")]
        public long FastestTime10_ZombiesDeadendNormal { get; private set; }

        [JsonProperty("best_round_zombies")]
        public long BestRoundZombies { get; private set; }

        [JsonProperty("fastest_time_10_zombies")]
        public long FastestTime10_Zombies { get; private set; }

        [JsonProperty("players_revived_zombies")]
        public long PlayersRevivedZombies { get; private set; }

        [JsonProperty("headshots_zombies")]
        public long HeadshotsZombies { get; private set; }

        [JsonProperty("deaths_zombies")]
        public long DeathsZombies { get; private set; }

        [JsonProperty("bullets_shot_zombies")]
        public long BulletsShotZombies { get; private set; }

        [JsonProperty("times_knocked_down_zombies")]
        public long TimesKnockedDownZombies { get; private set; }

        [JsonProperty("doors_opened_zombies")]
        public long DoorsOpenedZombies { get; private set; }

        [JsonProperty("zombie_kills_zombies")]
        public long ZombieKillsZombies { get; private set; }

        [JsonProperty("bullets_hit_zombies")]
        public long BulletsHitZombies { get; private set; }

        [JsonProperty("best_round_zombies_deadend")]
        public long BestRoundZombiesDeadend { get; private set; }

        [JsonProperty("best_round_zombies_deadend_rip")]
        public long BestRoundZombiesDeadendRip { get; private set; }

        [JsonProperty("deaths_zombies_deadend_rip")]
        public long DeathsZombiesDeadendRip { get; private set; }

        [JsonProperty("zombie_kills_zombies_deadend")]
        public long ZombieKillsZombiesDeadend { get; private set; }

        [JsonProperty("total_rounds_survived_zombies_deadend")]
        public long TotalRoundsSurvivedZombiesDeadend { get; private set; }

        [JsonProperty("total_rounds_survived_zombies_deadend_rip")]
        public long TotalRoundsSurvivedZombiesDeadendRip { get; private set; }

        [JsonProperty("windows_repaired_zombies_deadend_rip")]
        public long WindowsRepairedZombiesDeadendRip { get; private set; }

        [JsonProperty("total_rounds_survived_zombies")]
        public long TotalRoundsSurvivedZombies { get; private set; }

        [JsonProperty("windows_repaired_zombies")]
        public long WindowsRepairedZombies { get; private set; }

        [JsonProperty("deaths_zombies_deadend")]
        public long DeathsZombiesDeadend { get; private set; }

        [JsonProperty("times_knocked_down_zombies_deadend_rip")]
        public long TimesKnockedDownZombiesDeadendRip { get; private set; }

        [JsonProperty("zombie_kills_zombies_deadend_rip")]
        public long ZombieKillsZombiesDeadendRip { get; private set; }

        [JsonProperty("basic_zombie_kills_zombies")]
        public long BasicZombieKillsZombies { get; private set; }

        [JsonProperty("times_knocked_down_zombies_deadend")]
        public long TimesKnockedDownZombiesDeadend { get; private set; }

        [JsonProperty("windows_repaired_zombies_deadend")]
        public long WindowsRepairedZombiesDeadend { get; private set; }

        [JsonProperty("best_round_zombies_deadend_normal")]
        public long BestRoundZombiesDeadendNormal { get; private set; }

        [JsonProperty("total_rounds_survived_zombies_deadend_normal")]
        public long TotalRoundsSurvivedZombiesDeadendNormal { get; private set; }

        [JsonProperty("magma_cube_zombie_kills_zombies")]
        public long MagmaCubeZombieKillsZombies { get; private set; }

        [JsonProperty("players_revived_zombies_deadend_normal")]
        public long PlayersRevivedZombiesDeadendNormal { get; private set; }

        [JsonProperty("zombie_kills_zombies_deadend_normal")]
        public long ZombieKillsZombiesDeadendNormal { get; private set; }

        [JsonProperty("times_knocked_down_zombies_deadend_normal")]
        public long TimesKnockedDownZombiesDeadendNormal { get; private set; }

        [JsonProperty("deaths_zombies_deadend_normal")]
        public long DeathsZombiesDeadendNormal { get; private set; }

        [JsonProperty("blaze_zombie_kills_zombies")]
        public long BlazeZombieKillsZombies { get; private set; }

        [JsonProperty("tnt_baby_zombie_kills_zombies")]
        public long TntBabyZombieKillsZombies { get; private set; }

        [JsonProperty("doors_opened_zombies_deadend_normal")]
        public long DoorsOpenedZombiesDeadendNormal { get; private set; }

        [JsonProperty("magma_zombie_kills_zombies")]
        public long MagmaZombieKillsZombies { get; private set; }

        [JsonProperty("fire_zombie_kills_zombies")]
        public long FireZombieKillsZombies { get; private set; }

        [JsonProperty("wolf_zombie_kills_zombies")]
        public long WolfZombieKillsZombies { get; private set; }

        [JsonProperty("pig_zombie_zombie_kills_zombies")]
        public long PigZombieZombieKillsZombies { get; private set; }

        [JsonProperty("windows_repaired_zombies_deadend_normal")]
        public long WindowsRepairedZombiesDeadendNormal { get; private set; }

        [JsonProperty("empowered_zombie_kills_zombies")]
        public long EmpoweredZombieKillsZombies { get; private set; }

        [JsonProperty("doors_opened_zombies_deadend")]
        public long DoorsOpenedZombiesDeadend { get; private set; }

        [JsonProperty("players_revived_zombies_deadend")]
        public long PlayersRevivedZombiesDeadend { get; private set; }

        [JsonProperty("zombies_hideTutorials")]
        public bool ZombiesHideTutorials { get; private set; }

        [JsonProperty("fastest_time_20_zombies")]
        public long FastestTime20_Zombies { get; private set; }

        [JsonProperty("fastest_time_20_zombies_deadend_normal")]
        public long FastestTime20_ZombiesDeadendNormal { get; private set; }

        [JsonProperty("skelefish_zombie_kills_zombies")]
        public long SkelefishZombieKillsZombies { get; private set; }

        [JsonProperty("guardian_zombie_kills_zombies")]
        public long GuardianZombieKillsZombies { get; private set; }

        [JsonProperty("tnt_zombie_kills_zombies")]
        public long TntZombieKillsZombies { get; private set; }

        [JsonProperty("silverfish_zombie_kills_zombies")]
        public long SilverfishZombieKillsZombies { get; private set; }

        [JsonProperty("endermite_zombie_kills_zombies")]
        public long EndermiteZombieKillsZombies { get; private set; }

        [JsonProperty("inferno_zombie_kills_zombies")]
        public long InfernoZombieKillsZombies { get; private set; }

        [JsonProperty("ender_zombie_kills_zombies")]
        public long EnderZombieKillsZombies { get; private set; }

        [JsonProperty("fastest_time_30_zombies")]
        public long FastestTime30_Zombies { get; private set; }

        [JsonProperty("fastest_time_30_zombies_deadend_normal")]
        public long FastestTime30_ZombiesDeadendNormal { get; private set; }

        [JsonProperty("wins_zombies")]
        public long WinsZombies { get; private set; }

        [JsonProperty("wins_zombies_deadend")]
        public long WinsZombiesDeadend { get; private set; }

        [JsonProperty("wins_zombies_deadend_normal")]
        public long WinsZombiesDeadendNormal { get; private set; }

        [JsonProperty("windows_repaired_zombies_alienarcadium")]
        public long WindowsRepairedZombiesAlienarcadium { get; private set; }

        [JsonProperty("total_rounds_survived_zombies_alienarcadium")]
        public long TotalRoundsSurvivedZombiesAlienarcadium { get; private set; }

        [JsonProperty("zombie_kills_zombies_alienarcadium")]
        public long ZombieKillsZombiesAlienarcadium { get; private set; }

        [JsonProperty("skeleton_zombie_kills_zombies")]
        public long SkeletonZombieKillsZombies { get; private set; }

        [JsonProperty("deaths_zombies_alienarcadium")]
        public long DeathsZombiesAlienarcadium { get; private set; }

        [JsonProperty("rainbow_zombie_kills_zombies")]
        public long RainbowZombieKillsZombies { get; private set; }

        [JsonProperty("giant_zombie_kills_zombies")]
        public long GiantZombieKillsZombies { get; private set; }

        [JsonProperty("space_blaster_zombie_kills_zombies")]
        public long SpaceBlasterZombieKillsZombies { get; private set; }

        [JsonProperty("chgluglu_zombie_kills_zombies")]
        public long ChglugluZombieKillsZombies { get; private set; }

        [JsonProperty("times_knocked_down_zombies_alienarcadium")]
        public long TimesKnockedDownZombiesAlienarcadium { get; private set; }

        [JsonProperty("ghast_zombie_kills_zombies")]
        public long GhastZombieKillsZombies { get; private set; }

        [JsonProperty("worm_small_zombie_kills_zombies")]
        public long WormSmallZombieKillsZombies { get; private set; }

        [JsonProperty("worm_zombie_kills_zombies")]
        public long WormZombieKillsZombies { get; private set; }

        [JsonProperty("sentinel_zombie_kills_zombies")]
        public long SentinelZombieKillsZombies { get; private set; }

        [JsonProperty("space_grunt_zombie_kills_zombies")]
        public long SpaceGruntZombieKillsZombies { get; private set; }

        [JsonProperty("blob_zombie_kills_zombies")]
        public long BlobZombieKillsZombies { get; private set; }

        [JsonProperty("clown_zombie_kills_zombies")]
        public long ClownZombieKillsZombies { get; private set; }

        [JsonProperty("prop_hunt_hider_wins_hide_and_seek")]
        public long PropHuntHiderWinsHideAndSeek { get; private set; }

        [JsonProperty("best_round_zombies_alienarcadium")]
        public long BestRoundZombiesAlienarcadium { get; private set; }

        [JsonProperty("best_round_zombies_alienarcadium_normal")]
        public long BestRoundZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("fastest_time_10_zombies_alienarcadium_normal")]
        public long FastestTime10_ZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("doors_opened_zombies_alienarcadium")]
        public long DoorsOpenedZombiesAlienarcadium { get; private set; }

        [JsonProperty("zombie_kills_zombies_alienarcadium_normal")]
        public long ZombieKillsZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("windows_repaired_zombies_alienarcadium_normal")]
        public long WindowsRepairedZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("total_rounds_survived_zombies_alienarcadium_normal")]
        public long TotalRoundsSurvivedZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("times_knocked_down_zombies_alienarcadium_normal")]
        public long TimesKnockedDownZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("doors_opened_zombies_alienarcadium_normal")]
        public long DoorsOpenedZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("players_revived_zombies_alienarcadium")]
        public long PlayersRevivedZombiesAlienarcadium { get; private set; }

        [JsonProperty("deaths_zombies_alienarcadium_normal")]
        public long DeathsZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("players_revived_zombies_alienarcadium_normal")]
        public long PlayersRevivedZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("fastest_time_20_zombies_alienarcadium_normal")]
        public long FastestTime20_ZombiesAlienarcadiumNormal { get; private set; }

        [JsonProperty("iron_golem_zombie_kills_zombies")]
        public long IronGolemZombieKillsZombies { get; private set; }

        [JsonProperty("mega_magma_zombie_kills_zombies")]
        public long MegaMagmaZombieKillsZombies { get; private set; }

        [JsonProperty("mega_blob_zombie_kills_zombies")]
        public long MegaBlobZombieKillsZombies { get; private set; }

        [JsonProperty("the_old_one_zombie_kills_zombies")]
        public long TheOldOneZombieKillsZombies { get; private set; }

        [JsonProperty("giant_rainbow_zombie_kills_zombies")]
        public long GiantRainbowZombieKillsZombies { get; private set; }

        [JsonProperty("charged_creeper_zombie_kills_zombies")]
        public long ChargedCreeperZombieKillsZombies { get; private set; }

        [JsonProperty("broodmother_zombie_kills_zombies")]
        public long BroodmotherZombieKillsZombies { get; private set; }

        [JsonProperty("fastest_time_20_zombies_deadend_hard")]
        public long FastestTime20_ZombiesDeadendHard { get; private set; }

        [JsonProperty("best_round_zombies_deadend_hard")]
        public long BestRoundZombiesDeadendHard { get; private set; }

        [JsonProperty("fastest_time_10_zombies_deadend_hard")]
        public long FastestTime10_ZombiesDeadendHard { get; private set; }

        [JsonProperty("windows_repaired_zombies_deadend_hard")]
        public long WindowsRepairedZombiesDeadendHard { get; private set; }

        [JsonProperty("total_rounds_survived_zombies_deadend_hard")]
        public long TotalRoundsSurvivedZombiesDeadendHard { get; private set; }

        [JsonProperty("players_revived_zombies_deadend_hard")]
        public long PlayersRevivedZombiesDeadendHard { get; private set; }

        [JsonProperty("deaths_zombies_deadend_hard")]
        public long DeathsZombiesDeadendHard { get; private set; }

        [JsonProperty("zombie_kills_zombies_deadend_hard")]
        public long ZombieKillsZombiesDeadendHard { get; private set; }

        [JsonProperty("times_knocked_down_zombies_deadend_hard")]
        public long TimesKnockedDownZombiesDeadendHard { get; private set; }

        [JsonProperty("doors_opened_zombies_deadend_hard")]
        public long DoorsOpenedZombiesDeadendHard { get; private set; }

        [JsonProperty("fastest_time_30_zombies_deadend_hard")]
        public long FastestTime30_ZombiesDeadendHard { get; private set; }

        [JsonProperty("wins_zombies_deadend_hard")]
        public long WinsZombiesDeadendHard { get; private set; }

        [JsonProperty("players_revived_zombies_deadend_rip")]
        public long PlayersRevivedZombiesDeadendRip { get; private set; }

        [JsonProperty("doors_opened_zombies_deadend_rip")]
        public long DoorsOpenedZombiesDeadendRip { get; private set; }
        #endregion

        #region hide and seek
        [JsonProperty("party_pooper_hider_wins_hide_and_seek")]
        public int HideAndSeekHiderWins { get; private set; }

        [JsonProperty("party_pooper_seeker_wins_hide_and_seek")]
        public int HideAndSeekSeekerWins { get; private set; }
        #endregion
    }
}