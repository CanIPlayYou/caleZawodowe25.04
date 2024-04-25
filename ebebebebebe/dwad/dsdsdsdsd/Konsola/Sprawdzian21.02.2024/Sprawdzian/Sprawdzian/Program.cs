using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian
{
    //Zad.1.
    class Ksiazka
    {
        public string tytul;
        public string autor;
        public int ISBN;   
    }

    class Biblioteka
    {
        List<string> listaKsiazekv2 = new List<string>();
        
        

        public void dodajKsiazke(string nazwaKsiazki)
        {
            listaKsiazekv2.Add(nazwaKsiazki);
        }

        public void usunKsiazke()
        {
            listaKsiazekv2.Remove(listaKsiazekv2[0]);
        }

        public void wyszukajKsiazke()
        {
            foreach(string name in listaKsiazekv2)
            {
                
            }
        }

        public void wypisanieKsiazek()
        {
            for (int i = 0; i < listaKsiazekv2.Count; i++)
            {
                Console.WriteLine(listaKsiazekv2[i]);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ksiazka ksi = new Ksiazka();
            Biblioteka bib = new Biblioteka();

            bib.dodajKsiazke("nowaKsiazka2");
            bib.dodajKsiazke("nowaKsiazka22");
            bib.wypisanieKsiazek();
            bib.usunKsiazke();

            Console.WriteLine("");

            bib.wypisanieKsiazek();

            Console.ReadKey();
        }
    }
}
