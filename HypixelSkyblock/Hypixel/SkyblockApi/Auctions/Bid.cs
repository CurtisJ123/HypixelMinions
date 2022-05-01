using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Auctions
{
    public class Bid
    {
        [JsonProperty("auction_id")]
        public string AuctionId { get; private set; }

        [JsonProperty("bidder")]
        public string Bidder { get; private set; }

        [JsonProperty("amount")]
        public long Amount { get; private set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; private set; }

        [JsonProperty("profile_id")]
        public string ProfileId { get; private set; }
    }
}
