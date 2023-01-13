#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    float numero;
    cout << "Digite um número: ";
    cin >> numero;
    cout << "A tabuada de multiplicação de 1 à 10 deste número é:" << endl;
    for (int multiplicador = 1; multiplicador <= 10; multiplicador ++)
    {
        cout << numero << " x " << multiplicador << " = " << numero * multiplicador << "." << endl;
    }
    return 0;
}