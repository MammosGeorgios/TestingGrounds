using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifecycle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shallow Copy example!
            Dummy d1 = new Dummy(1, 1);
            Dummy d2 = new Dummy(2, 2);

            d1.PrintMe();
            d2.PrintMe();

            d2 = d1;
            d2.PrintMe();
            d1.Prop1 = 3;
            d2.PrintMe(); // d2 is also affected!
        }
    }

    public class Dummy
    {
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }

        public Dummy(int x,int y)
        {
            Prop1 = x;
            Prop2 = y;
        }

        public void PrintMe()
        {
            Console.WriteLine($"{Prop1} - {Prop2}");
        }
    }
}

