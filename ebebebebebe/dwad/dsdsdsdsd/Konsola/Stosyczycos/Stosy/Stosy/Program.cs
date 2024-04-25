using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stosy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine("Zawartość stosu: ");

            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }

            int usunietaLiczba = stack.Pop(); //Usuwa ostatnio dodana liczbe czyli według stosu pierwszą liczbe
            Console.WriteLine($"\nUsunięto ze stosu: {usunietaLiczba}");


            Console.WriteLine("\nZawartość stosu po usunięciu: ");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
