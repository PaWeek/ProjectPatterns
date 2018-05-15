namespace Facade
{
    public class DrinkWithLemon : DrinkWithAddition
    {
        public DrinkWithLemon(Drink drink) : base(drink)
        {}

        public override decimal Cost()
        {
            return drink.Cost() + 0.2M;
        }

        public override string ToString()
        {
            return drink.ToString() + " with lemon";
        }
    }
}