using System;
using Newtonsoft.Json;

namespace Hypixel.NET.Booster
{
    public class Booster
    {
        [JsonProperty("purchaserUuid")]
        public string PurchaserUuid { get; private set; }

        [JsonProperty("amount")]
        public double Amount { get; private set; }

        [JsonProperty("originalLength")]
        public int OriginalLength { get; private set; }

        [JsonProperty("length")]
        public int Length { get; private set; }

        [JsonProperty("gameType")]
        private readonly int _gameType;
        public string GameType
        {
            get
            {
                switch (_gameType)
                {
                    case 5:
                        return "Blitz SG";
                    case 6:
                        return "TNT Games";
                    case 13:
                        return "Mega Walls";
                    case 14:
                        return "Arcade";
                    case 20:
                        return "Uhc";
                    case 21:
                        return "Cops and Crims";
                    case 23:
                        return "Warlords";
                    case 24:
                        return "Smash Heros";
                    case 51:
                        return "SkyWars";
                    case 56:
                        return "Classic Games";
                    default:
                        return "unknown";
                }
            }
        }
        [JsonProperty("dateActivated")]
        private readonly long _dateActivated;
        public DateTime DateActivated
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_dateActivated).ToLocalTime();
                return convertToDateTime;
            }
        }
    }
}