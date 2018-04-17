using System;

namespace Adapter
{
    public class Client
    {
        public static void DisplayInformationsAboutFigure(IRegularPolygon regularPolygon)
        {
            regularPolygon.DisplayFigureName();
            Console.WriteLine(":");
            regularPolygon.DisplayParameters();
            Console.WriteLine("Circuit: " + regularPolygon.CalculateCircuit());
            Console.WriteLine("Field: " + regularPolygon.CalculateField());
            Console.WriteLine();
        }
    }
}