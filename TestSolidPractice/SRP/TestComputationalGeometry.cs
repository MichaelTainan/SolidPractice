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
            computationalGeometry.setRectangleHeight(2);
            Assert.AreEqual(10, computationalGeometry.GetRectangleArea());
        }
    }
}

