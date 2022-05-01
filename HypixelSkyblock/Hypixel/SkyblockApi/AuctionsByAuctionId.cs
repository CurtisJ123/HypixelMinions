using Hypixel.NET.SkyblockApi.Auctions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi
{
    public class AuctionByAuctionId
    {
        public bool FromCache;

        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("auctions")]
        public List<Auctions.Auction> Auction { get; private set; }
    }
}
