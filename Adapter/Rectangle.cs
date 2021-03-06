using System;

namespace Adapter
{
    public class Rectangle
    {
        public Point topLeftCorner { get; protected set; }
        public Point bottomRightCorner { get; protected set; }

        protected float width()
        {
            return bottomRightCorner.X - topLeftCorner.X; 
        }

        protected float height()
        {
            return bottomRightCorner.Y - topLeftCorner.Y;
        }

        public Rectangle( Point topLeftCorner, Point bottomRightCorner)
        {
            this.topLeftCorner = topLeftCorner;
            this.bottomRightCorner = bottomRightCorner;
        }

        public void DisplayFigureName()
        {
            Console.Write("Rectangle");
        }

        public void DisplayParameters()
        {
            Console.WriteLine("Left side: " + topLeftCorner.X + ", top side: " + topLeftCorner.Y + ", width: " + width() + ", Height: " + height());
        }

        public float CalculateField()
        {
            return height() * width();        
        }
    }
}