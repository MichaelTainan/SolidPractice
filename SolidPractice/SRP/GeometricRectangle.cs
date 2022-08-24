namespace SolidPractice.SRP;

public class GeometricRectangle:Rectangle
{
    //private int width;
    //private int height;
    //public int Width
    //{
    //    set { this.width = value; }
    //    get { return width; }
    //}
    //public int Height
    //{
    //    get { return height; }
    //    set { this.height = value; }
    //}

    public GeometricRectangle()
    {
    }

    public int Area()
    {
        return Width * Height;
    }
}

