using System;
using SolidPractice;

namespace TestSolidPractice
{
    [TestFixture]
    public class TestComputationalGeometry
    {
        public TestComputationalGeometry()
        {
        }

        [Test]
        public void TestDraw()
        {
            ComputationalGeometry computationalGeometry = new ComputationalGeometry();
            computationalGeometry.setRectangleWidth(5);
            //Console.WriteLine("Width=" + computationalGeometry.getRectangleWidth());
            computationalGeometry.setRectangleHeight(2);
            //Console.WriteLine("Height=" + computationalGeometry.getRectangleHeight());
            Assert.AreEqual(10, computationalGeometry.GetRectangleArea());
        }
    }
}

