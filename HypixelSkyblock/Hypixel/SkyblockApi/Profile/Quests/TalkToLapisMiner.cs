using Newtonsoft.Json;
using System;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class TalkToLapisMiner
    {
        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("activated_at")]
        private readonly long _activatedAt;
        public DateTime ActivatedAt
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_activatedAt).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("activated_at_sb")]
        public long ActivatedAtSb { get; private set; }

        [JsonProperty("completed_at")]
        private readonly long _completedAt;
        public DateTime CompletedAt
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_completedAt).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("completed_at_sb")]
        public long CompletedAtSb { get; private set; }
    }
}