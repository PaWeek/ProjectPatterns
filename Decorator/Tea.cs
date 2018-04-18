namespace Decorator
{
    public class Tea : Drink
    {
        public override decimal Cost()
        {
            return 5.00M;
        }

        public override string ToString() 
        {
            return "Tea";
        }
    }
}