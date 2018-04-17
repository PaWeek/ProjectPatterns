using System;

namespace Adapter
{
    public abstract class RegularPolygon : IRegularPolygon
    {
        public Point Center { get; private set;}

        public int NumberOfSides { get; private set;}

        public float LengthOfSides { get; private set;}

        protected RegularPolygon(Point center, int numberOfSides, float lengthOfSides)
        {
            Center = center;
            NumberOfSides = numberOfSides;
            LengthOfSides = lengthOfSides;
        }
        public float CalculateCircuit()
        {
            return NumberOfSides * LengthOfSides;
        }

        public abstract float CalculateField();

        public abstract void DisplayFigureName();

        public virtual void DisplayParameters()
        {
            Console.WriteLine("center: (" + Center.X + ", " + Center.Y + "), number of sides: " + NumberOfSides.ToString() + ", length of sides: " + LengthOfSides.ToString());
        }
    }
}