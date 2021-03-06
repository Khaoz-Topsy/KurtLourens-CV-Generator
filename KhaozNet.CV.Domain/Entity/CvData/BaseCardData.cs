﻿using Newtonsoft.Json;

namespace KhaozNet.CV.Domain.Entity.CvData
{
    public class BaseCardData
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("imageAlt")]
        public string ImageAlt { get; set; }

        [JsonProperty("timePeriodText")]
        public string TimePeriodText { get; set; }

        [JsonProperty("timePeriodTextAlt")]
        public string TimePeriodTextAlt { get; set; }

        [JsonProperty("timePeriodClass")]
        public string TimePeriodClass { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
