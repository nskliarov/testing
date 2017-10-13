using System;
using System.Collections.Generic;

namespace ListObjectsWithConstructorSimple
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public Person(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }

        public string FullName { get => $"{LastName}, {FirstName}"; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> presidents = new List<Person>
            {
                new Person("George", "Washington"),
                new Person("John", "Adams"),
                new Person("Thomas", "Jefferson"),
                new Person("James", "Madison"),
                new Person("James", "Monroe")
            };

            foreach (var p in presidents)
            {
                Console.WriteLine(p.FullName);
            }
            Console.ReadKey();
        }
    }
}


