using System.Collections.Generic;
using Newtonsoft.Json;

namespace KhaozNet.CV.Domain.Entity
{
    public class Project : BaseCardData
    {
        [JsonProperty("timePeriodColour")]
        public string TimePeriodColour { get; set; }

        [JsonProperty("timePeriodTextColour")]
        public string TimePeriodTextColour { get; set; }

        [JsonProperty("darkModeImage")]
        public string DarkModeImage { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }
}
