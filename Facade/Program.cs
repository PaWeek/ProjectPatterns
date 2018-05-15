using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink teaWithLemon = DrinksMenu.TeaWithLemon(3);
            Console.WriteLine(teaWithLemon.ToString() + " " + teaWithLemon.Cost());

            Drink GingerbreadCaffe = DrinksMenu.GingerbreadCaffe();
            Console.WriteLine(GingerbreadCaffe.ToString() + " " + GingerbreadCaffe.Cost());           
        }    
    }
}