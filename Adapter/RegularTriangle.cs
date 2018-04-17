using System;

namespace Adapter
{
    public class RegularTriangle : RegularPolygon
    {
        public RegularTriangle(Point center, float lengthOfSides) : base(center, 3, lengthOfSides)
        {}

        public override float CalculateField()
        {
            return LengthOfSides * LengthOfSides * (float)(Math.Sqrt(3.0)/4.0);
        }

        public override void DisplayFigureName()
        {
            Console.Write("Regular Triangle");
        }
    }
}