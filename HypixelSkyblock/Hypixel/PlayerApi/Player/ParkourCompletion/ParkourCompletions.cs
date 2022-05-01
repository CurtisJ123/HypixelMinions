using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.ParkourCompletion
{
    public class ParkourCompletions
    {
        [JsonProperty("timeStart")]
        public long TimeStart { get; private set; }

        [JsonProperty("timeTook")]
        public long TimeTook { get; private set; }
    }
}
