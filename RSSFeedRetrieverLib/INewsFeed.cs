using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedRetrieverLib
{
    public interface INewsFeed
    {
        List<INewsItem> News { get; set; }
    }
}
