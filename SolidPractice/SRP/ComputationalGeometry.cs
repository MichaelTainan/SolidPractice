namespace SolidPractice.SRP;

public class ComputationalGeometry
{
    private GeometricRectangle geometricRectangle = new GeometricRectangle();

    public int GetRectangleArea()
    {
        return geometricRectangle.Area();
    }

    public int getRectangleWidth()
    {
        return geometricRectangle.Width;
    }

    public int getRectangleHeight()
    {
        return geometricRectangle.Height;
    }

    public void setRectangleHeight(int height)
    {
        geometricRectangle.Height = height;
    }

    public void setRectangleWidth(int width)
    {
        geometricRectangle.Width = width;
    }
}
