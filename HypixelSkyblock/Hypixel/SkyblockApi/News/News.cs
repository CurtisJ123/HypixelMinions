using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.News
{
    public class News
    {
        [JsonProperty("link")]
        public string Link { get; private set; }
        [JsonProperty("text")]
        public string Text { get; private set; }
        [JsonProperty("title")]
        public string Title { get; private set; }
    }
}
