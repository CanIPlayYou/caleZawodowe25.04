#include <iostream>
using namespace std;

class Pojazd {
protected:
    string typ = "Nieznany";

public:
    Pojazd(string pTyp) {
        typ = pTyp;
    }

    void pokazTyp() {
        cout << "Typ pojazdu: " << typ << endl;
    }
};

class Samochod : public Pojazd {
public:
    int wiek;
    using Pojazd::Pojazd;

    Samochod(string pTyp, int sWiek) : Pojazd(pTyp), wiek(sWiek) {

    }
};


int main()
{
    Pojazd p1("N/A");

    Samochod s1("Samochod", 15);

    p1.pokazTyp();
    //p1.typ = "Samochod";
    p1.pokazTyp();

    s1.pokazTyp();
    //s1.typ = "Rower";
    s1.pokazTyp();
}