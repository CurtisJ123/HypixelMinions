using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class BuildBattle
    {
        [JsonProperty("wins")]
        public long Wins { get; private set; }

        [JsonProperty("wins_solo_normal")]
        public long WinsSoloNormal { get; private set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("games_played")]
        public long GamesPlayed { get; private set; }

        [JsonProperty("score")]
        public long Score { get; private set; }

        [JsonProperty("coins")]
        public long Coins { get; private set; }

        [JsonProperty("total_votes")]
        public long TotalVotes { get; private set; }

        [JsonProperty("correct_guesses")]
        public long CorrectGuesses { get; private set; }

        [JsonProperty("wins_guess_the_build")]
        public long WinsGuessTheBuild { get; private set; }

        [JsonProperty("wins_teams_normal")]
        public long WinsTeamsNormal { get; private set; }

        [JsonProperty("new_suit")]
        public string NewSuit { get; private set; }

        [JsonProperty("wins_halloween")]
        public long WinsHalloween { get; private set; }

        [JsonProperty("wins_solo_pro")]
        public long WinsSoloPro { get; private set; }

        [JsonProperty("super_votes")]
        public long SuperVotes { get; private set; }

        [JsonProperty("last_purchased_song")]
        public string LastPurchasedSong { get; private set; }

        [JsonProperty("music")]
        public bool Music { get; private set; }

        [JsonProperty("teams_most_points")]
        public long TeamsMostPoints { get; private set; }
    }
}