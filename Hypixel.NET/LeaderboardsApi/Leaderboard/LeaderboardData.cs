using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.LeaderboardsApi.Leaderboard
{
    public class LeaderboardData
    {
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }

        [JsonProperty("count")]
        public long Count { get; private set; }

        [JsonProperty("leaders")]
        public List<string> Leaders { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }
    }
}