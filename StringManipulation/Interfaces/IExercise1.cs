using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Interfaces
{
    interface IExercise1
    {

        int[] AskNumbers(int count);
        void RandomList(int[] array);
        void PrintNumberList();
        void Sort(bool sort);
        void PrintSum();

    }
}
