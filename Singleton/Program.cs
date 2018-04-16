using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog.Initialize();

            Class instantion = new Class();

            Random random = new Random();
            for(int i = 0; i < 10; ++i)
            {
                int drawnnumber = random.Next();

                //EventLog log = new EventLog();
                //log.AddEvent("The number was drawn " + drawnnumber.ToString());
                EventLog.AddEvent("The number was drawn " + drawnnumber.ToString());
            }
        }
    }
}
