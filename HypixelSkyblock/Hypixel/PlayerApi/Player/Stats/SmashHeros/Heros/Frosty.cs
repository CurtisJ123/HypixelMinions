using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats.SmashHeros.Heros
{
    public class Frosty
    {
        #region general
        [JsonProperty("games")]
        public long Games { get; private set; }

        [JsonProperty("deaths")]
        public long Deaths { get; private set; }

        [JsonProperty("win_streak")]
        public long WinStreak { get; private set; }

        [JsonProperty("damage_dealt")]
        public long DamageDealt { get; private set; }

        [JsonProperty("wins")]
        public long Wins { get; private set; }

        [JsonProperty("kills")]
        public long Kills { get; private set; }

        [JsonProperty("smashed")]
        public long Smashed { get; private set; }

        [JsonProperty("losses")]
        public long Losses { get; private set; }

        [JsonProperty("smasher")]
        public long Smasher { get; private set; }
        #endregion

        #region 1v1s
        [JsonProperty("one_v_one_losses")]
        public long OneVOneLosses { get; private set; }

        [JsonProperty("one_v_one_losses_normal")]
        public long OneVOneLossesNormal { get; private set; }

        [JsonProperty("one_v_one_wins_normal")]
        public long OneVOneWinsNormal { get; private set; }

        [JsonProperty("one_v_one_wins")]
        public long OneVOneWins { get; private set; }
        #endregion

        #region 2v2s
        [JsonProperty("damage_dealt_2v2")]
        public long DamageDealt2V2 { get; private set; }

        [JsonProperty("deaths_2v2")]
        public long Deaths2V2 { get; private set; }

        [JsonProperty("games_2v2")]
        public long Games2V2 { get; private set; }

        [JsonProperty("wins_2v2")]
        public long Wins2V2 { get; private set; }

        [JsonProperty("kills_2v2")]
        public long Kills2V2 { get; private set; }

        [JsonProperty("win_streak_2v2")]
        public long WinStreak2V2 { get; private set; }

        [JsonProperty("smasher_2v2")]
        public long Smasher2V2 { get; private set; }

        [JsonProperty("smashed_2v2")]
        public long Smashed2V2 { get; private set; }

        [JsonProperty("losses_2v2")]
        public long Losses2V2 { get; private set; }
        #endregion

        #region normal
        [JsonProperty("games_normal")]
        public long GamesNormal { get; private set; }

        [JsonProperty("damage_dealt_normal")]
        public long DamageDealtNormal { get; private set; }

        [JsonProperty("losses_normal")]
        public long LossesNormal { get; private set; }

        [JsonProperty("deaths_normal")]
        public long DeathsNormal { get; private set; }

        [JsonProperty("smashed_normal")]
        public long SmashedNormal { get; private set; }

        [JsonProperty("smasher_normal")]
        public long SmasherNormal { get; private set; }

        [JsonProperty("kills_normal")]
        public long KillsNormal { get; private set; }

        [JsonProperty("win_streak_normal")]
        public long WinStreakNormal { get; private set; }

        [JsonProperty("wins_normal")]
        public long WinsNormal { get; private set; }
        #endregion

        #region teams
        [JsonProperty("damage_dealt_teams")]
        public long DamageDealtTeams { get; private set; }

        [JsonProperty("smashed_teams")]
        public long SmashedTeams { get; private set; }

        [JsonProperty("deaths_teams")]
        public long DeathsTeams { get; private set; }

        [JsonProperty("games_teams")]
        public long GamesTeams { get; private set; }

        [JsonProperty("losses_teams")]
        public long LossesTeams { get; private set; }

        [JsonProperty("win_streak_teams")]
        public long WinStreakTeams { get; private set; }

        [JsonProperty("wins_teams")]
        public long WinsTeams { get; private set; }

        [JsonProperty("kills_teams")]
        public long KillsTeams { get; private set; }

        [JsonProperty("smasher_teams")]
        public long SmasherTeams { get; private set; }
        #endregion

        #region friends
        [JsonProperty("friend_losses")]
        public long FriendLosses { get; private set; }

        [JsonProperty("friend_losses_normal")]
        public long FriendLossesNormal { get; private set; }

        [JsonProperty("friend_wins_normal")]
        public long FriendWinsNormal { get; private set; }

        [JsonProperty("friend_wins")]
        public long FriendWins { get; private set; }
        #endregion
    }
}