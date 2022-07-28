using System;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalNo = 3;

            Console.WriteLine("Enter Names Please : ");

            Person[] people = new Person[TotalNo];
            for (int i = 0; i < TotalNo; i++)
            {
                people[i] = new Person(Console.ReadLine());
            }
            
       
            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
