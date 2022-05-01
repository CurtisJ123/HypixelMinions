using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.News
{
    public class GetNews
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("items")]
        public List<News> Items { get; private set; }
    }
}
