namespace SolidPractice;
public class Rectangle
{
    private int width;
    private int height;
    public int Width
    {
        set { this.width = value; }
        get { return width; }
    }
    public int Height
    {
        get { return height; }
        set { this.height = value; }
    }

    public Rectangle()
    {
    }

    public void Draw(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public int Area()
    {
        return width * height;
    }
}

