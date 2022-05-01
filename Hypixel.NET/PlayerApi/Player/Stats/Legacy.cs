using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Legacy
    {
        [JsonProperty("next_tokens_seconds")]
        public long NextTokensSeconds { get; private set; }

        [JsonProperty("total_tokens")]
        public long TotalTokens { get; private set; }

        [JsonProperty("vampirez_tokens")]
        public long VampirezTokens { get; private set; }

        [JsonProperty("tokens")]
        public long Tokens { get; private set; }

        [JsonProperty("paintball_tokens")]
        public long PaintballTokens { get; private set; }

        [JsonProperty("gingerbread_tokens")]
        public long GingerbreadTokens { get; private set; }

        [JsonProperty("quakecraft_tokens")]
        public long QuakecraftTokens { get; private set; }

        [JsonProperty("walls_tokens")]
        public long WallsTokens { get; private set; }
    }
}