#include <iostream>
#include <string>
#include <vector>
#include <random>

class Zadanie2 {
private:
    std::vector<int> v;

public:
    void generowanieLiczbDoWektora(int ileLiczbDoWylosowania) {
        std::mt19937 gen(std::random_device{}());
        std::uniform_int_distribution<int> distrib(1, 30);
        for (int n = 0; n < ileLiczbDoWylosowania; n++) { 
            v.push_back(distrib(gen));
        }

        for (int i = 0; i < ileLiczbDoWylosowania; i++) {
            std::cout << "\nElement " << i + 1 << " w wektorze to: " << v[i];
        }
    }

    void sortowanieBabelkowe(int iloscLiczb) {
        for (int i = 0; i < iloscLiczb; i++) {
            for (int j = 1; j < iloscLiczb - i; j++) {
                if (v[j - 1] > v[j]) {
                    std::swap(v[j - 1], v[j]);
                }
            }
        }

        std::cout << "\n\nSortowanie babelkowe: ";

        for (int j = 0; j < iloscLiczb; j++) {
            std::cout << "\nElement " << j + 1 << " w wektorze to: " << v[j];
        }
    }

    void sortowaniePrzezWstawianie(int iloscLiczb) {
        int pom;
        int j;

        for (int i = 1; i < iloscLiczb; i++)
        {
            pom = v[i];
            j = i - 1;

            while (j >= 0 && v[j] > pom)
            {
                v[j + 1] = v[j];
                --j;
            }
            v[j + 1] = pom;
        }

        std::cout << "\n\nSortowanie przez wstawianie: ";

        for (int j = 0; j < iloscLiczb; j++) {
            std::cout << "\nElement " << j + 1 << " w wektorze to: " << v[j];
        }
    }

    void sortowaniePrzezWybor(int iloscLiczb) {
        int minIndex;

        for (int i = 0; i < iloscLiczb - 1; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < iloscLiczb; j++) {
                if (v[j] < v[minIndex]) {
                    minIndex = j;
                }
            }

            std::swap(v[i], v[minIndex]);
        }

        std::cout << "\n\nSortowanie przez wybieranie: ";

        for (int j = 0; j < iloscLiczb; j++) {
            std::cout << "\nElement " << j + 1 << " w wektorze to: " << v[j];
        }
    }
};

int main()
{
    bool czyBezPowtorzen = false;
    int ileLiczbDoWylosowania = 0;

    std::string tekstWpisany;
    std::cout << "Czy liczby maja byc bez powtorzen? (tak / nie): ";
    getline(std::cin, tekstWpisany);

    if (tekstWpisany == "tak") {
        czyBezPowtorzen = true;
    }
    else {
        czyBezPowtorzen = false;
    }

    std::cout << "Podaj ilosc liczb do wylosowania: ";
    std::cin >> ileLiczbDoWylosowania;

    Zadanie2 zad;

    zad.generowanieLiczbDoWektora(ileLiczbDoWylosowania);

    zad.sortowanieBabelkowe(ileLiczbDoWylosowania);
    
    zad.sortowaniePrzezWstawianie(ileLiczbDoWylosowania);

    zad.sortowaniePrzezWybor(ileLiczbDoWylosowania);\
}
