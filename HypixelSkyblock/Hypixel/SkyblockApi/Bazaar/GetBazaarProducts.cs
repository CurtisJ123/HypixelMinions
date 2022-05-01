using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Bazaar
{
    public class GetBazaarProducts
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("lastUpdated")]
        private readonly long _lastUpdated;
        public DateTime LastUpdated
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_lastUpdated).ToLocalTime();
                return convertToDateTime;
            }
        }
        [JsonProperty("products")]
        public Dictionary<string, Product> Products { get; private set; }
    }
}
