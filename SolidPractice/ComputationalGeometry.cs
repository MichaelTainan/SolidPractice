namespace SolidPractice;

public class ComputationalGeometry
{
    private Rectangle rectangle = new Rectangle();

    public int GetRectangleArea()
    {
        return rectangle.Area();
    }

    public int getRectangleWidth()
    {
        return rectangle.Width;
    }

    public int getRectangleHeight()
    {
        return rectangle.Height;
    }

    public void setRectangleHeight(int height)
    {
        rectangle.Height = height;
    }

    public void setRectangleWidth(int width)
    {
        rectangle.Width = width;
    }
}
