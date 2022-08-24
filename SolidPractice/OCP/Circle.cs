using System;
namespace SolidPractice.OCP;

public class Circle : Shape
{
    private string drawcomment="";
    public Circle()
    {
    }

    public void Draw()
    {
        drawcomment = "This is a Circle!";
    }

    public string GetShapeDraw()
    {
        return drawcomment;
    }
}

