using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink tea = new Tea();
            Console.WriteLine(tea.ToString() + " " + tea.Cost());

            Drink teaWithSugar = new DrinkWithSugar(tea);
            Console.WriteLine(teaWithSugar.ToString() + " " + teaWithSugar.Cost());

            Drink caffe = new Caffe();
            Console.WriteLine(caffe.ToString() + " " + caffe.Cost());
           
            Drink caffeWithMilkAndSugar = new DrinkWithSugar(new DrinkWithMilk(caffe));
            Console.WriteLine(caffeWithMilkAndSugar.ToString() + " " + caffeWithMilkAndSugar.Cost());
        }
    }
}
