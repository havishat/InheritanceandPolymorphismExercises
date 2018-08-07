using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace inheritanceandpolyTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestCircle()
        {
            var expectedCenter = new inheritanceandpoly.Point(1, 2);
            var expectedRadius = 5;
            var expectedName = "Circle";

            var c = new inheritanceandpoly.Circle(expectedCenter, expectedRadius);

            //Assert
            Assert.AreEqual(expectedCenter, c.Center);
            Assert.AreEqual(expectedRadius, c.Radius);
            Assert.AreEqual(expectedName, c.Name);
       }


        [TestMethod]

        public void TestCircleArea()
        {
            var expectedRadius = 5;
            var center = new inheritanceandpoly.Point(1, 2);
            var expectedArea = Math.PI * expectedRadius * expectedRadius;

            var c = new inheritanceandpoly.Circle(center, expectedRadius);

            //act
            var actual = c.Area;

            //Assert

            Assert.AreEqual(expectedArea, actual);
        }

        [TestMethod]
        public void TestCircleEquals()
        {
            var p1 = new inheritanceandpoly.Point(1, 2);
            var p2 = new inheritanceandpoly.Point(1, 2);

            var c3unequal = new inheritanceandpoly.Circle(new inheritanceandpoly.Point(2, 2), 23894723);
            var expectedRadius = 5;

            var c5 = new inheritanceandpoly.Shape();

            var c1 = new inheritanceandpoly.Circle(p1, expectedRadius);
            var c2 = new inheritanceandpoly.Circle(p2, expectedRadius);
            var c4 = new inheritanceandpoly.Circle(null, expectedRadius);
            //Assert

            Assert.AreEqual(c1,c2);

            Assert.AreNotEqual(c2, c3unequal);
            Assert.AreEqual(c2, c1);
            Assert.AreNotEqual(c2, c5);
           
        }

        [TestMethod]

        public void TestCicleConstructors()
        {
            var p = new inheritanceandpoly.Point(1, 2);
            var expectedPoint = new inheritanceandpoly.Point(0, 0);
            int r1 = 5;
            float r2 = 6.0f;
            double r3 = 2.5;

            //act
            var c1 = new inheritanceandpoly.Circle(p, r1);
            var c2 = new inheritanceandpoly.Circle(p, r2);
            var c3 = new inheritanceandpoly.Circle(r3);

            // assert 
            Assert.AreEqual(p, c1.Center);
            Assert.AreEqual(r1, c1.Radius);
            Assert.AreEqual(p, c2.Center);
            Assert.AreEqual(r2, c2.Radius);
            Assert.AreEqual(expectedPoint, c3.Center);
            Assert.AreEqual(r3, c3.Radius);

        }

    }
}
