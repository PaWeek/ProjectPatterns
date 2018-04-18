namespace Decorator
{
    public class DrinkWithMilk : Drink
    {
        private Drink drink;
        public DrinkWithMilk(Drink drink)
        {
            this.drink = drink;
        }

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