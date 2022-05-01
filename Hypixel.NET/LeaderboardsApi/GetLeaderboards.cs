using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.LeaderboardsApi
{
    public class GetLeaderboards
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("leaderboards")]
        public Leaderboard.Leaderboard Leaderboards { get; private set; }
    }
}