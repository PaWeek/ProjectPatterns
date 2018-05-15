namespace Facade
{
    public static class DrinksMenu
    {
        public static Drink GingerbreadCaffe()
        {
            Drink drink = new Caffe();
            drink = new DrinkWithCinnamon(drink);
            drink = new DrinkWithSugar(drink);
            return drink;
        }

        public static Drink TeaWithLemon(int numberOfLemonSlices = 1)
        {
            Drink drink = new Tea();

            for(int i = 1; i <= numberOfLemonSlices; i++)
            {
                drink = new DrinkWithLemon(drink);
            }
            
            return drink;
        }
    }
}