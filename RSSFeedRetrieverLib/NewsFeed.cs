using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedRetrieverLib
{
    public class NewsFeed : INewsFeed
    {
        public List<INewsItem> News { get; set; }

        public NewsFeed(IXDocRssFeed xDocFeed)
        {
            try
            {
                List<NewsItem> n = (from x in xDocFeed.RSSFeedXML.Descendants("item")
                                    select new NewsItem
                                    {
                                        Title = ((string)x.Element("title")),
                                        Link = ((string)x.Element("link")),
                                        Description = ((string)x.Element("description")),
                                        PubDate = ((string)x.Element("pubDate"))
                                    } //as INewsItem
                                   ).ToList();

                News = n.ToList<INewsItem>();
            }
            catch (Exception e)
            {
                //log.Error("Can't get collection", e);
            }
        }
    }
}
