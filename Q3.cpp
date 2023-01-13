#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    int num1, num2, soma;
    cout << "Digite um número maior ou igual à 0: ";
    cin >> num1;
    if (num1 < 0)
    {
        cout << "Você deve digitar um número maior ou igual à 0." << endl;
    }
    else
    {
        cout << "Digite outro número também maior ou igual à 0: ";
        cin >> num2;
        if (num2 < 0)
        {
            cout << "Você deve digitar um número maior ou igual à 0." << endl;
        }
        else
        {
            soma = 0;
            for (int contador = 0; contador < num2; contador ++)
            {
                soma = soma + num1;
            }
            printf("O resultado da multiplicação entre estes dois números, através de somas repetidas, é %d.\n", soma);
        }
    }
    return 0;
}