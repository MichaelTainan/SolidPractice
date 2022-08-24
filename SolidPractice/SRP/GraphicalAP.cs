using System;
namespace SolidPractice.SRP;

public class GraphicalAP
{
    private GraphicalRectangle graphicalRectangle;
    public GraphicalAP()
    {
        graphicalRectangle = new GraphicalRectangle();
    }

    public double GetRectangleHeight()
    {
        return graphicalRectangle.Height;
    }

    public double GetRectangleWidth()
    {
        return graphicalRectangle.Width;
    }

    public void RectangleDraw(int width, int height)
    {
        graphicalRectangle.Draw(width, height);
    }
}

