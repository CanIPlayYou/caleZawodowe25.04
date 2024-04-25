using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Element 1");
            queue.Enqueue("Element 2");
            queue.Enqueue("Element 3");

            Console.WriteLine("Zawartość kolejki: ");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            string usunietyElement = queue.Dequeue();
            Console.WriteLine($"\nUsuniety element: {usunietyElement}");


            Console.WriteLine("\nZawartość kolejki po usunieciu: ");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
