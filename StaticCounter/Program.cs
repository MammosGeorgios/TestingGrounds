using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            for (int i = 0; i < 15; i++)
            {
                c1.GetCounter();
            }

            Counter c2 = new Counter();
            for (int i = 0; i < 15; i++)
            {
                c2.GetCounter();
            }

            Counter.counter++;
            Console.WriteLine(Counter.counter);
        }
    }

    public class Counter
    {
        public static int counter;

        public void GetCounter()
        {
            counter++;
            Console.WriteLine( counter);
        }
    }
}
