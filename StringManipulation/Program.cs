using StringManipulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1 ex1 = new Exercise1();
            Exercise2 ex2 = new Exercise2(ex1.NumberList);
            

        }

        
    }
}
