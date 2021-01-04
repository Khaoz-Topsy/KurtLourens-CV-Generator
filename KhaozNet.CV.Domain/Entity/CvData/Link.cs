using Newtonsoft.Json;

namespace KhaozNet.CV.Domain.Entity.CvData
{
    public class Link
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
