using System;
using System.Drawing;
using SolidPractice.LSP;

namespace TestSolidPractice.LSP;

[TestFixture]
public class TestLine
{
    private Line line;
    private Point p1;
    private Point p2;
    private LineSegment lineSegment;
    public TestLine()
    {
    }

    [Test]
    public void TestLinePointCheck()
    {
        p1 = new Point(1, 1);
        p2 = new Point(2, 0);
        line = new Line(p1, p2);
        //line.IsOn(p1);
        lineSegment = new LineSegment(p1, p2);
        Assert.AreEqual(p1, line.P1);
        Assert.AreEqual(p2, line.P2);
        //Assert.IsNull(line.Slope);
        //Assert.IsNull(line.YIntercept);
        Assert.AreEqual(-1, line.Slope);
        Assert.AreEqual(2, line.YIntercept);
        Assert.IsTrue(lineSegment.IsOn(new(3,-1)));
    }        
}
