using System;
using Newtonsoft.Json;

namespace Hypixel.NET.KeyApi.Record
{
    public class Record
    {
        [JsonProperty("ownerUuid")]
        public string OwnerUuid { get; private set; }

        [JsonProperty("key")]
        public string Key { get; private set; }

        [JsonProperty("totalQueries")]
        public int TotalQueries { get; private set; }

        [JsonProperty("queriesInPastMin")]
        public int TotalQueriesInPastMin { get; private set; }
    }
}