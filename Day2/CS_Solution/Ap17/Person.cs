using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap17
{
    internal class Person
    {
        private string _id, _name;
        public void Display()
        {
            Console.WriteLine($"Id={_id}, Name={_name}");
        }
        public Person(string id, string name)
        {
            _id = id;
            _name = name;
        }
    }

}
