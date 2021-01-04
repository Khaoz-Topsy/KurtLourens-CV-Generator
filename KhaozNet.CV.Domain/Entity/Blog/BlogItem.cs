using System;
using System.Collections.Generic;
using System.Text;

namespace KhaozNet.CV.Domain.Entity.Blog
{
    public class BlogItem
    {
        public string Guid { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public List<string> Categories { get; set; }
        public DateTime Date { get; set; }
    }
}
