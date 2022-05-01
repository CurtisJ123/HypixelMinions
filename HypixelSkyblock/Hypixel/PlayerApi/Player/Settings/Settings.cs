using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Settings
{
    public class Settings
    {
        [JsonProperty("bloodVisibility")]
        public bool BloodVisibility { get; private set; }

        [JsonProperty("partyInvitePrivacy")]
        public string PartyInvitePrivacy { get; private set; }

        [JsonProperty("profanityLevel_PM")]
        public string ProfanityLevelPm { get; private set; }

        [JsonProperty("profanityLevel_GUILD")]
        public string ProfanityLevelGuild { get; private set; }

        [JsonProperty("profanityLevel_PARTY")]
        public string ProfanityLevelParty { get; private set; }

        [JsonProperty("profanityLevel")]
        public string ProfanityLevel { get; private set; }

        [JsonProperty("duelInvitePrivacy")]
        public string DuelInvitePrivacy { get; private set; }

        [JsonProperty("guildOnlineList")]
        public bool GuildOnlineList { get; private set; }
    }
}
