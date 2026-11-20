using System.Collections.Generic;
using Newtonsoft.Json;

namespace MTGATrackerDaemon.Models
{
    public class InventoryResponseData
    {
        [JsonProperty("gems")]
        public int Gems { get; set; }

        [JsonProperty("gold")]
        public int Gold { get; set; }

        // [MTGA exporter patch] every plain number field on Arena's inventory object
        [JsonProperty("fields")]
        public Dictionary<string, object> Fields { get; set; }

        [JsonProperty("elapsedTime")]
        public int ElapsedTime { get; set; }
    }
}
