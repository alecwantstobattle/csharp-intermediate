using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        public class Person
        {
            public string Name;
            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to, Name);
            }

            //public Person Parse(string str)
            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;

                return person;
            }
        }

        static void Main(string[] args)
        {
            //var person = new Person();
            //person.Name = "John";
            //person.Introduce("Mosh");

            //var person = new Person();
            //var p = person.Parse("John");

            var person = Person.Parse("John");
            person.Introduce("Mosh");
        }
    }
}
