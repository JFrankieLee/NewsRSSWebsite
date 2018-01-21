using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RSSFeedRetrieverLib
{
    public interface IXDocRssFeed
    {
        XDocument RSSFeedXML { get; set; }
    }
}
