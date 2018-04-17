namespace Adapter
{
    public interface IRegularPolygon
    {
        Point Center { get; }
        int NumberOfSides { get; }
        float LengthOfSides { get; }

        void DisplayParameters();
        void DisplayFigureName();
        float CalculateCircuit();
        float CalculateField();
    }
}