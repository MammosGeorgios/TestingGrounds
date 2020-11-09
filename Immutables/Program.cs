using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutables
{
    class Program
    {
        private static readonly int _myVar = 20;

        static Program()
        {
            Console.WriteLine(_myVar);
            _myVar = 30;
            Console.WriteLine(_myVar);
        }

        public Program()
        {
            Console.WriteLine(_myVar+1);
            //_myVar = 40;
            Console.WriteLine(_myVar+1);
        }

        //static Program(int myVar) // static constructor must be parameterless
        //{
        //    _myVar = myVar;
        //}

        public int MyProperty
        {
            get { return _myVar; }
            //set { _myVar = value; }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(_myVar+2);
            
        }
    }
}
