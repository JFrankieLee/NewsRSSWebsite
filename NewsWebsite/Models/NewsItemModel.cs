using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RSSFeedRetrieverLib;
using RSSFeedRetrieverLib.Tests;

namespace NewsWebsite.Models
{
    public class NewsItemModel
    {
        public String Title { get; set; }

        public String Link { get; set; }

        public String Description { get; set; }

        public String PubDate { get; set; }

        public INewsFeed newsFd { get; set; }

        public NewsItemModel()
        {
            INewsFeedFactory newsFdFctry = new NewsFeedFactory();

            newsFd = newsFdFctry.GetNewsFeed(NewsFeedFactoryType.BBCRSSFeed);
        }
    }
}