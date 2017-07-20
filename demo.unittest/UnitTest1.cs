using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Shapes;

namespace demo.unittest
{
    [TestClass]
    public class ShapeTests
    {
        Shape s;
        [TestInitialize]
        public void TestInit()
        {
            s = new Shape(4, 2);
        }
        [TestMethod]
        public void TestAreaIsCorrect()
        {
            //arrange
            double actual;
            double expect = 8.0;

            //act
            actual = s.Area();

            //assert
            Assert.AreEqual(expect, actual);


        }
        //[TestMethod]
        //[TestCategory("Exceptions")]
        //[ExpectedException(typeof(ShapeZeroAreaException))]
        //public void TestAreaThrowsException()
        //{
        //    //arrange
        //    double actual;
        //    double expect = 0.0;

        //    //act
        //    actual = s.Area();

        //    //assert
        //    Assert.AreEqual(expect, actual);


        //}

        public void TestCleanup()
        {
            
        }
    }
}
