namespace Facade
{
    public abstract class DrinkWithAddition : Drink
    {
        protected Drink drink;

        public DrinkWithAddition(Drink drink)
        {
            this.drink = drink;
        }
    }
}