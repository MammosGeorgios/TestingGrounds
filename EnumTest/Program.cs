using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void Main(string[] args)
        {
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;

            Console.WriteLine($"Sun is {x}");
            Console.WriteLine($"Fri is {y}");
        }
    }
}
