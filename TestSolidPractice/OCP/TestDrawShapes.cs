using System;
using System.Collections;
using SolidPractice.OCP;

namespace TestSolidPractice.OCP;

[TestFixture]
public class TestDrawShapes
{
    private DrawShapes drawShapes;
    private Shape square;
    private Shape circle;
    private IList<Shape> shapes;
    public TestDrawShapes()
    {
    }

    [Test]
    public void TestDrawAllShapes()
    {
        drawShapes = new DrawShapes();
        shapes = new List<Shape>();
        square = new Square();
        circle = new Circle();
        shapes.Add(square);
        shapes.Add(circle);
        drawShapes.DrawAllShapes(shapes);

        Assert.AreEqual("This is a Square!", shapes[0].GetShapeDraw());
        Assert.AreEqual("This is a Circle!", shapes[1].GetShapeDraw());
    }      
}