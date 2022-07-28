using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance
{
    public class Person
    {
        internal int Age { get; set; }
        public void setAge(int age) {
            Age = age;
        }
        public void Great()
        {
            Console.WriteLine("Helow");
        }
    }
}
