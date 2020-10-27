using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            FillArrayWithOnes(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void FillArrayWithOnes(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1;
            }
        }
    }
}
