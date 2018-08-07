using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace inheritanceandpolyTest
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void TestShapeToString()
        {
            var c = new inheritanceandpoly.Circle(null, 0);
            var expected = "Circle";

            var actual = c.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
