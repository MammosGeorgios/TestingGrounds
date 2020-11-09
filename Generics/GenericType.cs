using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericType<T,U>
    {
        private T myVar;
        private U myU;

        public T MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public U MyPropertyU
        {
            get { return myU; }
            set { myU = value; }
        }

    }
}
