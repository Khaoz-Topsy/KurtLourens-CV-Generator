using System.Collections.Generic;
using Newtonsoft.Json;

namespace KhaozNet.CV.Domain.Entity
{
    public class WorkExperience: BaseCardData
    {
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("darkModeImage")]
        public string DarkModeImage { get; set; }

        [JsonProperty("timePeriodColour")]
        public string TimePeriodColour { get; set; }

        [JsonProperty("timePeriodTextColour")]
        public string TimePeriodTextColour { get; set; }

        [JsonProperty("pureHtml")]
        public string PureHtml { get; set; }

        [JsonProperty("buttons")]
        public List<Link> Buttons { get; set; }
    }
}
