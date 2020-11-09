using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralTests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4,4];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = 4 * i + j+1;
                    Console.Write(array[i,j] + "  ");
                }
                Console.WriteLine("\n");
            }
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += array[i, i];
            }

            Console.WriteLine("sum is: " + sum);
        }



    }
}
