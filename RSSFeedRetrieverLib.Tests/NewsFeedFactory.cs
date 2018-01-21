using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedRetrieverLib.Tests
{
    public class NewsFeedFactory : INewsFeedFactory
    {
        public INewsFeed GetNewsFeed(NewsFeedFactoryType NewsFeedType)
        {
            INewsFeed nwsFeed;
            IRssFeedStrFetcher rssFetcher;
            IXDocRssFeed xDocFeed;
            

            switch (NewsFeedType)
            {
                case NewsFeedFactoryType.BBCRSSFeed:
                    rssFetcher = new RssFeedStrFetcher("http://feeds.bbci.co.uk/news/uk/rss.xml");
                    xDocFeed = new XDocRssFeed(rssFetcher);
                    nwsFeed = new NewsFeed(xDocFeed);
                    break;
                case NewsFeedFactoryType.ReutersRSSFeed:
                    rssFetcher = new RssFeedStrFetcher("http://feeds.bbci.co.uk/news/uk/rss.xml");
                    xDocFeed = new XDocRssFeed(rssFetcher);
                    nwsFeed = new NewsFeed(xDocFeed);
                    break;
                default :
                    rssFetcher = new RssFeedStrFetcher("http://feeds.bbci.co.uk/news/uk/rss.xml");
                    xDocFeed = new XDocRssFeed(rssFetcher);
                    nwsFeed = new NewsFeed(xDocFeed);
                    break;

            }

            return nwsFeed;
        }
    }
}
