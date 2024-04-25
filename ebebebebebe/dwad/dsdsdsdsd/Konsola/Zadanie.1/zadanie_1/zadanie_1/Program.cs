using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    internal class Program
    {
        public class Person(string[] firstName, string[] lastName)
        {
            public string[] FirstName { get; }
            public string[] LastName { get; }

            string getFullName()
            {
                string[] firstName = FirstName;
                string[] lastName = LastName;

                return firstName + " " + lastName;
            }

            public static Person constructPerson(string[] firstName, string[] lastName)
            {
                var person = new Person(firstName, lastName);

                return person;
            }
        }

        static void Main(string[] args)
        {
            Person.constructPerson(new string[] {"JANUSZ"}, new string[] {"Chmura"});

            static void familyMembers(string[] lastName, Person[] persons)
            {

            }

            Console.ReadKey();
        }
    }
}
