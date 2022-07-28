using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance
{
    public class Student : Person
    {
        public void Studing()
        {
            Console.WriteLine("I am Studing");
        }

        public void ShowAge()
        {
            Console.WriteLine("my age is " + this.Age);
        }

    }
}
