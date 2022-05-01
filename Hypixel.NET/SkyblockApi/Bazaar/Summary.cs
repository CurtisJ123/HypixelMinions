using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Bazaar
{
    public class Summary
    {
        [JsonProperty("amount")]
        public long Amount { get; private set; }

        [JsonProperty("pricePerUnit")]
        public double PricePerUnit { get; private set; }

        [JsonProperty("orders")]
        public long Orders { get; private set; }
    }
}