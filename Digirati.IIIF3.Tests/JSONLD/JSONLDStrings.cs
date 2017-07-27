using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digirati.IIIF3.Model.JSONLD;
using NUnit.Framework;

namespace Digirati.IIIF3.Tests.JSONLD
{
    [TestFixture]
    public class JSONLDStrings
    {
        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void TestStrings()
        {
            JSONLDString jss = "no language string";
            jss["fr"] = "sans langue";
            Assert.IsTrue(jss == "no language string");
            Assert.AreEqual(jss, "no language string");
            Assert.AreEqual(jss["fr"], "sans langue");
            Assert.AreEqual(jss[""], "no language string");
        }
    }
}
