using System.Collections.Generic;
using KhaozNet.CV.Domain.Entity.Blog;
using Newtonsoft.Json;

namespace KhaozNet.CV.Domain.Entity.CvData
{
    public class CvJsonData
    {
        [JsonProperty("details")]
        public CvDetail Details { get; set; }

        [JsonProperty("workExperiences")]
        public List<WorkExperience> WorkExperiences { get; set; }

        [JsonProperty("certificates")]
        public List<Certificate> Certificates { get; set; }

        [JsonProperty("projects")]
        public List<Project> Projects { get; set; }

        public List<BlogItem> BlogPosts { get; set; }
    }
}
