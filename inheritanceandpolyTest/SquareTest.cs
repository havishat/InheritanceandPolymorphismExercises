using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace inheritanceandpolyTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void SquareTestCont()
        {
            var expectedLenght = 5;
            var expectedPoint = new inheritanceandpoly.Point(1, 2);
            var expectedName = "Square";

            var s = new inheritanceandpoly.Square(expectedPoint, expectedLenght);

            //Assert
            Assert.AreEqual(expectedPoint, s.TopLeft);
            Assert.AreEqual(expectedLenght, s.Width);
            Assert.AreEqual(expectedLenght, s.Height);

            Assert.AreEqual(expectedName, s.Name);
        }

        [TestMethod]
        public void TestSquareeArea()
        {
            var Width = 5;
            var expectedArea = Width * Width;

            var s = new inheritanceandpoly.Square(null, Width);

            //act
            var actual = s.Area;

            //Assert

            Assert.AreEqual(expectedArea, actual);
        }


        [TestMethod]
        public void TestRectangleEqual()
        {
            
            var expectedWidth = 10;
            var p1 = new inheritanceandpoly.Point(1, 2);
            var p2 = new inheritanceandpoly.Point(1, 2);

            var s1 = new inheritanceandpoly.Square(p1, expectedWidth);
            var s2 = new inheritanceandpoly.Square(p2, expectedWidth);
            var s3 = new inheritanceandpoly.Shape();

            //Assert

            Assert.AreEqual(s1, s2);
            Assert.AreNotEqual(s2, s3);
        }


    }
}
