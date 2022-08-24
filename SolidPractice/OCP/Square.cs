using System;
namespace SolidPractice.OCP;

public class Square:Shape
{
    public Square()
    {
    }

    public void Draw()
    {

    }
}

public interface Shape
{
    void Draw();
    string GetShapeDraw();
}