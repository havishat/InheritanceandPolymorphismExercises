using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace inheritanceandpolyTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestPrgramGetShapeArea()
        {
            var radius = 10;
            var circle = new inheritanceandpoly.Circle(radius);
            var expectedArea = Math.PI * radius * radius;

            var Height = 5;
            var width = 5;
            var expectedArea2 = Height * width;
            var r = new inheritanceandpoly.Rectangle(null, Height, width);

            var actual1 = inheritanceandpoly.Program.GetShapeArea(circle);
            var actual2 = inheritanceandpoly.Program.GetShapeArea(r);

            //assert 
            Assert.AreEqual(expectedArea, actual1);
            Assert.AreEqual(expectedArea2, actual2);

        }
    }
}
