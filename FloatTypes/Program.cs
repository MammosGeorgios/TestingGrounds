using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double testNumber = 1.0 / 0.0;
            Console.WriteLine(testNumber);

            if(testNumber == Double.PositiveInfinity) Console.WriteLine("Positive Infinite!!!");
            
            


        }
    }
}
