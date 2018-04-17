using System;

namespace Adapter
{
    public class RegularRectangle : Rectangle, IRegularPolygon
    {
        private static Point CalculateTopLeftCorner(Point center, float lengthOfSides)
        {
            return new Point(center.X - lengthOfSides / 2, center.Y - lengthOfSides / 2);
        }

        private static Point CalculateBottomRightCorner(Point center, float lengthOfSides)
        {
            return new Point(center.X + lengthOfSides / 2, center.Y + lengthOfSides / 2);
        }

        public RegularRectangle(Point center, float lengthOfSides) 
            : base(CalculateTopLeftCorner(center, lengthOfSides), CalculateBottomRightCorner( center, lengthOfSides))
        {}

        public Point Center 
        { 
            get
            {
                return new Point((topLeftCorner.X + bottomRightCorner.X) / 2, (topLeftCorner.Y + bottomRightCorner.Y) / 2);
            }
        }

        public int NumberOfSides { get { return 4; } }

        public float LengthOfSides { get { return width(); } }

        public float CalculateCircuit()
        {
            return NumberOfSides * LengthOfSides;
        }

        public new void DisplayParameters()
        {
            Console.WriteLine("center: (" + Center.X + ", " + Center.Y + "), number of sides: " + NumberOfSides.ToString() + ", length of sides: " + LengthOfSides.ToString());
        }

        public new void DisplayFigureName()
        {
            Console.Write("Regular ");
            base.DisplayFigureName(); 
        }
    }
}