#include <iostream>
using namespace std;

class Pracownik {
protected:
    string imie = "";
    string nazwisko = "";
    int pensja = 0;

public:
    Pracownik(string pImie, string pNazwisko, int pPensja) {
        imie = pImie;
        nazwisko = pNazwisko;
        pensja = pPensja;
    }

    void Wypisz() {
        cout << "Imie: " << imie << ", Nazwisko: " << nazwisko << ", Pensja: " << pensja << endl;
    }

};

class PracownikBiura : public Pracownik {
public:
    int numerBiura = 0;
    using Pracownik::Pracownik;

    PracownikBiura(string pImie, string pNazwisko, int pPensja, int pNumerBiura) : Pracownik(pImie, pNazwisko, pPensja), numerBiura(pNumerBiura) {

    }

    void WypiszPB() {
        cout << "Imie: " << imie << ", Nazwisko: " << nazwisko << ", Pensja: " << pensja << ", Nr. Biura: " << numerBiura << endl;
    }

};

class PracownikTechniczny : public Pracownik {
public:
    string specjalizacjaTechniczna = "";
    using Pracownik::Pracownik;

    PracownikTechniczny(string pImie, string pNazwisko, int pPensja, string pSpecjalizacjaTechniczna) : Pracownik(pImie, pNazwisko, pPensja), specjalizacjaTechniczna(pSpecjalizacjaTechniczna) {

    }

    void WypiszPT() {
        cout << "Imie: " << imie << ", Nazwisko: " << nazwisko << ", Pensja: " << pensja << ", Specjalizacja techniczna: " << specjalizacjaTechniczna << endl;
    }
};

class Menadzer : public Pracownik {
public:
    string listaPracownikow[3]{ "Janusz Chmura", "Tadeusz Chmura", "Marek Kowalski" };
    using Pracownik::Pracownik;

    Menadzer(string pImie, string pNazwisko, int pPensja) : Pracownik(pImie, pNazwisko, pPensja) {

    }

    void WypiszMN() {
        cout << "Imie: " << imie << ", Nazwisko: " << nazwisko << ", Pensja: " << pensja << ", Lista pracownikow: ";
        for (int i = 0; i < 3; i++) {
            cout << listaPracownikow[i] << ", ";
        }
    }
};

int main()
{
    Pracownik p1("Janusz", "Chmura", 5400);
    p1.Wypisz();

    PracownikBiura pB1("Tadeusz", "Chmura", 4300, 21);
    pB1.WypiszPB();

    PracownikTechniczny pT1("Marek", "Kowalski", 6300, "Technik Programista");
    pT1.WypiszPT();

    Menadzer pMN("Janusz", "Kowalski", 10000);
    pMN.WypiszMN();

}
