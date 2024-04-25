using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public struct Contact
        {
            private string _name;
            private string _nazwisko;
            private string _nr_tel;
            private string _email;

            public Contact(string name, string nazwisko, string nr_tel, string email)
            {
                _name = name;
                _nazwisko = nazwisko;
                _nr_tel = nr_tel;
                _email = email;
            }

            public void Wypisz()
            {
                Console.WriteLine("Imię: " + _name + ", Nazwisko: " + _nazwisko + ", nr.telefonu: " + _nr_tel + ", Email: " + _email);
            }
        }

        

        static void Main(string[] args)
        {
            string podaneImie = "";
            string podaneNazwisko = "";
            string podanyNr_tel = "";
            string podannyEmail = "";

            Contact c = new Contact("Janusz", "Chmura", "432-532-123", "testMail@gmail.com");

            c.Wypisz();

            DodajKontakt();

            c = new Contact(podaneImie, podaneNazwisko, podanyNr_tel, podannyEmail);

            c.Wypisz();

            Console.ReadKey();

            void DodajKontakt()
            {
                Console.Write("Wpisz imię: ");
                podaneImie = Console.ReadLine();

                Console.Write("Wpisz nazwisko: ");
                podaneNazwisko = Console.ReadLine();

                Console.Write("Wpisz nr.telefonu: ");
                podanyNr_tel = Console.ReadLine();

                Console.Write("Wpisz email: ");
                podannyEmail = Console.ReadLine();
            }
        }
    }
}
