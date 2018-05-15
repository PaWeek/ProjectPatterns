using System;

namespace Facade
{
    public abstract class Drink
    {
        public abstract decimal Cost();

        public void Size()
        {
            Console.WriteLine("\nSize: 400ml");
        }
    }
}