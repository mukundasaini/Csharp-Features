using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_1._0
{
    internal class PropertyExample
    {
        private int _age;

        public int Age { get { return _age; } set { _age = value; } }

        public PropertyExample()
        {
            Console.WriteLine("*************************PROPERTY**************************");
        }

        public void About()
        {
            Console.WriteLine("A property is a member that provides a flexible mechanism to read, write, or compute the value of a data field");
        }
    }
}
