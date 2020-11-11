using StringManipulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Models
{
    class Exercise1:IExercise1
    {
        private List<int> _numberList;


        public List<int> NumberList
        {
            get { return _numberList; }
            private set { _numberList = value; }
        }

        public Exercise1()
        {
            ExecuteExercise1(6);
            
        }

        public void ExecuteExercise1(int count) 
        {
            int[] array = AskNumbers(count);
            _numberList = new List<int>();
            RandomList(array);
            PrintNumberList();
            Sort(true);
            PrintNumberList();
            Sort(false);
            PrintNumberList();
            PrintSum();



        }

        public int[] AskNumbers(int count)
        {
            Console.WriteLine("Give me {0} intergers\n", count);
            
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = AskSingleNumber();
            }

            return (result);
        }

        public int AskSingleNumber()
        {
            Console.WriteLine("Give me a number");
            int result = 0;
            bool isValidFlag = false;
            string input;
            while (!isValidFlag)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input)) Console.WriteLine("INVALID INPUT, must not be an empty/white space input");
                else
                {
                    if (!Int32.TryParse(input, out result)) Console.WriteLine("INVALID INPUT, must be an interger");
                    else isValidFlag = true;
                }
            }
            return (result);
        }

        public int SingleRandom(int max) 
        {
            Random r = new Random();
            r.Next(max);
            int result = r.Next(max);
            return (result);
        }

        public void RandomList(int[] array) 
        {

            for (int i = 0; i < array.Length; i++)
            {
                _numberList.Add(SingleRandom(array[i]));
            }

        }

        public void PrintNumberList() 
        {
            Console.WriteLine("here is the list");
            for (int i = 0; i < _numberList.Count; i++)
            {
                Console.WriteLine(_numberList[i]);
            }
        }

        public void Sort(bool sort) 
        {
            if (sort) _numberList.Sort();
            else 
            {
                _numberList.Sort();
                _numberList.Reverse();
            }
        }

        public void PrintSum() 
        {
            int result = 0;

            for (int i = 0; i < _numberList.Count; i++)
            {
                result += _numberList[i];
            }

            Console.WriteLine("the sum of the numbers in the list is {0}", result);
        }

        




    }
    
}


