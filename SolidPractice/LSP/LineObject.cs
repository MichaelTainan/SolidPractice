using System;
using System.Drawing;

namespace SolidPractice.LSP
{
    public class LineObject
    {
        private Point p1;
        private Point p2;

        public Point P1
        {
            get { return p1; }
            //set { this.p1 = value; }
        }

        public Point P2
        {
            get { return p2; }
            //set { this.p2 = value; }
        }

        public LineObject(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public double? Slope
        {
            get { return TwoPointForm(p1, P2); }
        }

        public double? YIntercept
        {
            get { return PointSlopeForm(p1); }
        }

        public virtual bool IsOn(Point p)
        {
            if (Slope == null)
                return isEqualP1XWhenSlopeNull(p);
            else
                return IsEqualYIntercept(p);
        }

        private bool isEqualP1XWhenSlopeNull(Point p)
        {
            if (p.X == p1.X)
                return true;
            else
                return false;
        }

        private bool IsEqualYIntercept(Point p)
        {
            if (PointSlopeForm(p) == YIntercept)
                return true;
            else
                return false;
        }

        private double? PointSlopeForm(Point p)
        {
            return Slope == null ? null : Slope * (-1 * p.X) + p.Y;
        }

        private double? TwoPointForm(Point p1, Point P2)
        {
            return (p2.X - p1.X) == 0 ? null : (double)(p2.Y - p1.Y) / (p2.X - p1.X);
        }
    }
}

