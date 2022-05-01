using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class Profile
    {
        [JsonProperty("profile_id")]
        public string ProfileId { get; set; }

        [JsonProperty("members")]
        public Dictionary<string, MemberList> Members { get; set; }
    }
}
