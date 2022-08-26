using System.Drawing;

namespace SolidPractice.LSP
{
    public class LineSegment:Line
    {
        private Point p1;
        private Point p2;

        public LineSegment(Point p1, Point p2) : base(p1, p2) { }
        //{
        //    this.p1 = p1;
        //    this.p2 = p2;
        //}
        public override bool IsOn(Point p)
        {
            return base.IsOn(p);
        }
    }
}