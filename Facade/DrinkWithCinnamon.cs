namespace Facade
{
    public class DrinkWithCinnamon : DrinkWithAddition
    {

        public DrinkWithCinnamon(Drink drink) : base(drink)
        {}

        public override decimal Cost()
        {
            return drink.Cost() + 0.5M;
        }

        public override string ToString()
        {
            return drink.ToString() + " with a pinch of cinnamon";
        }
    }
}