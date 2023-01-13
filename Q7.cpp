#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    float numero[10], soma = 0; 
    int vezes = 1;
    for (int i = 0; i < sizeof numero / sizeof numero[0]; i ++, vezes ++)
    {
        printf("Digite o %d° número: ", vezes);
        cin >> numero[i];
        soma = soma + numero[i];
    }
    cout << "A soma dos 10 números que você digitou é " << soma << "." << endl;
    return 0;
}