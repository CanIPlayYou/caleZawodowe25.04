#include <iostream>
using namespace std;

class Zespolone {
private:
	double re;
	double im;
	
public:
	Zespolone(double r, double i) {
		re = r;
		im = i;
	}

	Zespolone() {
		re = 0.0;
		im = 0.0;
	}

	Zespolone dodaj(Zespolone z1, Zespolone z2) {
		Zespolone wynik;
		wynik.re = z1.re + z2.re;
		wynik.im = z1.im + z1.im;


		return wynik;
		//return Zespolone(z1.re + z2.re, z1.im + z2.im);
	}

	Zespolone odejmij(Zespolone z1, Zespolone z2) {
		Zespolone wynik;
		wynik.re = z1.re - z2.re;
		wynik.im = z1.im - z2.im;

		return wynik;
	}

	Zespolone modul(Zespolone z1, Zespolone z2) {
		Zespolone wynik;

		wynik.re = (z1.re) * 2 + (z2.re) * 2;
		wynik.im = (z1.im) * 2 + (z2.im) * 2;

		return wynik;
	}
};

int main()
{
}
