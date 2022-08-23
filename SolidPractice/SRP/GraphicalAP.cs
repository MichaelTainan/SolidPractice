using System;
namespace SolidPractice.SRP;

public class GraphicalAP
{
    private Rectangle rectangle;
    public GraphicalAP()
    {
        rectangle = new Rectangle();
    }

    public double GetRectangleHeight()
    {
        return rectangle.Height;
    }

    public double GetRectangleWidth()
    {
        return rectangle.Width;
    }

    public void RectangleDraw(int width, int height)
    {
        rectangle.Draw(width, height);
    }
}

