using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Profile.Objectives
{
    public class CollectSpider
    {
        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("progress")]
        public long Progress { get; private set; }

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

        [JsonProperty("STRING")]
        public bool String { get; private set; }

        [JsonProperty("SPIDER_EYE")]
        public bool SpiderEye { get; private set; }
    }
}
