#include <iostream>
#include <random>
#include <array>

void generowanieTablicy(int tab[]) {
    for (int n = 1; n < 101; n++) {
        tab[n] = n; //Przypisanie do tablicy generowanych liczb
    }
}

int main()
{
    int A[101];

    generowanieTablicy(A);

    /*for (int i = 2; i < 11, i++) {
        if (A[i] = true) {
            for (int j = 2*i, j < 101, j++) {

            }
        }
    }*/
}
