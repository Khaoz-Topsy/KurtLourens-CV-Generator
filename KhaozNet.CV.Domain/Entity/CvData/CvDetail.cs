using System.Collections.Generic;
using Newtonsoft.Json;

namespace KhaozNet.CV.Domain.Entity
{
    public class CvDetail
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("descriptions")]
        public List<string> Descriptions { get; set; }

        [JsonProperty("socialLinks")]
        public List<SocialLink> SocialLinks { get; set; }
    }

    public class SocialLink
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("classNames")]
        public string ClassNames { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("onClick")]
        public string OnClick { get; set; }
    }
}
