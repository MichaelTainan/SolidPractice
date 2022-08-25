using System;
using System.Collections;

namespace SolidPractice.OCP;

public class DrawShapes
{
    public DrawShapes()
    {
    }

    public void DrawAllShapes(IList<Shape> shapes)
    {
        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}
