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
    private ArrayList arrayShapes;
    public TestDrawShapes()
    {
    }

    [Test]
    public void TestDrawAllShapes()
    {
        drawShapes = new DrawShapes();
        shapes = new List<Shape>();
        //shapes = new ArrayList();
        square = new Square();
        circle = new Circle();
        shapes.Add(square);
        shapes.Add(circle);
        drawShapes.DrawAllShapes(shapes);

        Assert.AreEqual("This is a Square!", shapes[0].GetShapeDraw());
        Assert.AreEqual("This is a Circle!", shapes[1].GetShapeDraw());
    }

    [Test]
    public void TestDrawAllArrayShapes()
    {
        drawShapes = new DrawShapes();
        arrayShapes = new ArrayList();
        square = new Square();
        circle = new Circle();
        arrayShapes.Add(square);
        arrayShapes.Add(circle);
        drawShapes.DrawAllShapes(arrayShapes);

        Assert.AreEqual(typeof(Circle), arrayShapes[0].GetType());
        Assert.AreEqual(typeof(Square), arrayShapes[1].GetType());
    }
}