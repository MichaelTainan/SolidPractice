using System.Drawing;

namespace SolidPractice.LSP
{
    public class LineSegment:LineObject
    {

        public LineSegment(Point p1, Point p2) : base(p1, p2) { }

        public double Length
        {
            get { return Math.Sqrt(Math.Pow((P2.Y - P1.Y), 2) + Math.Pow((P2.X - P1.X), 2)) ; }
        }


        public override bool IsOn(Point p)
        {
            if (LineSegmentCrossYAxis()==false)
                return false;            
            else
                return base.IsOn(p);
        }
        
        private bool LineSegmentCrossYAxis()
        {
            if ((P1.X > 0 && P2.X > 0) || (P1.X < 0 && P2.X < 0))
                return false;
            else
                return true;
        }
    }
}