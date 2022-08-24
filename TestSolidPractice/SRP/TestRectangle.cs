using SolidPractice.SRP;

namespace TestSolidPractice;

[TestFixture]
public class TestRectangle
{
    private Rectangle rectangle;

    [SetUp]
    public void Setup()
    {
        rectangle = new Rectangle();
    }

    //[Test]
    //public void TestDraw()
    //{
    //rectangle.Draw(2,3); 
    //    Assert.AreEqual(2, rectangle.Width);
    //    Assert.AreEqual(3, rectangle.Height);
    //}

    //[Test]
    //public void TestWidth()
    //{
    //    rectangle.Width =5;
    //    Assert.AreEqual(5, rectangle.Width);
    //}
}
