using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Point centerOfTriangle = new Point(10.0f, 10.0f);
            RegularTriangle regularTriangle = new RegularTriangle(centerOfTriangle, 5.0f);
            Client.DisplayInformationsAboutFigure(regularTriangle);

            Point centerOfRectangle = new Point(10.0f, 20.0f);
            RegularRectangle regularRectangle = new RegularRectangle(centerOfRectangle, 5.0f);
            Client.DisplayInformationsAboutFigure(regularRectangle);
        }
    }
}
