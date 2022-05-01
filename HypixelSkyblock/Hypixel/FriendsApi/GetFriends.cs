using System.Collections.Generic;
using Hypixel.NET.FriendsApi.Record;
using Newtonsoft.Json;

namespace Hypixel.NET.FriendsApi
{
    public class GetFriends
    {
        public bool FromCache { get; set; }

        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("records")]
        public List<Records> Records { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }
    }
}