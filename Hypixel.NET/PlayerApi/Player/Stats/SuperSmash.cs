using System.Collections.Generic;
using Hypixel.NET.PlayerApi.Player.Stats.SmashHeros;
using Hypixel.NET.PlayerApi.Player.Stats.SmashHeros.Heros;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class SuperSmash
    {
        [JsonProperty("lastLevel_THE_BULK")]
        public int LastLevelTheBulk { get; private set; }

        [JsonProperty("active_class")]
        public string ActiveClass { get; private set; }

        [JsonProperty("win_streak")]
        public int WinStreak { get; private set; }

        [JsonProperty("class_stats")]
        public ClassStats ClassStats { get; private set; }

        [JsonProperty("smasher")]
        public int Smasher { get; private set; }

        [JsonProperty("coins")]
        public int Coins { get; private set; }

        [JsonProperty("smasher_normal")]
        public int SmasherNormal { get; private set; }

        [JsonProperty("losses_normal")]
        public int LossesNormal { get; private set; }

        [JsonProperty("kills")]
        public int Kills { get; private set; }

        [JsonProperty("damage_dealt")]
        public int DamageDealt { get; private set; }

        [JsonProperty("losses")]
        public int Losses { get; private set; }

        [JsonProperty("smashed_normal")]
        public int SmashedNormal { get; private set; }

        [JsonProperty("deaths_normal")]
        public int DeathsNormal { get; private set; }

        [JsonProperty("games_normal")]
        public int GamesNormal { get; private set; }

        [JsonProperty("smashed")]
        public int Smashed { get; private set; }

        [JsonProperty("kills_normal")]
        public int KillsNormal { get; private set; }

        [JsonProperty("deaths")]
        public int Deaths { get; private set; }

        [JsonProperty("games")]
        public int Games { get; private set; }

        [JsonProperty("damage_dealt_normal")]
        public int DamageDealtNormal { get; private set; }

        [JsonProperty("xp_THE_BULK")]
        public int XpTheBulk { get; private set; }

        [JsonProperty("smash_level_total")]
        public int SmashLevelTotal { get; private set; }

        [JsonProperty("smashLevel")]
        public int SmashLevel { get; private set; }

        [JsonProperty("wins")]
        public int Wins { get; private set; }

        [JsonProperty("wins_normal")]
        public int WinsNormal { get; private set; }

        [JsonProperty("FRIENDS_gamesDay")]
        public int FriendsGamesDay { get; private set; }

        [JsonProperty("friend_losses")]
        public int FriendLosses { get; private set; }

        [JsonProperty("friend_wins")]
        public int FriendWins { get; private set; }

        [JsonProperty("friend_wins_normal")]
        public int FriendWinsNormal { get; private set; }

        [JsonProperty("assists")]
        public int Assists { get; private set; }

        [JsonProperty("assists_normal")]
        public int AssistsNormal { get; private set; }

        [JsonProperty("quits")]
        public int Quits { get; private set; }

        [JsonProperty("friend_losses_normal")]
        public int FriendLossesNormal { get; private set; }

        [JsonProperty("xp_CAKE_MONSTER")]
        public int XpCakeMonster { get; private set; }

        [JsonProperty("lastLevel_CAKE_MONSTER")]
        public int LastLevelCakeMonster { get; private set; }

        [JsonProperty("deaths_2v2")]
        public int Deaths2V2 { get; private set; }

        [JsonProperty("wins_2v2")]
        public int Wins2V2 { get; private set; }

        [JsonProperty("kills_2v2")]
        public int Kills2V2 { get; private set; }

        [JsonProperty("games_2v2")]
        public int Games2V2 { get; private set; }

        [JsonProperty("damage_dealt_2v2")]
        public int DamageDealt2V2 { get; private set; }

        [JsonProperty("xp_GENERAL_CLUCK")]
        public int XpGeneralCluck { get; private set; }

        [JsonProperty("lastLevel_GENERAL_CLUCK")]
        public int LastLevelGeneralCluck { get; private set; }

        [JsonProperty("smashed_2v2")]
        public int Smashed2V2 { get; private set; }

        [JsonProperty("smasher_2v2")]
        public int Smasher2V2 { get; private set; }

        [JsonProperty("losses_2v2")]
        public int Losses2V2 { get; private set; }

        [JsonProperty("xp_BOTMUN")]
        public int XpBotmun { get; private set; }

        [JsonProperty("lastLevel_BOTMUN")]
        public int LastLevelBotmun { get; private set; }

        [JsonProperty("damage_dealt_teams")]
        public int DamageDealtTeams { get; private set; }

        [JsonProperty("wins_teams")]
        public int WinsTeams { get; private set; }

        [JsonProperty("smashed_teams")]
        public int SmashedTeams { get; private set; }

        [JsonProperty("kills_teams")]
        public int KillsTeams { get; private set; }

        [JsonProperty("smasher_teams")]
        public int SmasherTeams { get; private set; }

        [JsonProperty("deaths_teams")]
        public int DeathsTeams { get; private set; }

        [JsonProperty("games_teams")]
        public int GamesTeams { get; private set; }

        [JsonProperty("losses_teams")]
        public int LossesTeams { get; private set; }

        [JsonProperty("xp_FROSTY")]
        public int XpFrosty { get; private set; }

        [JsonProperty("lastLevel_FROSTY")]
        public int LastLevelFrosty { get; private set; }

        [JsonProperty("xp_TINMAN")]
        public int XpTinman { get; private set; }

        [JsonProperty("lastLevel_TINMAN")]
        public int LastLevelTinman { get; private set; }

        [JsonProperty("lastLevel_MARAUDER")]
        public int LastLevelMarauder { get; private set; }

        [JsonProperty("xp_MARAUDER")]
        public int XpMarauder { get; private set; }

        [JsonProperty("xp_GOKU")]
        public int XpGoku { get; private set; }

        [JsonProperty("lastLevel_GOKU")]
        public int LastLevelGoku { get; private set; }

        [JsonProperty("xp_SPODERMAN")]
        public int XpSpoderman { get; private set; }

        [JsonProperty("lastLevel_SPODERMAN")]
        public int LastLevelSpoderman { get; private set; }

        [JsonProperty("xp_PUG")]
        public int XpPug { get; private set; }

        [JsonProperty("lastLevel_PUG")]
        public int LastLevelPug { get; private set; }

        [JsonProperty("pg_FROSTY")]
        public int PgFrosty { get; private set; }

        [JsonProperty("votes_Gunmetal")]
        public int VotesGunmetal { get; private set; }

        [JsonProperty("xp_SKULLFIRE")]
        public int XpSkullfire { get; private set; }

        [JsonProperty("lastLevel_SKULLFIRE")]
        public int LastLevelSkullfire { get; private set; }

        [JsonProperty("votes_Equinox")]
        public int VotesEquinox { get; private set; }

        [JsonProperty("pg_THE_BULK")]
        public int PgTheBulk { get; private set; }

        [JsonProperty("masterArmor_FROSTY")]
        public bool MasterArmorFrosty { get; private set; }

        [JsonProperty("xp_SHOOP_DA_WHOOP")]
        public int XpShoopDaWhoop { get; private set; }

        [JsonProperty("lastLevel_SHOOP_DA_WHOOP")]
        public int LastLevelShoopDaWhoop { get; private set; }

        [JsonProperty("pg_TINMAN")]
        public int PgTinman { get; private set; }

        [JsonProperty("pg_SHOOP_DA_WHOOP")]
        public int PgShoopDaWhoop { get; private set; }

        [JsonProperty("pg_BOTMUN")]
        public int PgBotmun { get; private set; }

        [JsonProperty("masterArmor_THE_BULK")]
        public bool MasterArmorTheBulk { get; private set; }

        [JsonProperty("xp_DUSK_CRAWLER")]
        public int XpDuskCrawler { get; private set; }

        [JsonProperty("lastLevel_DUSK_CRAWLER")]
        public int LastLevelDuskCrawler { get; private set; }

        [JsonProperty("pg_DUSK_CRAWLER")]
        public int PgDuskCrawler { get; private set; }

        [JsonProperty("pg_PUG")]
        public int PgPug { get; private set; }

        [JsonProperty("votes_Dojo")]
        public int VotesDojo { get; private set; }

        [JsonProperty("pg_CAKE_MONSTER")]
        public int PgCakeMonster { get; private set; }

        [JsonProperty("masterArmor_TINMAN")]
        public bool MasterArmorTinman { get; private set; }

        [JsonProperty("pg_SKULLFIRE")]
        public int PgSkullfire { get; private set; }

        [JsonProperty("masterArmor_BOTMUN")]
        public bool MasterArmorBotmun { get; private set; }

        [JsonProperty("pg_GENERAL_CLUCK")]
        public int PgGeneralCluck { get; private set; }

        [JsonProperty("pg_SPODERMAN")]
        public int PgSpoderman { get; private set; }

        [JsonProperty("lastLevel_SERGEANT_SHIELD")]
        public int LastLevelSergeantShield { get; private set; }

        [JsonProperty("xp_SERGEANT_SHIELD")]
        public int XpSergeantShield { get; private set; }

        [JsonProperty("xp_SANIC")]
        public int XpSanic { get; private set; }

        [JsonProperty("lastLevel_SANIC")]
        public int LastLevelSanic { get; private set; }

        [JsonProperty("xp_GREEN_HOOD")]
        public int XpGreenHood { get; private set; }

        [JsonProperty("lastLevel_GREEN_HOOD")]
        public int LastLevelGreenHood { get; private set; }

        [JsonProperty("pg_SERGEANT_SHIELD")]
        public int PgSergeantShield { get; private set; }

        [JsonProperty("packages")]
        public List<object> Packages { get; private set; }

        [JsonProperty("masterArmor_SERGEANT_SHIELD")]
        public bool MasterArmorSergeantShield { get; private set; }

        [JsonProperty("pg_GOKU")]
        public int PgGoku { get; private set; }

        [JsonProperty("masterArmor_GENERAL_CLUCK")]
        public bool MasterArmorGeneralCluck { get; private set; }

        [JsonProperty("pg_MARAUDER")]
        public int PgMarauder { get; private set; }

        [JsonProperty("pg_SANIC")]
        public int PgSanic { get; private set; }

        [JsonProperty("pg_GREEN_HOOD")]
        public int PgGreenHood { get; private set; }

        [JsonProperty("masterArmor_PUG")]
        public bool MasterArmorPug { get; private set; }

        [JsonProperty("masterArmor_CAKE_MONSTER")]
        public bool MasterArmorCakeMonster { get; private set; }

        [JsonProperty("masterArmor_GOKU")]
        public bool MasterArmorGoku { get; private set; }

        [JsonProperty("masterArmor_SHOOP_DA_WHOOP")]
        public bool MasterArmorShoopDaWhoop { get; private set; }

        [JsonProperty("masterArmor_SANIC")]
        public bool MasterArmorSanic { get; private set; }

        [JsonProperty("masterArmor_SKULLFIRE")]
        public bool MasterArmorSkullfire { get; private set; }

        [JsonProperty("masterArmor_GREEN_HOOD")]
        public bool MasterArmorGreenHood { get; private set; }

        [JsonProperty("masterArmor_DUSK_CRAWLER")]
        public bool MasterArmorDuskCrawler { get; private set; }

        [JsonProperty("masterArmor_MARAUDER")]
        public bool MasterArmorMarauder { get; private set; }

        [JsonProperty("masterArmor_SPODERMAN")]
        public bool MasterArmorSpoderman { get; private set; }

        [JsonProperty("ONE_V_JUAN_gamesDay")]
        public int OneVJuanGamesDay { get; private set; }

        [JsonProperty("one_v_one_losses_normal")]
        public int OneVOneLossesNormal { get; private set; }

        [JsonProperty("one_v_one_losses")]
        public int OneVOneLosses { get; private set; }

        [JsonProperty("one_v_one_wins_normal")]
        public int OneVOneWinsNormal { get; private set; }

        [JsonProperty("one_v_one_wins")]
        public int OneVOneWins { get; private set; }
    }
}