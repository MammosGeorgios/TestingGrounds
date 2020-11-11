using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "a,b,c,d,e,f,g";
            string[] array = s1.Split(',');

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            s1.Reverse();
            array.Reverse();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(s1);
        }
    }
}
