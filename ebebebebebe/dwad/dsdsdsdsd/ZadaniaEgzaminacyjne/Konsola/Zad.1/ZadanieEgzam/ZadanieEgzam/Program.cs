using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieEgzam
{
    internal class Program
    {
        class Osoba
        {
            private int id;
            private string imie;
            public static int liczba_instancji = 0;

            public Osoba()
            {
                id = 0;
                imie = "";

                Osoba.liczba_instancji += 1;
            }

            public Osoba(int id, string imie)
            {
                this.id = id;
                this.imie = imie;

                Osoba.liczba_instancji += 1;
            }

            public Osoba(Osoba osoba) //Konstuktor kopiujący
            {
                this.id = osoba.id;
                this.imie = osoba.imie;

                Osoba.liczba_instancji += 1;
            }

            public void Przywitanie(string name)
            {
                if(this.imie != "")
                {
                    Console.WriteLine("Cześć "+ name +" mam na imię "+ this.imie);
                }
                else
                {
                    Console.WriteLine("Brak danych");
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Liczba zarejestrowanych osób to: "+ Osoba.liczba_instancji);

            Osoba osoba1 = new Osoba();
            osoba1.Przywitanie("Jan");

            Osoba osoba2 = new Osoba(2, "Adam");
            osoba2.Przywitanie("Jan");

            Osoba osoba3 = new Osoba(osoba2);
            osoba3.Przywitanie("Jan");

            Console.WriteLine("Liczba zarejestrowanych osób to: " + Osoba.liczba_instancji);

            Console.ReadKey();
        }
    }
}
