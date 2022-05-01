using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hypixel.NET.SkyblockApi.Bazaar
{
    public class Product
    {
        [JsonProperty("product_id")]
        public string ProductId { get; private set; }

        [JsonProperty("sell_summary")]
        public List<Summary> SellSummary { get; private set; }

        [JsonProperty("buy_summary")]
        public List<Summary> BuySummary { get; private set; }

        [JsonProperty("quick_status")]
        public QuickStatus QuickStatus { get; private set; }
    }
}