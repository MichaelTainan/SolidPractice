using System;
namespace SolidPractice.OCP;

public class Square:Shape
{
    private string drawcomment="";

    public Square()
    {
    }

    public void Draw()
    {
        drawcomment = "This is a Square!";
    }

    public string GetShapeDraw()
    {
        return drawcomment;
    }
}

public interface Shape
{
    void Draw();
    string GetShapeDraw();
}