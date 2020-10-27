using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegressionFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            Console.WriteLine("{0}! = {1}", number, Factorial(number));


        }

        static int Factorial (int n)
        {
            if (n > 1) return n * Factorial(n - 1);
            else return 1;
        }
    }
}
