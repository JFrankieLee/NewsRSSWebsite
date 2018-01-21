using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Xml.Linq;

namespace RSSFeedRetrieverLib.Tests
{
    [TestFixture]
    class XDocRSSFeedTests
    {
        [Test]
        public void ReturnsXMLDoc()
        {
            String rssFdStrng = System.IO.File.ReadAllText(@"C:\Users\James\Documents\Dev\books.txt");

            IXDocRssFeed xDocFeed = new XDocRssFeed(rssFdStrng);

            Assert.IsInstanceOf(typeof(XDocument), xDocFeed.RSSFeedXML);
        }
    }
}
