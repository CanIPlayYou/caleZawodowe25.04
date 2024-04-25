#include <iostream>
#include <random>
#include <array>

void generowanieTablicy(int tab[]) {
    std::mt19937 gen(std::random_device{}());
    std::uniform_int_distribution<int> distrib(1, 30);

    for (int n = 0; n < 20; n++) {
        tab[n] = distrib(gen); //Przypisanie do tablicy generowanych liczb
    }
}

void wypisanieTablicy(int tab[]) {
    for (int i = 0; i < 20; i++) {
        std::cout << tab[i] << ' '; //Wypisanie liczb z tablicy ze spacja(' ')
    }

    std::cout << "\n";
}

void minimImaxim(int tab[]) {
    int min = tab[0];
    int max = tab[0];

    for (int i = 0; i < 20; i++) {
        if (tab[i] < min) {
            min = tab[i];
        }
        
        if (tab[i] > max) {
            max = tab[i];
        }
    }

    std::cout << "Najmniejsza liczba w tablicy to: " << min << "\n";
    std::cout << "Najwieksza liczba w tablicy to: " << max << "\n\n";
}

void sprawdzCzyPodanaLiczbaIstnieje(int tab[]) {
    int liczbaPodana;
    bool czyZnajdujeSie = false;

    std::cout << "Wprowadz liczbe: ";
    std::cin >> liczbaPodana;  //Zapisanie danych podanych przez uzytkownika do zmiennej

    for (int i = 0; i < 20; i++) {
        if (tab[i] == liczbaPodana) {
            czyZnajdujeSie = true;
            break;
        }
        else {
            czyZnajdujeSie = false;
        }
    }

    if (czyZnajdujeSie) {
        std::cout << "Liczba " << liczbaPodana << " znajduje sie w tablicy";
    }
    else {
        std::cout << "Podana liczba nie znajduje sie w tablicy";
    }
}

int main()
{
    int tablica[20];

    generowanieTablicy(tablica);

    wypisanieTablicy(tablica);

    minimImaxim(tablica);

    sprawdzCzyPodanaLiczbaIstnieje(tablica);

    std::cout << '\n';
    return 0;
}