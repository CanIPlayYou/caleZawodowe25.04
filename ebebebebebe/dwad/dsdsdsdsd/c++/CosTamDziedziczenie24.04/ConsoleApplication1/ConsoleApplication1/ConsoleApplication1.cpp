#include <iostream>

using namespace std;

class Osoba {
public:
    string imie;
    string nazwisko;
    string zwrocDane() {
        return imie + " " + nazwisko;
    }
};

class Przedmiot {
public:
    string przedmiot;
    string zwrocDane() {
        return przedmiot;
    }
};

class Klasa {
public:
    string klasa;
    string zwrocDane() {
        return klasa;
    }
};

class Pracownik : public Osoba {
public:
    string id;
    string zwrocDane() {
        return imie + " " + nazwisko + " numer id: " + id;
    }
};

class Nauczyciel : public Pracownik, public Przedmiot {
public:
    string zwrocDane() {
        return imie + " " + nazwisko + " Przedmiot: " + przedmiot;
    }
};

class Wychowawca : public Nauczyciel, public Klasa {
public:
    string zwrocDane() {
        return imie + " " + nazwisko + " Klasa: " + klasa;
    }
};

class Uczen : public Osoba, public Klasa {
public:
    string zwrocDane() {
        return imie + " " + nazwisko + " Klasa: " + klasa;
    }
};

int main()
{
    Wychowawca wychowawca;
    wychowawca.imie = "Jan";
    wychowawca.nazwisko = "Kowalski";
    wychowawca.przedmiot = "Informatyka";
    wychowawca.klasa = "4TEP";

    cout << "Dane nauczyciela wychowawcy: " << wychowawca.zwrocDane() << endl;

    Uczen uczen;
    uczen.imie = "Adam";
    uczen.nazwisko = "Nowak";
    uczen.klasa = "1TEP";

    cout << "Dane ucznia: " << uczen.zwrocDane() << endl;
}
