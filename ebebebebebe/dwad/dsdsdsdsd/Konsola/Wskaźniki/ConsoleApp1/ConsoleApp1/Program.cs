using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*unsafe //We właściwościach projektu w zakładce kompilacji trzeba włączyć kompilacje niebiezpiecznego kodu
            {
                int number = 10;

                int* pointer = &number; //Deklaracja wskaźnika adresem zmiennej

                Console.WriteLine(*pointer);

                int[] numbers = {1, 2, 3, 4, 5, 6};
                fixed(int* ptr = numbers)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine(*(ptr+i));
                    }
                }
            
            }*/
            int x = 15;
            int y = 20;

            Console.WriteLine($"Przed zmianą: x = {x} , y = {y}");

            Swap(ref x, ref y);

            Console.WriteLine($"Po zmianie: x = {x} , y = {y}");
        }

        private static void Swap(ref int x, ref int y)
        {
            unsafe
            {
                fixed (int* ptrA = &x, ptrB = &y)
                {
                    //W języku c#, operator ^ jest operatorem XOR (bitowy XOR)
                    //. Ten operator wykonuje operacje bitowego XOR
                    //na odpowiadających sobie bitach dwóch
                    //liczb całkowitych. Wynikowy bit jest ustawiony,
                    //jeśli odpowiadające bity w dwóch operandach są różne,
                    //a w przeciwnym razie jest wyzerowany. W kontekście przykładu
                    //z zmianą miejscami wartości dwóch zmiennych za pomocą operatora
                    //XOR(^), wyrażenie * ptrA ^ ptrB wykonuje operacje bitowego XOR
                    //Na wartościach, do których wskaźniki ptrA i ptrB wskazują.
                    //To jest część algorytmu XOR swap, który pozwala
                    //na zmianę miejscami wartości dwóch zmiennych
                    //bez użycia zmiennej tymczasowej
                    *ptrA = *ptrA ^ *ptrB;
                    *ptrB = *ptrA ^ *ptrB;
                    *ptrA = *ptrA ^ *ptrB;
                }
            }
        }
    }
}
