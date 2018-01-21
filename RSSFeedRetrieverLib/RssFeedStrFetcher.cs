using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace RSSFeedRetrieverLib
{
    public class RssFeedStrFetcher : IRssFeedStrFetcher
    {
        public String RSSFeedString { get; set; }

        public RssFeedStrFetcher(String rssFeedStr)
        {
            WebClient wclient = new WebClient();
            RSSFeedString = wclient.DownloadString(rssFeedStr);
        }
    }
}
