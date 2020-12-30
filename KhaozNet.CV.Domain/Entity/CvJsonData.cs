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

    public class WorkExperience
    {
        public string title { get; set; }
        public string company { get; set; }
        public string icon { get; set; }
        public string image { get; set; }
        public string imageAlt { get; set; }
        public string darkModeImage { get; set; }
        public string timePeriodText { get; set; }
        public string timePeriodTextAlt { get; set; }
        public string timePeriodClass { get; set; }
        public string timePeriodColour { get; set; }
        public string timePeriodTextColour { get; set; }
        public string content { get; set; }
        public string contentHtml { get; set; }
        public string location { get; set; }
        public string pureHtml { get; set; }
        public List<Button> buttons { get; set; }
    }

    public class Button
    {
        public string url { get; set; }
        public string alt { get; set; }
        public string text { get; set; }
    }

    public class Certificate
    {
        public bool isAward { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string imageAlt { get; set; }
        public string timePeriodText { get; set; }
        public string timePeriodTextAlt { get; set; }
        public string timePeriodClass { get; set; }
        public string content { get; set; }
        public string location { get; set; }
        public List<Button> buttons { get; set; }
    }

    public class Project
    {
        public string title { get; set; }
        public string image { get; set; }
        public string imageAlt { get; set; }
        public string timePeriodText { get; set; }
        public string timePeriodClass { get; set; }
        public string timePeriodColour { get; set; }
        public string timePeriodTextColour { get; set; }
        public string content { get; set; }
        public List<Link> links { get; set; }
        public string darkModeImage { get; set; }
        public string timePeriodTextAlt { get; set; }
        public string location { get; set; }
        public string contentHtml { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string alt { get; set; }
        public string text { get; set; }
    }

}
