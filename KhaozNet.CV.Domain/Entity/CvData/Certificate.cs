using System.Collections.Generic;
using Newtonsoft.Json;

namespace KhaozNet.CV.Domain.Entity.CvData
{
    public class Certificate : BaseCardData
    {
        [JsonProperty("isAward")]
        public bool IsAward { get; set; }

        [JsonProperty("buttons")]
        public List<Link> Buttons { get; set; }
    }
}
