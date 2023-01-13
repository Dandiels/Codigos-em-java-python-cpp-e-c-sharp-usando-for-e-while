#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    int idade[20], vezes = 1, pessoas = 0;
    for (int i = 0; i < sizeof idade / sizeof idade[0]; i ++, vezes ++)
    {
        printf("Digite a %dª idade: ", vezes);
        cin >> idade[i];
        if (idade[i] >= 18)
        {
            pessoas ++;
        }
    }
    switch (pessoas)
    {
        case 0:    
            cout << "Das 20 idades que você digitou, nenhuma delas são de pessoas maiores de idade." << endl;
            break;
        case 20:
            cout << "Das 20 idades que você digitou, todas elas são de pessoas maiores de idade." << endl;
            break;
        default:
            printf("Das 20 idades que você digitou, %d delas são de pessoas maiores de idade.\n", pessoas);
            break;
    }
    return 0;
}