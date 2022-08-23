using System;
using SolidPractice.SRP;

namespace TestSolidPractice
{
    [TestFixture]
    public class TestComputationalGeometry
    {
        private ComputationalGeometry computationalGeometry;
        public TestComputationalGeometry()
        {
        }

        [SetUp]
        public void Setup()
        {
            computationalGeometry = new ComputationalGeometry();
        }

        [Test]
        public void TestDraw()
        {
            
            computationalGeometry.setRectangleWidth(5);
            //Console.WriteLine("Width=" + computationalGeometry.getRectangleWidth());
            computationalGeometry.setRectangleHeight(2);
            //Console.WriteLine("Height=" + computationalGeometry.getRectangleHeight());
            Assert.AreEqual(10, computationalGeometry.GetRectangleArea());
        }
    }
}

