using System;
using System.Collections;

namespace SolidPractice.OCP;

// DrawShapes follows OCP, When Other objects are Inherited Shap, just extend, Then
// This class hasn't need to modify.
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

    public void DrawAllShapes(ArrayList shapes)
    {
        shapes.Sort(new ShapeComparer());
        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}
