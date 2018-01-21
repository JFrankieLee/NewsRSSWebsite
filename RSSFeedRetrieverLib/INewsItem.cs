using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedRetrieverLib
{
    public interface INewsItem
    {
        String Title { get; set; }

        String Link { get; set; }

        String Description { get; set; }

        String PubDate { get; set; }
    }
}
