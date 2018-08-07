using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace inheritanceandpolyTest
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void TestPointEquals()
        {
            var p1 = new inheritanceandpoly.Point(1, 2);
            var p2 = new inheritanceandpoly.Point(1, 2);

            var areEqual = p1.Equals(p2);

            Assert.IsTrue(areEqual);
        }
    }
}
