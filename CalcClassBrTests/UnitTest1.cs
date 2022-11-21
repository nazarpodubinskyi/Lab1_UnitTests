using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml;

namespace CalcClassBr.Tests
{
    [TestClass]
    public class CalcClassTests
    {
        public TestContext TestContext { get; set; }

       
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Program Files\Calculator1\CalcClassBrTests\TestData.xml", "data", DataAccessMethod.Sequential)]
        public void TestMultiplicateMethodFromCalculator()
        {
            //Arrange
            long a = long.Parse(TestContext.DataRow["a"].ToString());
            long b = long.Parse(TestContext.DataRow["b"].ToString());
            long expected = long.Parse(TestContext.DataRow["expected"].ToString());

            //Act
            var result = CalcClass.Mult(a, b);
            var reversed = CalcClass.Mult(b, a);

            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected, reversed);
        }
    }
}//max 