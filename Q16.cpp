#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    float numero[20];
    int vezes = 1, quantidade[] = {0, 0, 0};
    for (int i = 0; i < sizeof numero / sizeof numero[0]; i ++, vezes ++)
    {
        printf("Digite o %d° número: ", vezes);
        cin >> numero[i];
        if (numero[i] >= 0 & numero[i] <= 100)
        {
            quantidade[0] ++;
        }
        else if (numero[i] >= 101 & numero[i] <= 200)
        {
            quantidade[1] ++;
        }
        else if (numero[i] > 200)
        {
            quantidade[2] ++;
        }
    }
    if (quantidade[0] + quantidade[1] + quantidade[2] == 19)
    {
        printf("Entre 0 e 100: %d, entre 101 e 200: %d e maiores do que 200: %d.\n", quantidade[0], quantidade[1], quantidade[2]);
        cout << "O número restante é menor do que 0." << endl;
    }
    else if (quantidade[0] + quantidade[1] + quantidade[2] < 19)
    {
        printf("Entre 0 e 100: %d, entre 101 e 200: %d e maiores do que 200: %d.\n", quantidade[0], quantidade[1], quantidade[2]);
        cout << "Os números restantes são menores do que 0." << endl;
    }
    else
    {
        printf("Entre 0 e 100: %d, entre 101 e 200: %d e maiores do que 200: %d.\n", quantidade[0], quantidade[1], quantidade[2]);
    }
    return 0;
}