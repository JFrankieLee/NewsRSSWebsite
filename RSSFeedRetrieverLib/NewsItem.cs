using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedRetrieverLib
{
    public class NewsItem : INewsItem
    {
        public String Title { get; set; }

        public String Link { get; set; }

        public String Description { get; set; }

        public String PubDate { get; set; }
    }
}
