using System;
using Newtonsoft.Json;

namespace Hypixel.NET.GuildApi.Guild.Member
{
    public class Member
    {
        [JsonProperty("uuid")]
        public string Uuid { get; private set; }

        [JsonProperty("rank")]
        public string Rank { get; private set; }

        [JsonProperty("joined")]
        private readonly long _joined;
        public DateTime Joined
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_joined).ToLocalTime();
                return convertToDateTime;
            }
        }
    }
}