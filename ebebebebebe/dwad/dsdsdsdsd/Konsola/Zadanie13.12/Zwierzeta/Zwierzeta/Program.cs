using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzeta
{
    internal class Program
    {
        class Animal
        {
            private string name;

            public Animal(string name)
            {
                this.name = name;
            }

            public string GetName()
            {
                return name;
            }

            public virtual void Voice()
            {
                Console.WriteLine("");
            }

            public virtual void Eating()
            {
                Console.WriteLine("");
            }
        }

        class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }

            public override void Voice()
            {
                Console.WriteLine("HauHau");
            }

            public override void Eating()
            {
                Console.WriteLine("PiesJe");
            }
        }

        class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
            }

            public override void Voice()
            {
                Console.WriteLine("MiauMiau");
            }

            public override void Eating()
            {
                Console.WriteLine("KotJe");
            }
        }

        static void Main(string[] args)
        {
            Dog doog = new Dog("Pies");

            Console.WriteLine("\n"+ doog.GetName());
            doog.Voice();
            doog.Eating();


            ////


            Cat caat = new Cat("Kot");
            
            Console.WriteLine("\n"+ caat.GetName());
            caat.Voice();
            caat.Eating();

            Console.ReadKey();

        }
    }
}
