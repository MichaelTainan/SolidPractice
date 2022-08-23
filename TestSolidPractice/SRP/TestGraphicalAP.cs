using SolidPractice.SRP;

namespace TestSolidPractice;

[TestFixture]
public class TestGraphicalAP
{
    private GraphicalAP graphicalAP;

    public TestGraphicalAP()
    {
    }

    [SetUp]
    public void Setup()
    {
        graphicalAP = new GraphicalAP();
    }

    [Test]
    public void TestDraw()
    {
        graphicalAP.RectangleDraw(2, 3);
        Assert.AreEqual(2, graphicalAP.GetRectangleWidth());
        Assert.AreEqual(3, graphicalAP.GetRectangleHeight());
    }
}