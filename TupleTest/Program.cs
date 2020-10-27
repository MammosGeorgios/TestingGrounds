using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TupleTest
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var array = new [] { 21321, 234, -234, 234234, 576, -10000 };
            //int minimum, maximum;
            var (minimum, maximum) = FindMinMax(array);

            Console.WriteLine("min is {0} and max is {1}", minimum, maximum);



        }

        static (int min, int max)  FindMinMax(int[] array)
        {
            var min = int.MaxValue;
            var max = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            return (min, max);
        }
        
    }
}
