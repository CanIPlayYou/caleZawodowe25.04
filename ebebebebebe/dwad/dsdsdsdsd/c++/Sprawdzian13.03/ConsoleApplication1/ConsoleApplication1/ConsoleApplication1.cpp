#include <iostream>

int main()
{
    std::cout << "Wprowadz cene dla przedmiotu - maslo: ";
    int cena1;
    std::cin >> cena1;

    std::cout << "Wprowadz narzute cenowa dla produktu - maslo: ";
    float narzuta1;
    std::cin >> narzuta1;

    //
    
    std::cout << "Wprowadz cene dla przedmiotu - chleb: ";
    int cena2;
    std::cin >> cena2;

    std::cout << "Wprowadz narzute cenowa dla produktu - chleb: ";
    float narzuta2;
    std::cin >> narzuta2;

    //

    std::cout << "Wprowadz cene dla przedmiotu - reczniki papierowe: ";
    int cena3;
    std::cin >> cena3;

    std::cout << "Wprowadz narzute cenowa dla produktu - reczniki papierowe: ";
    float narzuta3;
    std::cin >> narzuta3;

    //

    std::cout << "Wprowadz cene dla przedmiotu - okulary przeciwsloneczne: ";
    int cena4;
    std::cin >> cena4;

    std::cout << "Wprowadz narzute cenowa dla produktu - okulary przeciwsloneczne: ";
    float narzuta4;
    std::cin >> narzuta4;

    //

    std::cout << "\nCena detaliczna masla wynosi: " << cena1+(cena1*(narzuta1/100));
    std::cout << "\nCena detaliczna chlebu wynosi: " << cena2 + (cena2 * (narzuta2 / 100));
    std::cout << "\nCena detaliczna masla wynosi: " << cena3 + (cena3 * (narzuta3 / 100));
    std::cout << "\nCena detaliczna masla wynosi: " << cena4 + (cena4 * (narzuta4 / 100));
}