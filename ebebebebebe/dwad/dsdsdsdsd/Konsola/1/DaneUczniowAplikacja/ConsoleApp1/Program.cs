using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Person
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string Klasa { get; set; }
            public int Semestr { get; set; }
            public List<string> Oceny { get; set; }
            public string Pesel { get; set; }
            public string Zdjecie { get; set; }
        }

        static void Main(string[] args)
        {
            string text = File.ReadAllText("daneUczniowPrzykladowe.json");
            var person = JsonSerializer.Deserialize<Person>(text);

            Console.WriteLine($"Imie: {person.Imie}");
            Console.WriteLine($"Nazwisko: {person.Nazwisko}");
            Console.WriteLine($"Klasa: {person.Klasa}");


            //listaUczniow = JsonConvert.DeserializeObject<List<>>();


        }
    }
}
