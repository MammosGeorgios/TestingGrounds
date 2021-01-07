using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesTests
{
    class Program
    {
        static int myInt; //takes zero as default value
        static bool myBool; //default is false
        static void Main(string[] args)
        {
            Console.WriteLine(myInt);
            Console.WriteLine(myBool);

            string s1 = "Hello ";
            string s2 = s1;
            s1 = "World2";
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
