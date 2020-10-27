using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 50; i++)
            {
                list.Add(r.Next(-100, 100));
            }

            Console.WriteLine("Largest number in the list is {0}", FindMax(list));

        }
        static int FindMax(List<int> list)
        {
            int result = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > result) result = list[i];
            }

            return result;
        }
        static int FindMaxNegative(List<int> list)
        {
            int result = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > result && list[i] < 0) result = list[i];
            }

            return result;
        }

        static int FindMaxPositive(List<int> list)
        {
            int result = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > result && list[i] > 0) result = list[i];
            }

            return result;
        }


    }
}
