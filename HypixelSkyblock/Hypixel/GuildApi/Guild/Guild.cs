using System;
using System.Collections.Generic;
using Hypixel.NET.GuildApi.Guild.XpByGameType;
using Newtonsoft.Json;

namespace Hypixel.NET.GuildApi.Guild
{
    public class Guild
    {
        [JsonProperty("_id")]
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("coins")]
        public long Coins { get; private set; }

        [JsonProperty("coinsEver")]
        public long CoinsEver { get; private set; }

        [JsonProperty("created")]
        private readonly long _created;
        public DateTime GuildCreatedDate
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_created).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("members")]
        public List<Member.Member> Members { get; private set; }

        [JsonProperty("tag")]
        public string Tag { get; private set; }

        [JsonProperty("tagColor")]
        public string TagColor { get; private set; }

        [JsonProperty("achievements")]
        public Achievements.Achievements Achievements { get; private set; }

        [JsonProperty("legacyRanking")]
        public long LegacyRanking { get; private set; }

        [JsonProperty("exp")]
        public long Exp { get; private set; }

        [JsonProperty("name_lower")]
        public string NameLower { get; private set; }

        [JsonProperty("guildExpByGameType")]
        public GuildExpByGameType GuildExpByGameType;
    }
}