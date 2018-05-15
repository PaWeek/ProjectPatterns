namespace Facade
{
    public class DrinkWithMilk : DrinkWithAddition
    {   
        public DrinkWithMilk(Drink drink) : base(drink)
        {}

        public override decimal Cost()
        {
            return drink.Cost() + 0.30M;
        }

        public override string ToString()
        {
            return drink.ToString() + " with milk";
        }
    }
}