#include <iostream>
using namespace std;

class ConvertUsdToPln {
    private:
        float ilosc_pieniedzy = 0;
        float kurs_waluty = 3.92;
    public:
        ConvertUsdToPln(float iloscPieniedzy) : ilosc_pieniedzy(iloscPieniedzy) {
            cout << iloscPieniedzy << " USD = " << iloscPieniedzy * kurs_waluty << " PLN \n";
        }

        ConvertUsdToPln(float iloscPieniedzy, float kursWaluty) : ilosc_pieniedzy(iloscPieniedzy), kurs_waluty(kursWaluty) {
            cout << iloscPieniedzy << " USD = " << iloscPieniedzy * kursWaluty << " PLN";
        }
};


int main()
{
    ConvertUsdToPln c1(300.00);
    ConvertUsdToPln c2(450.00, 3.85);
    

    return 0;
}