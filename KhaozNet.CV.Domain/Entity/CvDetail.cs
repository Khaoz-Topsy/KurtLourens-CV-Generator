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
    }
}
