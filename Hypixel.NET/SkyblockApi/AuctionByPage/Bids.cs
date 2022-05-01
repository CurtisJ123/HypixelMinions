using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.AuctionByPage
{
    public class Bids
    {
        [JsonProperty("auction_id")]
        public string AuctionId { get; private set; }

        [JsonProperty("bidder")]
        public string Bidder { get; private set; }

        [JsonProperty("profile_id")]
        public string ProfileId { get; private set; }

        [JsonProperty("amount")]
        public long Amount { get; private set; }

        [JsonProperty("timestamp")]
        private readonly long _timestamp;
        public DateTime Timestamp
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_timestamp).ToLocalTime();
                return convertToDateTime;
            }

        }
    }
}
