#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    int idade[20], soma = 0, vezes = 1;
    for (int i = 0; i < sizeof idade / sizeof idade[0]; i ++, vezes ++)
    {
        printf("Digite a %dª idade: ", vezes);
        cin >> idade[i];
        soma = soma + idade[i];
    }
    printf("A soma das 20 idades que você digitou é %d anos.\n", soma);
    return 0;
}