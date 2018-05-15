namespace Facade
{
    public class Caffe : Drink
    {
        public override decimal Cost()
        {
            return 5.50M;
        }

        public override string ToString()
        {
            return "Caffe";
        }
    }
}