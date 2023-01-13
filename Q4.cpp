#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    int vezes = 1;
    for (int contador = 0; contador < 20; contador ++, vezes ++)
    {
        printf("%dª Vez: Eu gosto de estudar Algoritmos!\n", vezes);
    }
    return 0;
}