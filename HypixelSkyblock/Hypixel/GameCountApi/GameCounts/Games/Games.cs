using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.PlayerApi.Player.GameCounts.Games
{
    public class Games
    {
        [JsonProperty("BUILD_BATTLE")]
        public BuildBattle BuildBattle { get; private set; }

        [JsonProperty("UHC")]
        public Uhc Uhc { get; private set; }

        [JsonProperty("LEGACY")]
        public ClassicGames ClassicGames { get; private set; }

        [JsonProperty("SKYBLOCK")]
        public Skyblock Skyblock { get; private set; }

        [JsonProperty("HOUSING")]
        public Housing Housing { get; private set; }

        [JsonProperty("MCGO")]
        public CopsAndCrims CopsAndCrims { get; private set; }

        [JsonProperty("BATTLEGROUND")]
        public Warlords Warlords { get; private set; }

        [JsonProperty("MURDER_MYSTERY")]
        public MurderMystery MurderMystery { get; private set; }

        [JsonProperty("SURVIVAL_GAMES")]
        public BlitzSG BlitzSG { get; private set; }

        [JsonProperty("ARCADE")]
        public Arcade Arcade { get; private set; }

        [JsonProperty("TOURNAMENT_LOBBY")]
        public Tournament TournamentLobby { get; private set; }

        [JsonProperty("TNTGAMES")]
        public Tntgames TntGames { get; private set; }

        [JsonProperty("SKYWARS")]
        public Skywars Skywars { get; private set; }

        [JsonProperty("PROTOTYPE")]
        public Prototype Prototype { get; private set; }

        [JsonProperty("WALLS3")]
        public Walls3 Walls3 { get; private set; }

        [JsonProperty("BEDWARS")]
        public Bedwars Bedwars { get; private set; }

        [JsonProperty("LIMBO")]
        public Limbo Limbo { get; private set; }

        [JsonProperty("MAIN_LOBBY")]
        public MainLobby MainLobby { get; private set; }

        [JsonProperty("SUPER_SMASH")]
        public SuperSmash SuperSmash { get; private set; }

        [JsonProperty("TRUE_COMBAT")]
        public TrueCombat TrueCombat { get; private set; }

        [JsonProperty("PIT")]
        public Pit Pit { get; private set; }

        [JsonProperty("SPEED_UHC")]
        public SpeedUhc SpeedUhc { get; private set; }

        [JsonProperty("DUELS")]
        public Arcade Duels { get; private set; }
    }

    public class Arcade
    {
        [JsonProperty("modes")]
        public Dictionary<string, long> Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }
    public class ArcadeModes
    {
        [JsonProperty("PARTY")]
        public long PartyGames { get; private set; }

        [JsonProperty("HOLE_IN_THE_WALL")]
        public long HoleInTheWall { get; private set; }

        [JsonProperty("DEFENDER")]
        public long CreeperAttack { get; private set; }

        [JsonProperty("MINI_WALLS")]
        public long MiniWalls { get; private set; }

        [JsonProperty("SIMON_SAYS")]
        public long HypixelSays { get; private set; }

        [JsonProperty("ZOMBIES_BAD_BLOOD")]
        public long ZombiesBadBlood { get; private set; }

        [JsonProperty("HIDE_AND_SEEK_PARTY_POOPER")]
        public long HideAndSeekPartyPooper { get; private set; }

        [JsonProperty("DAYONE")]
        public long BlockingDead { get; private set; }

        [JsonProperty("DRAW_THEIR_THING")]
        public long PixelPainters { get; private set; }

        [JsonProperty("ZOMBIES_ALIEN_ARCADIUM")]
        public long ZombiesAlienArcadium { get; private set; }

        [JsonProperty("ONEINTHEQUIVER")]
        public long BountyHunter { get; private set; }

        [JsonProperty("SOCCER")]
        public long Soccer { get; private set; }

        [JsonProperty("THROW_OUT")]
        public long ThrowOut { get; private set; }

        [JsonProperty("STARWARS")]
        public long GalaxyWars { get; private set; }

        [JsonProperty("DRAGONWARS2")]
        public long DragonWars { get; private set; }

        [JsonProperty("ZOMBIES_DEAD_END")]
        public long ZombiesDeadEnd { get; private set; }

        [JsonProperty("FARM_HUNT")]
        public long FarmHunt { get; private set; }

        [JsonProperty("HIDE_AND_SEEK_PROP_HUNT")]
        public long PropHuntHideAndSeek { get; private set; }

    }

    public class Skywars
    {
        [JsonProperty("modes")]
        public SkyWarsModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }
    public class SkyWarsModes
    {
        [JsonProperty("ranked_normal")]
        public long RankedNormal { get; private set; }

        [JsonProperty("solo_insane_tnt_madness")]
        public long SoloInsaneTNTMadness { get; private set; }

        [JsonProperty("solo_insane_lucky")]
        public long SoloInsaneLucky { get; private set; }

        [JsonProperty("teams_insane_rush")]
        public long TeamsInsaneRush { get; private set; }

        [JsonProperty("teams_insane_lucky")]
        public long TeamsInsaneLucky { get; private set; }

        [JsonProperty("teams_insane")]
        public long TeamsInsane { get; private set; }

        [JsonProperty("solo_normal")]
        public long SoloNormal { get; private set; }

        [JsonProperty("solo_insane_hunters_vs_beasts")]
        public long SoloInsaneHuntersVsBeasts { get; private set; }

        [JsonProperty("solo_insane")]
        public long SoloInsane { get; private set; }

        [JsonProperty("teams_insane_tnt_madness")]
        public long TeamsInsaneTNTMadness { get; private set; }

        [JsonProperty("teams_normal")]
        public long TeamsNormal { get; private set; }
    }

    public class Warlords
    {
        [JsonProperty("modes")]
        public BattlegroundModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public partial class BattlegroundModes
    {
        [JsonProperty("ctf_mini")]
        public long CtfMini { get; private set; }

        [JsonProperty("team_deathmatch")]
        public long TeamDeathmatch { get; private set; }
    }

    public class Bedwars
    {
        [JsonProperty("modes")]
        public BedwarsModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class BedwarsModes
    {
        [JsonProperty("BEDWARS_FOUR_THREE")]
        public long BedwarsTrios { get; private set; }

        [JsonProperty("BEDWARS_FOUR_FOUR_LUCKY")]
        public long BedwarsFoursLucky { get; private set; }

        [JsonProperty("BEDWARS_FOUR_FOUR_RUSH")]
        public long BedwarsFoursRush { get; private set; }

        [JsonProperty("BEDWARS_EIGHT_ONE")]
        public long BedwarsSolo { get; private set; }

        [JsonProperty("BEDWARS_EIGHT_TWO_RUSH")]
        public long BedwarsDuosRush { get; private set; }

        [JsonProperty("BEDWARS_FOUR_FOUR")]
        public long BedwarsFours { get; private set; }

        [JsonProperty("BEDWARS_EIGHT_TWO")]
        public long BedwarsDuos { get; private set; }

        [JsonProperty("BEDWARS_CAPTURE")]
        public long BedwarsCapture { get; private set; }

        [JsonProperty("BEDWARS_EIGHT_TWO_LUCKY")]
        public long BedwarsDuoLucky { get; private set; }
    }

    public class BuildBattle
    {
        [JsonProperty("modes")]
        public BuildBattleModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class BuildBattleModes
    {
        [JsonProperty("BUILD_BATTLE_GUESS_THE_BUILD")]
        public long BuildBattleGuessTheBuild { get; private set; }

        [JsonProperty("BUILD_BATTLE_TEAMS_NORMAL")]
        public long BuildBattleTeamsNormal { get; private set; }

        [JsonProperty("BUILD_BATTLE_SOLO_PRO")]
        public long BuildBattleSoloPro { get; private set; }

        [JsonProperty("BUILD_BATTLE_SOLO_NORMAL")]
        public long BuildBattleSoloNormal { get; private set; }
    }

    public class Housing
    {
        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class MainLobby
    {
        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class Limbo
    {
        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class Tournament
    {
        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class Skyblock
    {
        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class ClassicGames
    {
        [JsonProperty("modes")]
        public LegacyModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class LegacyModes
    {
        [JsonProperty("WALLS")]
        public long Walls { get; private set; }

        [JsonProperty("PAINTBALL")]
        public long Paintball { get; private set; }

        [JsonProperty("QUAKECRAFT")]
        public long Quakecraft { get; private set; }

        [JsonProperty("VAMPIREZ")]
        public long Vampirez { get; private set; }

        [JsonProperty("ARENA")]
        public long Arena { get; private set; }

        [JsonProperty("GINGERBREAD")]
        public long Gingerbread { get; private set; }
    }

    public class CopsAndCrims
    {
        [JsonProperty("modes")]
        public McgoModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class McgoModes
    {
        [JsonProperty("normal")]
        public long Normal { get; private set; }

        [JsonProperty("deathmatch")]
        public long Deathmatch { get; private set; }
    }

    public partial class MurderMystery
    {
        [JsonProperty("modes")]
        public MurderMysteryModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class MurderMysteryModes
    {
        [JsonProperty("MURDER_DOUBLE_UP")]
        public long MurderDoubleUp { get; private set; }

        [JsonProperty("MURDER_INFECTION")]
        public long MurderInfection { get; private set; }

        [JsonProperty("MURDER_ASSASSINS")]
        public long MurderAssassins { get; private set; }

        [JsonProperty("MURDER_CLASSIC")]
        public long MurderClassic { get; private set; }
    }

    public class Pit
    {
        [JsonProperty("modes")]
        public PitModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class PitModes
    {
        [JsonProperty("PIT")]
        public long Pit { get; private set; }
    }

    public class Prototype
    {
        [JsonProperty("modes")]
        public PrototypeModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class PrototypeModes
    {
        [JsonProperty("KOTH_FOUR_TEAM")]
        public long KingOfTheHillFourTeam { get; private set; }

        [JsonProperty("TOWERWARS_SOLO")]
        public long TowerwarsSolo { get; private set; }

        [JsonProperty("PVP_CTW")]
        public long PvpCaptureTheWool { get; private set; }

        [JsonProperty("KOTH_TWO_TEAM")]
        public long KingOfTheHillFTwoTeam { get; private set; }

        [JsonProperty("TOWERWARS_TEAM_OF_TWO")]
        public long TowerwarsTeamOfTwo { get; private set; }
    }

    public class SpeedUhc
    {
        [JsonProperty("modes")]
        public SpeedUhcModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class SpeedUhcModes
    {
        [JsonProperty("team_normal")]
        public long TeamNormal { get; private set; }

        [JsonProperty("solo_normal")]
        public long SoloNormal { get; private set; }
    }

    public class SuperSmash
    {
        [JsonProperty("modes")]
        public SuperSmashModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class SuperSmashModes
    {
        [JsonProperty("1v1_normal")]
        public long The1V1Normal { get; private set; }

        [JsonProperty("friends_normal")]
        public long FriendsNormal { get; private set; }

        [JsonProperty("solo_normal")]
        public long SoloNormal { get; private set; }

        [JsonProperty("2v2_normal")]
        public long The2V2Normal { get; private set; }

        [JsonProperty("teams_normal")]
        public long TeamsNormal { get; private set; }
    }

    public class BlitzSG
    {
        [JsonProperty("modes")]
        public SurvivalGamesModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class SurvivalGamesModes
    {
        [JsonProperty("solo_normal")]
        public long SoloNormal { get; private set; }

        [JsonProperty("teams_normal")]
        public long TeamsNormal { get; private set; }
    }

    public class Tntgames
    {
        [JsonProperty("modes")]
        public TntgamesModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class TntgamesModes
    {
        [JsonProperty("PVPRUN")]
        public long Pvprun { get; private set; }

        [JsonProperty("TNTAG")]
        public long Tntag { get; private set; }

        [JsonProperty("TNTRUN")]
        public long Tntrun { get; private set; }

        [JsonProperty("CAPTURE")]
        public long Capture { get; private set; }

        [JsonProperty("BOWSPLEEF")]
        public long Bowspleef { get; private set; }
    }

    public class TrueCombat
    {
        [JsonProperty("modes")]
        public TrueCombatModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class TrueCombatModes
    {
        [JsonProperty("solo_chaos")]
        public long SoloChaos { get; private set; }

        [JsonProperty("team_chaos")]
        public long TeamChaos { get; private set; }
    }

    public class Uhc
    {
        [JsonProperty("modes")]
        public UhcModes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class UhcModes
    {
        [JsonProperty("TEAMS")]
        public long Teams { get; private set; }

        [JsonProperty("SOLO")]
        public long Solo { get; private set; }
    }

    public class Walls3
    {
        [JsonProperty("modes")]
        public Walls3Modes Modes { get; private set; }

        [JsonProperty("players")]
        public long Players { get; private set; }
    }

    public class Walls3Modes
    {
        [JsonProperty("standard")]
        public long Standard { get; private set; }

        [JsonProperty("face_off")]
        public long FaceOff { get; private set; }
    }

}
