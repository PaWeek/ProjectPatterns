namespace Facade
{
    public class DrinkWithSugar : DrinkWithAddition
    {
        private bool brownSugar;
        public DrinkWithSugar(Drink drink, bool brownSugar = false) : base(drink)
        {
            this.brownSugar = brownSugar;
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