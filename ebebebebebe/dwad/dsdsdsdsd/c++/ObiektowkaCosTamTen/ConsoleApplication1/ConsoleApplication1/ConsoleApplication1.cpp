#include <iostream>
using namespace std;

class Samochod
{
private:
    int rokProdukcji;
    string marka;
public:
    Samochod(int rokPr, string mark) : rokProdukcji(rokPr), marka(mark){}

    void wyswietlInformacje() {
        cout << "Rok produkcji: " << rokProdukcji << " , marka: " << marka << endl;
    }
};

int main()
{
    Samochod sam1(2001, "Fiat");
    sam1.wyswietlInformacje();

    Samochod sam2(2021, "Toyota");
    sam2.wyswietlInformacje();
}