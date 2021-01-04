using System.Collections.Generic;
using System.Threading.Tasks;
using SystemOut.RssParser.Rss;
using KhaozNet.CV.Domain.Entity.Blog;
using KhaozNet.CV.Domain.Helper;
using KhaozNet.CV.Integration.Entity;

namespace KhaozNet.CV.Integration.Repository
{
    public class BlogRssRepository : BaseExternalApiRepository
    {
        public Task<List<BlogItem>> GetItems(int shortDescriptionLength = 250)
        {
            string url = "https://blog.kurtlourens.com/rss/";
            const string postContentSuffix = "...";

            List<BlogItem> result = new List<BlogItem>();

            BaseRssFeed<BaseRssChannel<BlogRssItem>> feed = RssDeserializer.GetFeed<BaseRssFeed<BaseRssChannel<BlogRssItem>>>(url);
            foreach (BaseRssChannel<BlogRssItem> channel in feed.RssChannels)
            {
                foreach (BlogRssItem item in channel.RssItems)
                {
                    string cleanHtml = item.Description.CleanHtml();
                    int shortDescripMaxLength = shortDescriptionLength - postContentSuffix.Length;
                    string finalDescription = (cleanHtml.Length > shortDescripMaxLength)
                        ? cleanHtml.Substring(0, shortDescripMaxLength)
                        : cleanHtml.TrimEnd();

                    result.Add(new BlogItem
                    {
                        Guid = item.Guid,
                        Link = item.Link,
                        Image = item.Media.Url,
                        Title = item.Title,
                        Description = item.Description,
                        Author = item.Author,
                        Categories = item.Categories,
                        Date = item.Date
                    });
                }
            }

            return Task.FromResult(result);
        }
    }
}
