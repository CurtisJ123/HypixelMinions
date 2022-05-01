using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Voting
{
    public class Voting
    {
        [JsonProperty("total")]
        public int TotalVotes { get; private set; }

        [JsonProperty("total_mcsorg")]
        public int TotalMcsorg { get; private set; }

        [JsonProperty("secondary_mcsorg")]
        public int SecondaryMcsorg { get; private set; }

        [JsonProperty("votesToday")]
        public int VotesToday { get; private set; }

        [JsonProperty("secondary_mcsl")]
        public int SecondaryMcsl { get; private set; }

        [JsonProperty("total_mcsl")]
        public int TotalMcsl { get; private set; }

        [JsonProperty("total_mcf")]
        public int TotalMcf { get; private set; }

        [JsonProperty("secondary_mcf")]
        public int SecondaryMcf { get; private set; }

        [JsonProperty("total_mcmp")]
        public int TotalMcmp { get; private set; }

        [JsonProperty("secondary_mcmp")]
        public int SecondaryMcmp { get; private set; }

        [JsonProperty("total_topg")]
        public int TotalTopg { get; private set; }

        [JsonProperty("secondary_topg")]
        public int SecondaryTopg { get; private set; }

    }
}