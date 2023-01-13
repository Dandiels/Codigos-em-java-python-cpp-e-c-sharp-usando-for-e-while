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
        if (numero[i] >= 0 & numero[i] <= 100)
        {
            quantidade ++;
        }
    }
    switch (quantidade)
    {
        case 0:    
            cout << "Dos 20 números que você digitou, nenhum deles está entre 0 e 100." << endl;
            break;
        case 20:
            cout << "Dos 20 números que você digitou, todos eles estão entre 0 e 100." << endl;
            break;
        default:
            printf("Dos 20 números que você digitou, %d deles estão entre 0 e 100.\n", quantidade);
            break;
    }
    return 0;
}