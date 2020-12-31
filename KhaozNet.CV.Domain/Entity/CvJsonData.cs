using System.Collections.Generic;
using Newtonsoft.Json;

namespace KhaozNet.CV.Domain.Entity
{
    public class CvJsonData
    {
        [JsonProperty("workExperiences")]
        public List<WorkExperience> WorkExperiences { get; set; }

        [JsonProperty("certificates")]
        public List<Certificate> Certificates { get; set; }

        [JsonProperty("projects")]
        public List<Project> Projects { get; set; }
    }
}
