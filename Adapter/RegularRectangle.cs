using System;

namespace Adapter
{
    public class RegularRectangle : RegularPolygon
    {
        private Rectangle rectangle;

        public RegularRectangle(Rectangle rectangle) 
            : base(CalculateCenter(rectangle.topLeftCorner, rectangle.bottomRightCorner), 4,
                CalculateLengthOfSides(rectangle.topLeftCorner, rectangle.bottomRightCorner))
        {
            this.rectangle = rectangle;
        }
        public static Point CalculateCenter(Point topLeftCorner, Point bottomRightCorner)
        {
            return new Point((topLeftCorner.X + bottomRightCorner.X) / 2, (topLeftCorner.Y + bottomRightCorner.Y) / 2);
        }

        public static float CalculateLengthOfSides(Point topLeftCorner, Point bottomRightCorner)
        {
            float width = bottomRightCorner.X - topLeftCorner.X;
            float height = bottomRightCorner.Y - topLeftCorner.Y;

            if(width != height)
            {
                throw new ArgumentException("This rectangle is not regular");
            }
            else 
            {
                return width;
            }
        }

        public override float CalculateField()
        {
            return rectangle.CalculateField();
        }

        public override void DisplayFigureName()
        {
            Console.Write("Regular ");
            rectangle.DisplayFigureName(); 
        }
    }
}