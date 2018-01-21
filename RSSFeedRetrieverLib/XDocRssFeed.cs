using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RSSFeedRetrieverLib
{
    public class XDocRssFeed : IXDocRssFeed
    {
        public XDocument RSSFeedXML { get; set; }

        public XDocRssFeed(String feedString)
        {
            RSSFeedXML = XDocument.Parse(feedString);
        }

        public XDocRssFeed(IRssFeedStrFetcher rSSstrFetcher)
        {
            RSSFeedXML = XDocument.Parse(rSSstrFetcher.RSSFeedString);
        }
    }
}
