using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Profile.Objectives
{
    public class CollectFarmingResources
    {
        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("progress")]
        public long Progress { get; private set; }

        [JsonProperty("completed_at")]
        public readonly long _completedAt;
        public DateTime CompletedAt
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_completedAt).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("POTATO_ITEM")]
        public bool PotatoItem { get; private set; }

        [JsonProperty("CARROT_ITEM")]
        public bool CarrotItem { get; private set; }

        [JsonProperty("PUMPKIN")]
        public bool Pumpkin { get; private set; }

        [JsonProperty("MELON")]
        public bool Melon { get; private set; }
    }
}
