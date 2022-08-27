using System;
using System.Drawing;

namespace SolidPractice.LSP;

public class Line:LineObject
{
    public Line(Point p1, Point p2) : base(p1, p2) { }

    public override bool IsOn(Point p)
    {
        return base.IsOn(p);
    }
}

