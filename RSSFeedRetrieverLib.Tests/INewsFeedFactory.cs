using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedRetrieverLib.Tests
{
    public interface INewsFeedFactory
    {
        INewsFeed GetNewsFeed(NewsFeedFactoryType NewsFeedType);
    }
}

public enum NewsFeedFactoryType
{
    BBCRSSFeed,
    ReutersRSSFeed,
}
