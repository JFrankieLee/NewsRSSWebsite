using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RSSFeedRetrieverLib;

namespace RSSFeedRetrieverLib.Tests
{
    [TestFixture]
    class Class1Tests
    {
        [Test]
        public void ReturnsOne()
        {
            //Arrange/Act
            Class1 cOne = new Class1(1);

            //Asert
            Assert.AreEqual(1, cOne.InputInt);
        }

        [Test]
        public void FailsReturnTwo()
        {
            //Arrange/Act
            Class1 cOne = new Class1(1);

            //Asert
            Assert.AreNotEqual(2, cOne.InputInt);
        }
    }
}
