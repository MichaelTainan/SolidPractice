using System;
using System.Drawing;
using SolidPractice.LSP;

namespace TestSolidPractice.LSP;

[TestFixture]
public class TestLine
{
    private LineObject line;
    private Point p1;
    private Point p2;
    private LineObject lineSegment;
    public TestLine()
    {
    }

    [SetUp]
    public void Setup()
    {
        p1 = new Point(1, 1);
        p2 = new Point(2, 1);
        line = new Line(p1, p2);
        lineSegment = new LineSegment(p1, p2);
    }

    [Test]
    public void TestLineCheck()
    {       
        //line.IsOn(p1);
        Assert.AreEqual(p1, line.P1);
        Assert.AreEqual(p2, line.P2);
        //Assert.IsNull(line.Slope);
        //Assert.IsNull(line.YIntercept);
        Assert.AreEqual(0, line.Slope);
        Assert.AreEqual(1, line.YIntercept);
        Assert.IsTrue(line.IsOn(new(0, (int)line.YIntercept)));
    }

    [Test]
    public void TestLineSegmentCheck()
    {
        Assert.AreEqual(p1, lineSegment.P1);
        Assert.AreEqual(p2, lineSegment.P2);
        //Assert.IsNull(line.Slope);
        //Assert.IsNull(line.YIntercept);
        Assert.AreEqual(0, lineSegment.Slope);
        Assert.AreEqual(1, lineSegment.YIntercept);
        Assert.IsFalse(lineSegment.IsOn(new(0, (int)lineSegment.YIntercept)));
    }

    [Test]
    /// <summary>
    /// Sometimes LineSegment not cross Y axis, so these IsOn Functions
    /// probably do not equal. Then if LineSegment inherits from Line, It's breaking
    /// LSP rule.
    /// </summary>
    /// <returns></returns>
    public void TestLineAndLineSegmentIsOnFuction()
    {
        Assert.AreNotEqual(line.IsOn(new(0, (int)line.YIntercept)),lineSegment.IsOn(new(0, (int)lineSegment.YIntercept)));
    }
}
