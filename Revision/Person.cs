using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        private string Name { get; set; }


        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        ~Person(){
            Console.WriteLine("I am Here");
            Name = default;
        }
    }
}
