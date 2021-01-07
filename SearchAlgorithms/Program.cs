using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3,1,22,7,5 };

            int result = LinearSearch(array, 71);
            Console.WriteLine(result);
            



        }

        public static int LinearSearch(int[] array, int v)
        {
            int result = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == v)
                {
                    result = i;
                    Console.WriteLine($"Linear search for {v}: Index is {result}");
                }
            }
            return (result);
        }
    }
}
