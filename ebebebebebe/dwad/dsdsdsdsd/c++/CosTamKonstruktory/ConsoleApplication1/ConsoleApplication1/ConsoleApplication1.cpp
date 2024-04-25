#include <iostream>

using namespace std;

struct Data {
    int dzien, miesiac, rok;
};

class Uczen
{
public:
    int id;
    string imie;
    Data data_urodzenia;

    Uczen() {
        id = -1;
        imie = "Imie domyślne";
        data_urodzenia = { 01,01,1970 };
    }
};
int main()
{
    Uczen ucz1;

    cout << "ID: " << ucz1.id << ", Imie: " << ucz1.imie << ", Data urodzenia: " << ucz1.data_urodzenia.rok;

    return 0;
}
