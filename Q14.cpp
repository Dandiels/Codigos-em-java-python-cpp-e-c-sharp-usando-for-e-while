#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    int numero[20], vezes = 1, quantidade = 0;
    for (int i = 0; i < sizeof numero / sizeof numero[0]; i ++, vezes ++)
    {
        printf("Digite o %d° número: ", vezes);
        cin >> numero[i];
        if (numero[i] % 2 == 0)
        {
            quantidade ++;
        }
    }
    switch (quantidade)
    {
        case 0:    
            cout << "Dos 20 números que você digitou, nenhum deles é par." << endl;
            break;
        case 20:
            cout << "Dos 20 números que você digitou, todos eles são pares." << endl;
            break;
        default:
            printf("Dos 20 números que você digitou, %d deles são pares.\n", quantidade);
            break;
    }
    return 0;
}