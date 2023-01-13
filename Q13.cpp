#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    float numero[20];
    int vezes = 1, quantidade = 0;
    for (int i = 0; i < sizeof numero / sizeof numero[0]; i ++, vezes ++)
    {
        printf("Digite o %d° número: ", vezes);
        cin >> numero[i];
        if (numero[i] > 8)
        {
            quantidade ++;
        }
    }
    switch (quantidade)
    {
        case 0:    
            cout << "Dos 20 números que você digitou, nenhum deles é maior do que 8." << endl;
            break;
        case 20:
            cout << "Dos 20 números que você digitou, todos eles são maiores do que 8." << endl;
            break;
        default:
            printf("Dos 20 números que você digitou, %d deles são maiores do que 8.\n", quantidade);
            break;
    }
    return 0;
}