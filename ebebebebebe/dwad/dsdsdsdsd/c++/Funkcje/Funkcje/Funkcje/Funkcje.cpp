
#include <iostream>
using namespace std;

//Deklaracja funkcji
int dodaj(int, int);

//Mozna tez tak, czyli odrazu definiowac i deklarowac
int dodaj2(int a, int b) {
    return a + b;
}

int main()
{
    cout << dodaj(4, 5);
    cout << " ";
    cout << dodaj2(5, 10);
}

//Definicja funkcji
int dodaj(int a, int b) {
    return a + b;
}