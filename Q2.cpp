#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    int numero, acumulador;
    cout << "Digite um número maior do que 0: ";
    cin >> numero;
    if (numero > 0)
    {
        acumulador = 0;
        cout << "A soma dos números entre zero e este número é ";
        for (int contador = 0; contador < numero; contador ++)
        {
            acumulador = acumulador + contador;
        }
        printf("%d.\n", acumulador);
    }
    else
    {
        cout << "Você deve digitar um número maior do que 0." << endl;
    }
    return 0;
}