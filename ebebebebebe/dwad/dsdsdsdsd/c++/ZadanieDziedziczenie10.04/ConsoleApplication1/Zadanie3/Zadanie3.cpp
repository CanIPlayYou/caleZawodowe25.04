#include <iostream>
using namespace std;

class KsiazkaAdresowa {
protected:
    string imie = "";
    string nazwisko = "";
    string adres_email = "";
    string nr_telefonu = "";

public:
    KsiazkaAdresowa(string pImie, string pNazwisko, string pAdres_email, string pNr_telefonu) {
        imie = pImie;
        nazwisko = pNazwisko;
        adres_email = pAdres_email;
        nr_telefonu = pNr_telefonu;
    }

    void Wypisz() {
        cout << "Imie: " << imie << ", Nazwisko: " << nazwisko << ", Adres email: " << adres_email << ", Numer telefonu: " << nr_telefonu << endl;
    }

    void DodajKontakt() {

    }
    
};

int main()
{
    KsiazkaAdresowa k1("Janusz", "Chmura", "testmail@wp.pl", "983 231 023");
    k1.Wypisz();


}
