namespace SolidPractice.SRP;
public class GraphicalRectangle:Rectangle
{
    //public int GetWidth()
    //{ return base.Width; }
    //public void SetWidth(int value)
    //{
    //    base.Width = value;
    //}

    //public int GetHeight()
    //{ return base.Height; }
    //public void SetHeight(int value)
    //{ base.Height = value; }

    public GraphicalRectangle()
    {
    }

    public void Draw(int width, int height)
    {
        base.Width=width;
        base.Height=height;
    }
}

