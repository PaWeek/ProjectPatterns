namespace Decorator
{
    public class DrinkWithSugar : Drink
    {
        private Drink drink;
        private bool brownSugar;
        public DrinkWithSugar(Drink drink, bool brownSugar = false)
        {
            this.brownSugar = brownSugar;
            this.drink = drink;
        }

        public override decimal Cost()
        {
            return drink.Cost() + (brownSugar ? 0.3M : 0.2M);
        }

        public override string ToString()
        {
            return drink.ToString() + " with " + (brownSugar ? "brown" : "white") + " sugar";
        }
    }
}