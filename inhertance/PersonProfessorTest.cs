using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance
{
    public static class PersonProfessorTest
    {
       public static  void Test()
        {
            Person person = new Person();
            person.Great();

            Student Student = new Student();
            Student.setAge(10);
            Student.Great();
            Student.ShowAge();

            Professor Professor = new Professor();
            Professor.setAge(10);
            Professor.Great();
            Professor.Explain();
        }
    }
}
