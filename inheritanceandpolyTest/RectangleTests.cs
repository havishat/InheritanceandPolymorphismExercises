using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace inheritanceandpolyTest
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestRectangleCont()
        {
            var expectedHeight = 5;
            var expectedWidth = 10;
            var expectedPoint = new inheritanceandpoly.Point(1, 2);
            var expectedName = "Rectangle";

            var r = new inheritanceandpoly.Rectangle(expectedPoint, expectedWidth, expectedHeight);

            //Assert
            Assert.AreEqual(expectedPoint, r.TopLeft);
            Assert.AreEqual(expectedWidth, r.Width);
            Assert.AreEqual(expectedHeight, r.Height);

            Assert.AreEqual(expectedName, r.Name);
        }

        [TestMethod]
        public void TestRectangleArea()
        {
            var Height = 5;
            var Width = 10;
            var expectedArea = Width * Height;

            var r = new inheritanceandpoly.Rectangle(null, Width, Height);

            //act
            var actual = r.Area;

            //Assert

            Assert.AreEqual(expectedArea, actual);
        }

        [TestMethod]
        public void TestRectangleEqual()
        {
            var expectedHeight = 5;
            var expectedWidth = 10;
            var p1 = new inheritanceandpoly.Point(1, 2);
            var p2 = new inheritanceandpoly.Point(1, 2);

            var r1 = new inheritanceandpoly.Rectangle(p1, expectedWidth, expectedHeight);
            var r2 = new inheritanceandpoly.Rectangle(p2, expectedWidth, expectedHeight);
            var r3 = new inheritanceandpoly.Shape();

            //Assert

            Assert.AreEqual(r1, r2);
            Assert.AreNotEqual(r2, r3);
        }


    }
}
