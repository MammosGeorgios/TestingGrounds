using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingUnit
{
    class Example
    {
        public Example()
        {
            RunExample();
        }

        public void RunExample()         
        {

            int a, b;
            AskInputs(out a, out b);

            int c = a + b;
            if (c > 100) Console.WriteLine("it's done");
            
        }

        public void AskInputs(out int a, out int b)
        {

            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

        }

    }
}
