using System;
using System.Collections;

namespace SolidPractice.OCP;

public class DrawShapes
{
    //private Square square;
    //private Circle circle;
    //private IList<Shape> shapes;
    public DrawShapes()
    {
    }

    public void DrawAllShapes(IList shapes)
    {
        foreach (Shape shape in shapes)
        {
            shapes.Draw();
        }
    }

    //public IList getShapeList()
    //{
    //    return shapes;
    //}
}
