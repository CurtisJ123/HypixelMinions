using Newtonsoft.Json;

namespace Hypixel.NET.WatchdogStatsApi
{
    public class GetWatchdogStats
    {
        [JsonProperty("success")]
        public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")]
        public string Cause { get; private set; }

        [JsonProperty("watchdog_lastMinute")]
        public int WatchdogLastMinute { get; private set; }

        [JsonProperty("staff_rollingDaily")]
        public int StaffRollingDaily { get; private set; }

        [JsonProperty("watchdog_total")]
        public int WatchdogTotal { get; private set; }

        [JsonProperty("watchdog_rollingDaily")]
        public int WatchdogRollingDaily { get; private set; }

        [JsonProperty("staff_total")]
        public int StaffTotal { get; private set; }
    }
}