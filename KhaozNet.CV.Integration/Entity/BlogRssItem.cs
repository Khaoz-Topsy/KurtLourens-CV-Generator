using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using SystemOut.RssParser.Rss;
using SystemOut.RssParser.Util;

namespace KhaozNet.CV.Integration.Entity
{
    [XmlRoot("item", IsNullable = false)]
    [Serializable]
    public class BlogRssItem : IBaseRssItem
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("pubDate")]
        public string PublishedDate { get; set; }

        [XmlElement("link")]
        public string Link { get; set; }

        [XmlElement("guid")]
        public string Guid { get; set; }

        [XmlElement("category")]
        public List<string> Categories { get; set; }

        [XmlElement("creator", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Author { get; set; }

        [XmlElement("content", Namespace = "http://search.yahoo.com/mrss/")]
        public MediaContent Media { get; set; }

        [XmlIgnore]
        public DateTime Date => DateTime.TryParse(PublishedDate, out DateTime result)
            ? result.ToUniversalTime()
            : DateTimeParser.ParseDanishRssDate(PublishedDate).ToUniversalTime();

        public virtual string GetGuid() => string.IsNullOrEmpty(Guid) ? Link : Guid;
    }

    [Serializable]
    public class MediaContent
    {
        [XmlAttribute("url")]
        public string Url { get; set; }
    }
}
