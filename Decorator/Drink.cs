using System;

namespace Decorator
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